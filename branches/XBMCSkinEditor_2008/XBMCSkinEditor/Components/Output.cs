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
    public partial class OutputLog : DockContent
    {
        public OutputLog()
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

 
    }
}
