using System.Xml;
namespace XBMCSkinEditor.Classes
{
    public class Skin : SkinComponent
    {
        /*
         *  Create a new Skin.xml
         */
        public Skin(string skinName, string skinVersion, string authorLine1)
        {
            /* The Following Code Creates the XmlDocument for a Skin.xml */
            XmlElement xmlelem;
            XmlElement xmlelem2;
          
            mComponentDoc = new XmlDocument();
            mComponentDoc.AppendChild(mComponentDoc.CreateNode(XmlNodeType.XmlDeclaration, "", ""));
            xmlelem = mComponentDoc.CreateElement("", "skin", "");
            mComponentDoc.AppendChild(xmlelem);
            XMLHelper.AddElementWithText(mComponentDoc, xmlelem, "defaultresolution","pal");
            XMLHelper.AddElementWithText(mComponentDoc, xmlelem,"defaultresolutionwide","pal16x9");
            XMLHelper.AddElementWithText(mComponentDoc, xmlelem, "version", skinVersion);
            XMLHelper.AddElementWithText(mComponentDoc, xmlelem, "zoom", "1");
            xmlelem2 = mComponentDoc.CreateElement("credits");
            XMLHelper.AddElementWithText(mComponentDoc, xmlelem2, "skinname", skinName);
            XMLHelper.AddElementWithText(mComponentDoc, xmlelem2, "name", authorLine1);
            xmlelem.AppendChild(xmlelem2);
            this.mIsModified = true;
            this.mIsOpen = true;
        }

        /*
         *  Load in an existing Skin.xml
         */
        public Skin(string xmlpath)
        {
            mComponentDoc = new XmlDocument();
        }

        public string SkinName {
            get {
                return this.mComponentDoc.SelectSingleNode("//skinname").InnerXml;
            }
            set {
                this.mComponentDoc.SelectSingleNode("//skinname").InnerXml = value;
            }
        }
       public string SkinVersion {
            get {
                return this.mComponentDoc.SelectSingleNode("//version").InnerXml;
            }
            set {
                this.mComponentDoc.SelectSingleNode("//version").InnerXml = value;
            }
        }

        
    }
}
