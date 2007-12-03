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
    public partial class ErrorLog : DockContent
    {
        public ErrorLog()
        {
            InitializeComponent();
        }

        public void AddError(string errortxt) 
        {
            this.lstErrors.Items.Add(errortxt);
        }
        public void ClearErrors(string errortxt) 
        {
            this.lstErrors.Items.Clear();
        }

        private void ErrorLog_Load(object sender, EventArgs e)
        {

        }

    }
}
