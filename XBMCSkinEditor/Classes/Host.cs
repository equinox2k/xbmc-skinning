using System.Drawing.Imaging;
using SkinEditor.XPRDecoder;

using XBMCSkinEditor.Properties;
using System.Windows.Forms;
using System.Drawing;

namespace XBMCSkinEditor.Classes
{
    public class Host : SkinEditor.Interfaces.IHost
    {
        
        public event ErrorEventEventHandler ErrorEvent;
        public delegate void ErrorEventEventHandler(int ErrorLevel, string Message, string File, int Line, int Pos);

        private Settings objSettings = new Settings();

        public string AppPath() {
            return System.AppDomain.CurrentDomain.BaseDirectory;
        }
        //Public Function HasSettings(ByVal PluginName As String) Implements IHost.H
        // objSettings.SetPluginSetting(PluginName, SettingName, Value)
        // return objHost.
        //End Function
        #region "Misc Functions"

        public void ShowMessage(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message);
        }

        public void ShowForm(Form Form, string DockLocation)
        {
            Form.Show();
        }

        public void ShowDockContent(WeifenLuo.WinFormsUI.Docking.DockContent DockCon, WeifenLuo.WinFormsUI.Docking.DockState DDockStyle)
        {
            DockCon.Show(MainWin.mMainWin.DockPanel, DDockStyle);
        }

        public DialogResult ShowDialog(Form Form)
        {
            return Form.ShowDialog();
        }

        public void ErrorOccured(int ErrorLevel, string Message, string File, int Line, int Pos)
        {
            if (ErrorEvent != null)
            {
                ErrorEvent(ErrorLevel, Message, File, Line, Pos);
            }
        }

        public object[] ExecuteCommand(string Command, object[] Parameters)
        {
            return null;
        }

        #endregion

        #region "XPR Functions"

        public int GetXPRImageCount(string FileName)
        {
            int functionReturnValue = 0;
            Decoder objDecoder = new Decoder();
            objDecoder.OpenXPR(FileName);
            functionReturnValue = objDecoder.FileCount;
            objDecoder.CloseXPR();
            return functionReturnValue;
        }

        public string GetXPRImageName(string FileName, int ImageIndex)
        {
            string functionReturnValue = null;
            Decoder objDecoder = new Decoder();
            objDecoder.OpenXPR(FileName);
            functionReturnValue = objDecoder.get_FileName(ImageIndex);
            objDecoder.CloseXPR();
            return functionReturnValue;
        }

        public int GetXPRImageLoops(string FileName, int ImageIndex)
        {
            int functionReturnValue = 0;
            SkinEditor.XPRDecoder.Decoder objDecoder = new SkinEditor.XPRDecoder.Decoder();
            objDecoder.OpenXPR(FileName);
            functionReturnValue = objDecoder.get_GetImage(ImageIndex).Loops;
            objDecoder.CloseXPR();
            return functionReturnValue;
        }

        public int GetXPRImageFrameCount(string FileName, int ImageIndex)
        {
            int functionReturnValue = 0;
            Decoder objDecoder = new Decoder();
            objDecoder.OpenXPR(FileName);
            functionReturnValue = objDecoder.get_GetImage(ImageIndex).Frames.Count;
            objDecoder.CloseXPR();
            return functionReturnValue;
        }

        public int GetXPRImageFrameDelay(string FileName, int ImageIndex, int FrameIndex)
        {
            int functionReturnValue = 0;
            Decoder objDecoder = new Decoder();
            objDecoder.OpenXPR(FileName);
            functionReturnValue = objDecoder.get_GetImage(ImageIndex).Frames[FrameIndex].Delay;
            objDecoder.CloseXPR();
            return functionReturnValue;
        }

        public Image GetXPRImageFrame(string FileName, int ImageIndex, int FrameIndex)
        {
            Image functionReturnValue = null;
            Decoder objDecoder = new Decoder();
            objDecoder.OpenXPR(FileName);
            functionReturnValue = objDecoder.get_GetImage(ImageIndex).Frames[FrameIndex].Frame;
            objDecoder.CloseXPR();
            return functionReturnValue;
        }

        public void SaveXPRImage(string FileName, int ImageIndex, string DestFileName)
        {
            Decoder objDecoder = new Decoder();
            objDecoder.OpenXPR(FileName);
            objDecoder.SaveImage(ImageIndex, DestFileName);
            objDecoder.CloseXPR();
        }

        public void SaveXPRImageFrame(string FileName, int ImageIndex, int FrameIndex, string DestFileName)
        {
            Decoder objDecoder = new Decoder();
            objDecoder.OpenXPR(FileName);
            objDecoder.get_GetImage(ImageIndex).Frames[FrameIndex].Frame.Save(DestFileName);
            objDecoder.CloseXPR();
        }

        #endregion

        #region "GIF Functions"

        public int GetGIFImageLoops(string FileName) {
        int functionReturnValue = 0;

        System.Drawing.Image objImage = System.Drawing.Image.FromFile(FileName);
        FrameDimension objDimension = new FrameDimension(objImage.FrameDimensionsList[0]);
        
        functionReturnValue = 0;
        
        foreach (PropertyItem objPropertyItem in objImage.PropertyItems) {
            switch (objPropertyItem.Id) {
                case 20737:
                    functionReturnValue = System.BitConverter.ToInt16(objImage.GetPropertyItem(objPropertyItem.Id).Value, 0);
                    break;
            }
        }
        
        objImage.Dispose();
        return functionReturnValue;
        
    }

        public int GetGIFImageFrameCount(string FileName)
        {
            int functionReturnValue = 0;

            System.Drawing.Image objImage = System.Drawing.Image.FromFile(FileName);
            FrameDimension objDimension = new FrameDimension(objImage.FrameDimensionsList[0]);
            functionReturnValue = objImage.GetFrameCount(objDimension);
            objImage.Dispose();
            return functionReturnValue;

        }

        public int GetGIFImageFrameDelay(string FileName, int FrameIndex)
    {
        int functionReturnValue = 0;
        
        byte[] bytDelays = null;
        System.Drawing.Image objImage = System.Drawing.Image.FromFile(FileName);
        FrameDimension objDimension = new FrameDimension(objImage.FrameDimensionsList[0]);
        
        foreach (PropertyItem objPropertyItem in objImage.PropertyItems)
        {
            switch (objPropertyItem.Id) {
                case 20736:
                    bytDelays = objImage.GetPropertyItem(objPropertyItem.Id).Value;
                    break;
            }
        }
        
        if (bytDelays == null) {
            functionReturnValue = 0;
        }
        else {
            functionReturnValue = System.BitConverter.ToInt32(bytDelays, FrameIndex * 4) * 10;
        }
        
        objImage.Dispose();
        return functionReturnValue;
        
    }

        public Image GetGIFImageFrame(string FileName, int FrameIndex)
        {
            Image functionReturnValue = null;

            System.Drawing.Image objImage = System.Drawing.Image.FromFile(FileName);
            FrameDimension objDimension = new FrameDimension(objImage.FrameDimensionsList[0]);
            System.IO.MemoryStream objMemoryStream = new System.IO.MemoryStream();

            objImage.SelectActiveFrame(objDimension, FrameIndex);
            objImage.Save(objMemoryStream, System.Drawing.Imaging.ImageFormat.Png);
            functionReturnValue = System.Drawing.Image.FromStream(objMemoryStream);

            objImage.Dispose();
            return functionReturnValue;

        }

        #endregion

        #region "XML Functions"

        public string XMLClean(string XML)
        {
            //Dim objXMLTools As New XMLTools
            //Return objXMLTools.CleanXML(XML)
            MessageBox.Show("XBMCClean Function not Written");
            return "FAKE";
        }

        public bool XMLValidate(string XML)
        {
            return false;
        }

        public string XMLMergeIncludes(string IncludeXML, string XML)
        {
            return "FAKE";
        }

        public string XMLMergeReferences(string ReferencesXML, string XML)
        {
            return "FAKE";
        }

        #endregion

        #region "Settings Functions"
        
        public void LoadSettings()
        {
           //objSettings.Load(AppPath() + "Settings.xml");
        }

        public void SaveSettings()
        {
            //objSettings.Save(AppPath() + "Settings.xml");
        }

        public string GetSetting(string SettingName)
        {
            //return objSettings.GetSetting(SettingName);
            return "";
        }

        public void SetSetting(string SettingName, string Value)
        {
            //objSettings.SetSetting(SettingName, Value);
        }

        public string GetPluginSetting(string PluginName, string SettingName)
        {
            //return objSettings.GetPluginSetting(PluginName, SettingName);
            return "";
        }

        public void SetPluginSetting(string PluginName, string SettingName, string Value)
        {
            //objSettings.SetPluginSetting(PluginName, SettingName, Value);
        }
        #endregion

    }
}
