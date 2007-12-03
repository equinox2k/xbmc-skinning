using System;
using System.Windows.Forms;
using XBMCSkinEditor.Classes;
namespace XBMCSkinEditor.Windows
{
    public partial class NewSkin : Form
    {
        public NewSkin()
        {
            InitializeComponent();
        }

        private void NewSkin_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreateSkin_Click(object sender, EventArgs e)
        {
            Skin skin = new Skin(txtSkinName.Text, cboVersion.Text, txtName1.Text);
            //skin.Filename =  # options not implemented yet
        }
    }
}
