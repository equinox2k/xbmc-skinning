
namespace XBMCSkinEditor.Components
{
    public partial class ImageViewer //: WeifenLuo.WinFormsUI.Docking.DockContent
    {
        string fileName;
        //System.Drawing.Image

        public ImageViewer()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        }

        public void LoadFile()
        {
            this.BackgroundImage = System.Drawing.Image.FromFile(this.fileName);
        }
        public void LoadFile(string fileName)
        {
            this.fileName = fileName;
            this.BackgroundImage = System.Drawing.Image.FromFile(this.fileName);
        }

        private void ImageViewer_Load(object sender, System.EventArgs e)
        {

        }
    }
}
