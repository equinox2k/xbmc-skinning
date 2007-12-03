using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace XBMCSkinEditor.Components
{
    public partial class SkinBrowser : DockContent
    {
        public SkinBrowser()
        {
            InitializeComponent();
        }
        private void Browser_Load(object sender, EventArgs e)
        {
            /*tvBrowser.Nodes.Add("PAL");
            tvBrowser.Nodes.Add("PAL16x9");
            tvBrowser.Nodes.Add("1080i");*/
        }

    }
}
