using WeifenLuo.WinFormsUI.Docking;
using XBMCSkinEditor.Classes;
namespace XBMCSkinEditor
{
    public partial class MainWin : System.Windows.Forms.Form
    {

        private Host objHost = new Host();
        public static Components.FileBrowser mFileBrowser;
        public static Components.SkinBrowser mSkinBrowser;
        public static Components.OutputLog mOutput;
        public static Components.ErrorLog mErrorLog;
        public static MainWin mMainWin;
        PluginServices.AvailablePlugin[] mPlugins = null;
        //private Interface mPlugins = PluginServices.FindPlugins(objHost.AppPath, "SkinEditor.Interfaces.IPlugin")
        //Private Plugins() As PluginServices.AvailablePlugin
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
            mMainWin = this;
            /* Load Plugins */
            mPlugins = Classes.PluginServices.FindPlugins(objHost.AppPath(), "SkinEditor.Interfaces.IPlugin");

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
        private void tsmi_View_Event(object sender, System.EventArgs e)
        {
            bool ret;
            if (sender == tsmiFileBrowser)
            {
                ret = HandleViewToggle(tsmiFileBrowser, mFileBrowser, DockState.DockLeft);
            }
            else if (sender == tsmiSkinBrowser)
            {
                ret = HandleViewToggle(tsmiSkinBrowser, mSkinBrowser, DockState.DockLeft);
            }
        }
        
        private void tsmiPlugins_DropDownClick(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e) {
            if (this.mPlugins.Length > 0)
            {
                
                SkinEditor.Interfaces.IPlugin objPlugin = PluginServices.CreateInstance(mPlugins[int.Parse((string)e.ClickedItem.Tag)]);
                objPlugin.Initialize(objHost);
                objPlugin.Start();
            }
        }

        private void MainWin_Load(object sender, System.EventArgs e)
        {
            if (mPlugins != null)
            {
                int index = 0;
                foreach (PluginServices.AvailablePlugin plugin in mPlugins)
                {
                    SkinEditor.Interfaces.IPlugin objPlugin = PluginServices.CreateInstance(plugin);
                    System.Windows.Forms.ToolStripMenuItem newItem = new System.Windows.Forms.ToolStripMenuItem();

                    newItem.Name = objPlugin.PluginDetails.Name;
                    newItem.Text = objPlugin.PluginDetails.Name;
                    newItem.Tag = index.ToString();
                    this.tsmiPlugins.DropDownItems.Add(newItem);
                    index++; 
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, System.EventArgs e)
        {
            mFileBrowser.OpenSkinFolder(@"D:\TheSVN\XBMCSkinning\skins_1098\MC360\");
        }

        private void DockPanel_ActiveContentChanged(object sender, System.EventArgs e)
        {

        }

        private void MS_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, System.EventArgs e)
        {
            /*Windows.NewSkin ns = Windows.NewSkin();
            ns.Show();
            */
        }

        private void toolStripMenuItem5_Click(object sender, System.EventArgs e)
        {
            
            Components.ImageViewer skinView = new Components.ImageViewer();
            skinView.MdiParent = this;
            if (this.DockPanel.DocumentStyle == DocumentStyle.SystemMdi) {
                skinView.Show();
            } else {
                skinView.Show(this.DockPanel);
            }

        }

        public void OpenFile(string filename, string path)
        {
            string[] txtExtention = { ".TXT", ".XML", ".JS", ".PY", ".HTML", ".HTM", ".CSS", ".ASP", ".PHP" };
            string[] imageExtention = { ".PNG", ".BMP", ".TGA", ".JPG", ".GIF" };

            string fileExtension = System.IO.Path.GetExtension(filename.ToUpper());
            int i = System.Array.IndexOf<string>(txtExtention, fileExtension);
            if (i > -1)
            {
                System.Windows.Forms.MessageBox.Show("Text Doc");
                return;
            }
            i = System.Array.IndexOf<string>(imageExtention, fileExtension);
            if (i > -1)
            {
                Components.ImageViewer iv = new Components.ImageViewer();
                //iv.BackgroundImage.Load
                iv.MdiParent = this;
                iv.Text = filename;
                iv.LoadFile(filename, path);
                iv.Show(this.DockPanel, DockState.Document);
                return;
            }
        }

        internal void OpenFileInXPR(string filename, string xprpath)
        {
            string[] imageExtention = { ".PNG", ".BMP", ".TGA", ".JPG", ".GIF" };
            string fileExtension = System.IO.Path.GetExtension(filename.ToUpper());
            int i = System.Array.IndexOf<string>(imageExtention, fileExtension);
            if (i > -1)
            {
                XPRTool objXPRTool = new XPRTool();
                objXPRTool.OpenXPR(xprpath);
                objXPRTool.GetImage(filename);
                objXPRTool.CloseXPR();

            }
        }
    }
}
