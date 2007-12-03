using System.Xml;

namespace XBMCSkinEditor.Classes
{
    public static class XMLHelper
    {
        public static void AddElementWithText(XmlDocument doc, XmlElement e, string elementName, string elementValue) {
            XmlElement xe = doc.CreateElement("", elementName, "");
            xe.AppendChild(doc.CreateTextNode(elementValue));
            e.AppendChild(xe);
        }
        public static bool SaveXmlDocumentToFile(XmlDocument doc, string filename)
        {
            try
            {
                XmlTextWriter xtw = new XmlTextWriter(filename, System.Text.Encoding.UTF8);
                xtw.IndentChar = '\t';
                xtw.Indentation = 1;
                xtw.Formatting = Formatting.Indented;
                doc.Save(xtw);
                return true;
            }
            catch (System.Exception e)
            {
                MainWin.mOutput.OutputText = e.StackTrace;
                return false;
            }

        }
    }
}
