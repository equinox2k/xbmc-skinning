
using System.Xml;
using System;
namespace XBMCSkinEditor.Classes
{
    public class SkinComponent
    {
        protected string mFileName;
        protected XmlDocument mComponentDoc;
        protected bool mIsOpen;
        protected bool mIsModified;


        public bool Read()
        {
            XmlTextReader txtReader = new XmlTextReader(this.mFileName);
            //mComponentDoc = new XmlDocument(
            return true;
        }

        /*
         * Save the Component Document (mComponentDoc) to a file at path (mFileName).
         *  IsModified (mIsModified) is set to false. Since it was just saved, no modifcates to mComponentDoc are present.
         */
        public bool Save()
        {
            try  {

                XmlTextWriter xtw = new XmlTextWriter(this.mFileName, System.Text.Encoding.UTF8);
                xtw.IndentChar = '\t';
                xtw.Indentation = 1;
                xtw.Formatting = Formatting.Indented;
                this.mComponentDoc.Save(xtw);
                this.mIsModified = false;
                return true;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
            
         }
       public string Filename
        {
            get {
                return this.mFileName;
            } set {
                this.mFileName = value;
            }
        }
        public bool IsOpen
        {
            get {
                return mIsOpen;
            }
        }
        public bool IsModified
        {
            get
            {
                return mIsModified;
            }
        }

    }
}
