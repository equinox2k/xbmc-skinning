using System.Drawing;
using System.Windows.Forms;

namespace SkinEditor.Interfaces
{

    public interface IHost
    {
        void ShowDockContent(WeifenLuo.WinFormsUI.Docking.DockContent Form, WeifenLuo.WinFormsUI.Docking.DockState DDockStyle);
        void ShowMessage(string Message);
        DialogResult ShowDialog(Form Form);
        void ShowForm(Form Form, string DockLocation);
        void ErrorOccured(int ErrorLevel, string Message, string File, int Line, int Pos);
        object[] ExecuteCommand(string Command, object[] Parameters);

        int GetXPRImageCount(string FileName);
        string GetXPRImageName(string FileName, int ImageIndex);
        int GetXPRImageLoops(string FileName, int ImageIndex);
        int GetXPRImageFrameCount(string FileName, int ImageIndex);
        int GetXPRImageFrameDelay(string FileName, int ImageIndex, int FrameIndex);
        Image GetXPRImageFrame(string FileName, int ImageIndex, int FrameIndex);

        int GetGIFImageLoops(string FileName);
        int GetGIFImageFrameCount(string FileName);
        int GetGIFImageFrameDelay(string FileName, int FrameIndex);
        Image GetGIFImageFrame(string FileName, int FrameIndex);

        void SaveXPRImage(string FileName, int ImageIndex, string DestFileName);
        void SaveXPRImageFrame(string FileName, int ImageIndex, int FrameIndex, string DestFileName);

        string XMLClean(string XML);
        bool XMLValidate(string XML);
        string XMLMergeIncludes(string IncludeXML, string XML);
        string XMLMergeReferences(string ReferencesXML, string XML);

        void LoadSettings();
        void SaveSettings();
        string GetSetting(string SettingName);
        void SetSetting(string SettingName, string Value);
        string GetPluginSetting(string PluginName, string SettingName);
        void SetPluginSetting(string PluginName, string SettingName, string Value);
    }
}
