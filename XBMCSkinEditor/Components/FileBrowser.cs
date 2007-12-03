using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XBMCSkinEditor.Classes;
using WeifenLuo.WinFormsUI.Docking;
namespace XBMCSkinEditor.Components
{
    public partial class FileBrowser : DockContent
    {
        public FileBrowser()
        {
            InitializeComponent();
        }

        private void FileBrowser_Load(object sender, EventArgs e)
        {
            
        }
        public bool OpenSkinFolder(string SkinPath)  {
            tvBrowser.Nodes.Clear();
            TreeNode otn = new TreeNode();
            otn.Text = "SkinName";
            otn.ImageKey = "skin";
            otn.SelectedImageKey = "skin";
            tvBrowser.Nodes.Add(otn);
            RecurseTree(SkinPath, otn);

            return true;
        }
        public bool RecurseTree(string folder, TreeNode parentNode)
        {
            string[] strDirectories = System.IO.Directory.GetDirectories(folder);
            
            foreach (string dir in  strDirectories) {
                string filename = System.IO.Path.GetFileName(dir);
                FileInfo fi = new FileInfo();
                TreeNode objTN = new TreeNode();

                fi.path = dir;
                fi.name = filename;
                fi.displayName = filename;
                fi.filetype = FileType.Directory;
                
                objTN.Text = fi.displayName;
                objTN.Tag = fi;

                parentNode.Nodes.Add(objTN);
                RecurseTree(dir, objTN);
            }


            string[] strFiles = System.IO.Directory.GetFiles(folder);
            foreach (string file in strFiles)
            {
                if (System.IO.Path.GetExtension(file).ToLower() == ".xpr") {
                    MainWin.mOutput.OutputText = ("Unimplemented: Browsing XPR: " + System.IO.Path.GetFileName(file));
                } else {
                    FileInfo fi = new FileInfo();
                    TreeNode objTN = new TreeNode();
                    string filename = System.IO.Path.GetFileName(file);
                    fi.path = file;
                    fi.name = filename;

                    fi.displayName = filename;
                    fi.filetype = FileType.File;

                    objTN.Text = fi.displayName;
                    objTN.Tag = fi;

                    parentNode.Nodes.Add(objTN);
                }
            }


            return true;
        }


    
        private void tvBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
