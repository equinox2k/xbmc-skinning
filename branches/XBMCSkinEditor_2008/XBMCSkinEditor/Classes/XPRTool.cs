using System;
using System.Collections.Generic;
using System.Text;

namespace XBMCSkinEditor.Classes
{
    public struct XPRFileInfo
    {

        public string Name;
        public int Offset;
        public int UnpackedSize;
        public int PackedSize;
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
    }
}
