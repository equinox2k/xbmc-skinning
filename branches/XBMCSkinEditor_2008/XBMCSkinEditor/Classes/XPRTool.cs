using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace XBMCSkinEditor.Classes
{
    public struct XPRFileInfo
    {

        public string Name;
        public int Offset;
        public int UnpackedSize;
        public int PackedSize;
    }

    public struct D3DTexture
    {
        public UInt32 Common;
        public UInt32 Data;
        public UInt32 Lock;
        public UInt32 Format;
        public UInt32 Size;
        public UInt32 Delay;
    }

    public class XPRTool
    {
        private const int XPR_MAGIC_HEADER_VALUE = 5394520;
        private const int XPRFLAG_PALETTE = 1;
        private const int XPRFLAG_ANIM = 2;
        private const int D3DCOMMON_TYPE_MASK = 458752;
        private const int D3DCOMMON_TYPE_TEXTURE = 262144;
        private const int D3DFORMAT_A1R5G5B5 = 2;
        private const int D3DFORMAT_A8R8G8B8 = 6;
        private const int D3DFORMAT_P8 = 11;
        private const int D3DFORMAT_DXT1 = 12;
        private const int D3DFORMAT_DXT3 = 14;
        private const int D3DFORMAT_DXT5 = 15;
        private const int D3DFORMAT_LIN_A8R8G8B8 = 18;
        
        private System.IO.FileStream ofs = null;
        private System.IO.BinaryReader obr = null;
        private bool blnProtectionEnabled = false;
        public System.Collections.Generic.List<XPRFileInfo> XPRFileInfoList = new System.Collections.Generic.List<XPRFileInfo>();

        [DllImport("XPRTool.dll")]
        private static extern void Unswizzle(byte[] Source, int Depth, int Width, int Height, byte[] Dest);
        [DllImport("XPRTool.dll")]
        private static extern void ConvertA1R5G5B5(byte[] Source, int Width, int Height, byte[] Dest);
        [DllImport("XPRTool.dll")]
        private static extern void ConvertDXT1(byte[] Source, int Width, int Height, byte[] Dest);
        [DllImport("XPRTool.dll")]
        private static extern void ConvertDXT3(byte[] Source, int Width, int Height, byte[] Dest);
        [DllImport("XPRTool.dll")]
        private static extern void ConvertDXT5(byte[] Source, int Width, int Height, byte[] Dest);
        [DllImport("XPRTool.dll")]
        private static extern void MapPalette(byte[] Pal, byte[] Source, int Width, int Height, byte[] Dest);
        [DllImport("lzo.dll")]
        private static extern int lzo1x_decompress_safe(byte[] Source, int SourceLength, byte[] Dest, ref int DestLength, byte[] WorkMem);

        private bool FormatIsSwizzled(int intFormat)
        {
            switch (intFormat)
            {
                case D3DFORMAT_A1R5G5B5:
                    return true;
                case D3DFORMAT_A8R8G8B8:
                    return true;
                case D3DFORMAT_P8:
                    return true;
                default:
                    return false;
            }
        }
        private bool FormatIsSupported(int intFormat)
        {
            switch (intFormat)
            {
                case D3DFORMAT_A1R5G5B5:
                    return true;
                case D3DFORMAT_A8R8G8B8:
                    return true;
                case D3DFORMAT_DXT1:
                    return true;
                case D3DFORMAT_DXT3:
                    return true;
                case D3DFORMAT_DXT5:
                    return true;
                case D3DFORMAT_P8:
                    return true;
                case D3DFORMAT_LIN_A8R8G8B8:
                    return true;
                default:
                    return false;
            }
        }
        private int GetDepth(int intFormat)
        {
            switch (intFormat)
            {
                case D3DFORMAT_A1R5G5B5:
                    return 4;
                case D3DFORMAT_A8R8G8B8:
                    return 4;
                case D3DFORMAT_DXT1:
                    return 4;
                case D3DFORMAT_DXT3:
                    return 4;
                case D3DFORMAT_DXT5:
                    return 4;
                case D3DFORMAT_P8:
                    return 1;
                case D3DFORMAT_LIN_A8R8G8B8:
                    return 4;
                default:
                    return 0;
            }
        }
        public static UInt32 GetWord(byte[] bytData, ref int Offset)
        {
            UInt32 intValue;
            intValue = (UInt32)bytData[Offset + 1] << 8;
            intValue += bytData[Offset];
            Offset += 2;
            return intValue;
        }
        public static UInt32 GetDWord(byte[] bytData, ref int Offset)
        {
            UInt32 intValue;
            intValue = (UInt32)bytData[Offset];
            intValue += (UInt32)bytData[Offset + 1] << 8;
            intValue += (UInt32)bytData[Offset + 2] << 16;
            intValue += (UInt32)bytData[Offset + 3] << 24;
            Offset += 4;
            return intValue;
        }

        public void OpenXPR(string filename)
        {
            this.ofs = new System.IO.FileStream(filename, System.IO.FileMode.Open);
            this.obr = new System.IO.BinaryReader(ofs);
            if (this.ofs.Length < 12)
            {
                throw new ApplicationException("Invalid XPR length in file '" + filename + "'.");
            }
            int intMagic = this.obr.ReadInt32();
            
            int intVersion = ((intMagic >> 24) & 127) - 48;
            blnProtectionEnabled = ((intMagic >> 24) & 128) == 0;

            if ((intMagic & 16777215) != XPR_MAGIC_HEADER_VALUE | intVersion < 2)
            {
                blnProtectionEnabled = false;
                return;
            }
            int intTotalSize = this.obr.ReadInt32();
            if (intTotalSize != this.ofs.Length)
                throw new ApplicationException("Invalid XPR header in file '" + filename + "'.");

            int intHeaderSize = this.obr.ReadInt32();
            if ((intHeaderSize - 12) % 128 > 0)
                throw new ApplicationException("Invalid XPR header in file '" + filename + "'.");
            this.XPRFileInfoList.Clear();
            for (int intloop = 1; intloop <= (intHeaderSize - 12) >> 7; intloop++)
            {
                XPRFileInfo objXPRFileInfo = new XPRFileInfo();
                byte[] arrBytes = this.obr.ReadBytes(116);
                System.Text.ASCIIEncoding objEncoder = new System.Text.ASCIIEncoding();
                objXPRFileInfo.Name = objEncoder.GetString(arrBytes).Split('\0')[0];
                objXPRFileInfo.Offset = this.obr.ReadInt32();
                objXPRFileInfo.UnpackedSize = this.obr.ReadInt32();
                objXPRFileInfo.PackedSize = this.obr.ReadInt32();
                XPRFileInfoList.Add(objXPRFileInfo);
            }
        }
        private SkinImage ConvertTextures(SkinImage SkinImage, bool HasPalette, int RealSizeWidth, int RealSizeHeight, System.Collections.Generic.List<D3DTexture> Textures, int ResDataOffset, byte[] Buffer)
        {

            for (int intLoop = 0; intLoop < Textures.Count; intLoop++)
            {

                D3DTexture objTex = Textures[intLoop];

                if ((objTex.Common & D3DCOMMON_TYPE_MASK) != D3DCOMMON_TYPE_TEXTURE)
                    throw new ApplicationException("Unsupported texture format.");

                int intTexWidth;
                int intTexHeight;
                int intTexFormat = (int)((objTex.Format & 65280) >> 8);
                if (intTexFormat == D3DFORMAT_LIN_A8R8G8B8)
                {
                    intTexWidth = (RealSizeWidth + 63);  //& (!63);
                    intTexHeight = RealSizeHeight;
                }
                else
                {
                    int foo = (int)((objTex.Format & 15728640) >> 20);
                    UInt32 foo2 = ((objTex.Format & 251658240) >> 24);
                    intTexWidth = (int) 1 << foo;
                    intTexHeight = (int)(1 << (int)foo2); //1 << (foo2)
                }
                int intTexDepth = GetDepth(intTexFormat);

                int intTexSize = (intTexWidth * intTexHeight * intTexDepth);
                int intTextureOffset = ResDataOffset;
                int intPaletteOffset = 0;
                if (HasPalette == true)
                {
                    intTextureOffset = ResDataOffset + 1024;
                    intPaletteOffset = ResDataOffset;
                }

                intTextureOffset += (intLoop - 1) * intTexSize;

                if (!FormatIsSupported(intTexFormat))
                    throw new ApplicationException("Unsupported texture format.");

                byte[] bytSource = new byte[(Buffer.Length - intTextureOffset)];
                byte[] bytDest = new byte[(intTexWidth * intTexHeight * intTexDepth)];
                Array.Copy(Buffer, intTextureOffset, bytSource, 0, Buffer.Length - intTextureOffset);

                if (intTexFormat == D3DFORMAT_A1R5G5B5)
                {
                    byte[] bytDestTemp = new byte[(intTexWidth * intTexHeight * intTexDepth)];
                    ConvertA1R5G5B5(bytSource, intTexWidth, intTexHeight, bytDestTemp);
                    Unswizzle(bytDestTemp, intTexDepth, intTexWidth, intTexHeight, bytDest);
                }
                else if (intTexFormat == D3DFORMAT_DXT1)
                {
                    ConvertDXT1(bytSource, intTexWidth, intTexHeight, bytDest);
                }
                else if (intTexFormat == D3DFORMAT_DXT3)
                {
                    ConvertDXT3(bytSource, intTexWidth, intTexHeight, bytDest);
                }
                else if (intTexFormat == D3DFORMAT_DXT5)
                {
                    ConvertDXT5(bytSource, intTexWidth, intTexHeight, bytDest);
                }
                else if (intTexFormat == D3DFORMAT_LIN_A8R8G8B8)
                {
                    Array.Copy(bytSource, 0, bytDest, 0, bytSource.Length);
                }
                else if (FormatIsSwizzled(intTexFormat) == true)
                {
                    Unswizzle(bytSource, intTexDepth, intTexWidth, intTexHeight, bytDest);
                }

                if (HasPalette == false)
                {

                    Bitmap objImageBack = new Bitmap((int)intTexWidth, (int)RealSizeHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    Graphics objGraphics = Graphics.FromImage(objImageBack);
                    objGraphics.Clear(Color.Transparent);

                    System.Drawing.Imaging.BitmapData m_BitmapData;
                    Bitmap objBitmap = new Bitmap(objImageBack);
                    Rectangle bounds = new Rectangle(0, 0, objBitmap.Width, objBitmap.Height);
                    m_BitmapData = objBitmap.LockBits(bounds, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    int RowSizeBytes = m_BitmapData.Stride;
                    int total_size = m_BitmapData.Stride * m_BitmapData.Height;
                    Marshal.Copy(bytDest, 0, m_BitmapData.Scan0, total_size);
                    objBitmap.UnlockBits(m_BitmapData);

                    objBitmap = objBitmap.Clone(new Rectangle(0, 0, RealSizeWidth, (int)RealSizeHeight), System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    ImageFrame objImageFrame = new ImageFrame();
                    objImageFrame.Frame = objBitmap;
                    objImageFrame.Delay = objTex.Delay;
                    SkinImage.Frames.Add(objImageFrame);
                }

                else
                {

                    byte[] bytPalette = new byte[1024];
                    byte[] bytMappedDest = new byte[((intTexWidth * intTexHeight) << 2)];
                    Array.Copy(Buffer, intPaletteOffset, bytPalette, 0, 1024);

                    MapPalette(bytPalette, bytDest, intTexWidth, intTexHeight, bytMappedDest);

                    Bitmap objImageBack = new Bitmap((int)intTexWidth, (int)RealSizeHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    Graphics objGraphics = Graphics.FromImage(objImageBack);
                    objGraphics.Clear(System.Drawing.Color.Transparent);

                    System.Drawing.Imaging.BitmapData m_BitmapData;
                    Bitmap objBitmap = new Bitmap(objImageBack);
                    Rectangle bounds = new Rectangle(0, 0, objBitmap.Width, objBitmap.Height);
                    m_BitmapData = objBitmap.LockBits(bounds, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    int RowSizeBytes = m_BitmapData.Stride;
                    int total_size = m_BitmapData.Stride * m_BitmapData.Height;
                    System.Runtime.InteropServices.Marshal.Copy(bytMappedDest, 0, m_BitmapData.Scan0, total_size);
                    objBitmap.UnlockBits(m_BitmapData);
                    objBitmap = objBitmap.Clone(new Rectangle(0, 0, RealSizeWidth, RealSizeHeight), System.Drawing.Imaging.PixelFormat.Format32bppArgb);


                    ImageFrame objImageFrame = new ImageFrame();
                    objImageFrame.Frame = objBitmap;
                    objImageFrame.Delay = objTex.Delay;
                    SkinImage.Frames.Add(objImageFrame);

                }

            }

            return SkinImage;

        }

        private SkinImage ConvertTextures(byte[] Buffer)
        {
            #warning MAJORLY BROKEN AND UNTESTED
            SkinImage objSkinImage = new SkinImage();
            bool blnHasPalette = false;
            D3DTexture objTex = new D3DTexture();
            System.Collections.Generic.List<D3DTexture> colTextures = new System.Collections.Generic.List<D3DTexture>();
            UInt32 intRealSizeWidth = 0;
            UInt32 intRealSizeHeight = 0;
            int intNext = 0;
            
            UInt32 intFlags = XPRTool.GetDWord(Buffer, ref intNext);
            UInt32 intLoops = 0;
            //If (intFlags And XPRFLAG_ANIM Or (intFlags >> 16) > 1) Then
           
            if ( (intFlags >> 16) > 1)
            {
                intLoops = GetDWord(Buffer, ref intNext);
                intRealSizeWidth = GetWord(Buffer, ref intNext);
                intRealSizeHeight = GetWord(Buffer, ref intNext);
                /*if (intFlags & XPRFLAG_PALETTE)
                {
                    blnHasPalette = true;
                    intNext += 12;
                }*/
                UInt32 intTextures = intFlags >> 16;
                for (int intLoop = 1; intLoop <= intTextures; intLoop++)
                {
                    objTex = new D3DTexture();
                    objTex.Common = GetDWord(Buffer, ref intNext);
                    objTex.Data = GetDWord(Buffer, ref intNext);
                    objTex.Lock = GetDWord(Buffer, ref intNext);
                    objTex.Format = GetDWord(Buffer, ref intNext); ;
                    objTex.Size = GetDWord(Buffer, ref intNext);
                    objTex.Delay = GetDWord(Buffer, ref intNext);
                    colTextures.Add(objTex);
                }
            }
            else
            {
                /*if (intFlags & XPRFLAG_PALETTE)
                {
                    blnHasPalette = true;
                    intNext += 12;
                }*/
                objTex = new D3DTexture();
                objTex.Common = GetDWord(Buffer, ref intNext);
                objTex.Data = GetDWord(Buffer, ref intNext);
                objTex.Lock = GetDWord(Buffer, ref intNext);
                objTex.Format = GetDWord(Buffer, ref intNext);
                objTex.Size = GetDWord(Buffer, ref intNext);
                objTex.Delay = 0;
                colTextures.Add(objTex);
                intRealSizeWidth = GetWord(Buffer, ref intNext);
                intRealSizeHeight = GetWord(Buffer, ref intNext);
            }

            objSkinImage.Loops = 0;

            int intResDataOffset = intNext + 127; // //(intNext + 127) & (!127);
            return ConvertTextures(objSkinImage, blnHasPalette, (int)intRealSizeWidth, (int)intRealSizeHeight, colTextures, intResDataOffset, Buffer);
        }

        //public SkinImage GetImage(string filename)
        /*public System.Drawing.Image GetImage(string filename)
        {
            XPRFileInfo objXPRFileInfo = (XPRFileInfo)colXPRFileInfo.Item[Index);
            obr.BaseStream.Seek(objXPRFileInfo.Offset, System.IO.SeekOrigin.Begin);
            byte[] bytPackedFile = obr.ReadBytes(objXPRFileInfo.PackedSize);
            byte[] bytUnpackedFile = Decompress(objXPRFileInfo.UnpackedSize, bytPackedFile);
            return ConvertTextures(bytUnpackedFile);
        }*/

        public bool ProtectionEnabled
        {

            get { return blnProtectionEnabled; }
        }

        public void CloseXPR()
        {
            this.blnProtectionEnabled = false;
            if (this.obr != null)
                this.obr.Close();
            if (this.ofs  != null)
                this.ofs.Close();
        }

        private byte[] Decompress(int OrigLength, byte[] Source)
        {
            byte[] bytBuffer = new byte[OrigLength];
            int intOrigLength = OrigLength;
            try
            {

                lzo1x_decompress_safe(Source, Source.Length, bytBuffer, ref intOrigLength, null);
            }
            catch (DllNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("lzo.dll is missing");
            }
            return bytBuffer;
        }

        internal SkinImage GetImage(string filename)
        {
            XPRFileInfo objXPRFileInfo = new XPRFileInfo();
            foreach (XPRFileInfo xfi in XPRFileInfoList) {
                if (xfi.Name == filename)
                    objXPRFileInfo = xfi;
            }
            obr.BaseStream.Seek(objXPRFileInfo.Offset, System.IO.SeekOrigin.Begin);
            byte[] bytPackedFile = obr.ReadBytes(objXPRFileInfo.PackedSize);
            byte[] bytUnpackedFile = Decompress(objXPRFileInfo.UnpackedSize, bytPackedFile);
            return ConvertTextures(bytUnpackedFile);
        }
    }
}
