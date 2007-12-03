using WeifenLuo.WinFormsUI.Docking;
using XBMCSkinEditor.Classes;
namespace XBMCSkinEditor
{
    public partial class MainWin : System.Windows.Forms.Form
    {

        public static Components.FileBrowser mFileBrowser;
        public static Components.SkinBrowser mSkinBrowser;
        public static Components.OutputLog mOutput;
        public static Components.ErrorLog mErrorLog;

        public MainWin()
        {
            InitializeComponent();
            mFileBrowser = new Components.FileBrowser();
            mFileBrowser.Show(this.DockPanel, DockState.DockLeft);
            tsmiFileBrowser.Checked = true;
            mSkinBrowser = new Components.SkinBrowser();
            mSkinBrowser.Show(this.DockPanel, DockState.DockLeft);
            tsmiSkinBrowser.Checked = true;


            mOutput = new Components.OutputLog();
            tsmiOutput.Checked = true;
            mOutput.Show(this.DockPanel, DockState.DockBottom);
            mOutput.OutputText = "== XBMCSkinEditor Started ==";

            mErrorLog = new Components.ErrorLog();
            tsmiErrorLog.Checked = true;
            mErrorLog.Show(this.DockPanel, DockState.DockBottom);

            mSkinBrowser.Disposed += new System.EventHandler(View_Disposed);
            mFileBrowser.Disposed += new System.EventHandler(View_Disposed);
            mOutput.Disposed += new System.EventHandler(View_Disposed);

        }
        private void View_Disposed(object sender, System.EventArgs e)
        {
            if (sender == mSkinBrowser)
            {
                tsmiSkinBrowser.Checked = false;
            }
            else if (sender == mFileBrowser)
            {
                tsmiFileBrowser.Checked = false;
            }
            else if (sender == mOutput)
            {
                tsmiOutput.Checked = false;
            }
        }
        private void tsmi_about_click(object sender, System.EventArgs e)
        {

            Windows.About winAbout = new Windows.About();
            winAbout.Show();
        }

        private void tsmi_splash(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Form winSplash = new Dialogs.Splash();
            winSplash.Show();
        }
        private bool HandleViewToggle(System.Windows.Forms.ToolStripMenuItem tsmi, DockContent dp, DockState ds)
        {
            if (dp == null || dp.IsDisposed)
            {
                return false;
            }
            
            if (tsmi.Checked)
            {
                dp.Hide();
            }
            else
            {
                dp.Show(this.DockPanel, ds);
            }
            tsmi.Checked = !tsmi.Checked;
            return true;
        }
        private void tsmi_View_Event(object sender, System.EventArgs e) {
            bool ret;
            if (sender == tsmiFileBrowser)
            {
                ret = HandleViewToggle(tsmiFileBrowser, mFileBrowser, DockState.DockLeft );
            }
            else if (sender == tsmiSkinBrowser)
            {
                ret = HandleViewToggle(tsmiSkinBrowser, mSkinBrowser, DockState.DockLeft);
            }
        }

        private void MainWin_Load(object sender, System.EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, System.EventArgs e)
        {
            mFileBrowser.OpenSkinFolder(@"D:\TheSVN\XBMCSkinning\skins\MC360\");
        }

        private void DockPanel_ActiveContentChanged(object sender, System.EventArgs e)
        {

        }

        private void MS_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {

        }





    }
}
