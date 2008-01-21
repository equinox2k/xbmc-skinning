
namespace SkinEditor.Interfaces
{
    public class PluginDetails
    {

        string strName;
        string strDescription;
        string strAuthor;
        int intVersionMajor;
        int intVersionMinor;
        bool bolhasSettings;

        public PluginDetails(string Name, string Description, string Author, int VersionMajor, int VersionMinor, bool HasSettings)
        {
            strName = Name;
            strDescription = Description;
            strAuthor = Author;
            intVersionMajor = VersionMajor;
            intVersionMinor = VersionMinor;
            bolhasSettings = HasSettings;
        }

        public string Name
        {
            get { return strName; }
        }

        public string Description
        {
            get { return strDescription; }
        }

        public string Author
        {
            get { return strAuthor; }
        }

        public int VersionMajor
        {
            get { return intVersionMajor; }
        }

        public int VersionMinor
        {
            get { return intVersionMinor; }
        }
        public bool HasSettings
        {
            get { return bolhasSettings; }
        }
    }
}
