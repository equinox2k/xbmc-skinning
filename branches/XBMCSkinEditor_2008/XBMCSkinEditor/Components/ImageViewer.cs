
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
            this.Text = fileName;
            this.ImageViewerImageBox.Image = System.Drawing.Image.FromFile(this.fileName);
        }
        public void LoadFile(string fileName, string path)
        {
            this.Text = fileName;
            this.fileName = fileName;
            this.ImageViewerImageBox.Image = System.Drawing.Image.FromFile(path);
        }
    }
}
