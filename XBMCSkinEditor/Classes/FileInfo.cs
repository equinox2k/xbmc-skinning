
namespace XBMCSkinEditor.Classes
{
    public enum FileType {
        File = 0, Directory, XPR, XPRContainer
    };

    public struct XPRInfo {
        public bool isProtected;
        public string xprFile;
    }
    public struct FileInfo
    {
        public string name;
        public string path;
        public string displayName;
        public FileType filetype;
        public XPRInfo xpi;
    }
}