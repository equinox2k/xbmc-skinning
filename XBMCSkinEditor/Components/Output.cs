using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace XBMCSkinEditor.Components
{
    public partial class Output : DockContent
    {
        public Output()
        {
            InitializeComponent();
        }

        public string OutputText
        {
            get
            {
                return this.txtOutput.Text;
            }
            set
            {
                this.txtOutput.Text = this.txtOutput.Text + value;
            }
        }

        private void Output_Load(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
