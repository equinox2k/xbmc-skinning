using System.Xml;
using System.Xml.Serialization;
namespace XBMCSkinEditor.Classes {
    [XmlRoot("skin")]
    public class Skin :  SkinComponent {
        private static XmlSerializer serializer = new XmlSerializer(typeof(Skin));
        private bool saved;
        [XmlElement("defaultresolution")]
        public string defaultresolution;
        [XmlElement("defaultresolutionwide")]
        public string defaultresolutionwide;
        [XmlElement("version")]
        public string version;
        [XmlElement("zoom")]
        public string zoom;
        [XmlElement("credits", typeof(SkinCredits))]
        public SkinCredits credits;
        [XmlIgnore()]
        public string SkinName
        {
            get { return credits.skinname; }
            set { credits.skinname = value; }
        }
        /*
         *  Create a new Skin.xml
         */
        public Skin(string skinName, string skinVersion, string authorLine1)
        {
            this.defaultresolution = "pal";
            this.defaultresolutionwide = "pal16x9";
            this.zoom = "1";
            this.version = "2.1";
            this.credits = new SkinCredits();
            this.credits.skinname = skinName;
            this.credits.names.Add(authorLine1);
        }

        public Skin() {
            this.defaultresolution = "pal";
            this.defaultresolutionwide = "pal16x9";
            this.zoom = "1";
            this.version = "2.1";
            this.credits = new SkinCredits();
        }

        public static Skin Load(string path)
        {
            Skin skin = null;
            if (System.IO.File.Exists(path + "/skin.xml"))
            {
                using (System.IO.TextReader reader = new System.IO.StreamReader(path + "skin.xml"))
                {
                    skin = serializer.Deserialize(reader) as Skin;
                    reader.Close();
                }
            }
            return skin;
        }

        public void Save(string path) {
            if (this.saved == false)
            {
                XmlDocument document = new XmlDocument();
                using (XmlWriter xmlWriter = document.CreateNavigator().AppendChild())
                {
                    serializer.Serialize(xmlWriter, this);
                }

                using (System.IO.TextWriter writer = new System.IO.StreamWriter(path + "skin.xml"))
                {
                    /*document.PrependChild(document.CreateProcessingInstruction(
                        @"xml-stylesheet",
                        @"type='text/xsl' href='skin.xsl'"));
                     */
                    document.Save(writer);
                    writer.Close();
                }
            }
            this.saved = true;
        }

        /* 
         // For Testing purposes only 
        public static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                string path = args[0].Replace("\\", "/");
                System.Console.WriteLine("Skin.xml Generator/Loader/Saver/Test App");
                System.Console.WriteLine("Path: " + path);
                Skin skin = null;
                skin = Skin.Load(path);
                if (skin != null)
                {
                    skin.Save("");
                }
            }
            else
            {
                Skin skin = new Skin();
                skin.Save("");
            }
        }*/

    }
    [XmlType("credits")]
    public class SkinCredits {
        public string skinname;
        public SkinCredits()
        {
            this.skinname = "newskin";
        }
        [XmlElement("name")]
        public System.Collections.Generic.List<string> names;
    }
}
