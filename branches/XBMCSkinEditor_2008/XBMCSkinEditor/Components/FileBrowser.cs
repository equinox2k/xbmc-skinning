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
            otn.Text = "Skin";
            otn.ImageKey = "skin";
            otn.SelectedImageKey = "skin";
            otn.ImageIndex = 0;
            otn.SelectedImageIndex = 0;
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
                objTN.ImageIndex = 1;
                objTN.SelectedImageIndex = 1;
                parentNode.Nodes.Add(objTN);
                RecurseTree(dir, objTN);
            }


            string[] strFiles = System.IO.Directory.GetFiles(folder);
            foreach (string file in strFiles)
            {
                FileInfo fi = new FileInfo();
                TreeNode objTN = new TreeNode();
                string filename = System.IO.Path.GetFileName(file);
                if (System.IO.Path.GetExtension(file).ToLower() == ".xpr") {
                    try
                    {
                        XPRTool objXPRTool = new XPRTool();
                        objXPRTool.OpenXPR(file);
                        fi.path = file;
                        fi.name = filename;

                        fi.displayName = filename;
                        fi.filetype = FileType.XPRContainer;
                        fi.xpi.isProtected = objXPRTool.ProtectionEnabled;
                        //fi.xpi.xprFile = fi.
                        objTN.Text = fi.displayName;
                        objTN.Tag = fi;
                        objTN.ImageIndex = 2;
                        objTN.SelectedImageIndex = 2;
                        //fi.name 
                        foreach (XPRFileInfo xfi in objXPRTool.XPRFileInfoList)
                        {
                            FileInfo fixpr = new FileInfo();
                            fixpr.xpi.isProtected = objXPRTool.ProtectionEnabled;
                            fixpr.xpi.xprFile = xfi.Name;

                            TreeNode objTNxpr = new TreeNode();
                            objTNxpr.Text = xfi.Name;
                            objTNxpr.Tag = fixpr;
                            string ext = System.IO.Path.GetExtension(xfi.Name).ToLower();
                            if (ext == ".png" || ext == ".jpg" || ext == ".bmp")
                            {
                                objTNxpr.ImageIndex = 3;
                                objTNxpr.SelectedImageIndex = 3;
                            }
                            else
                            {
                                objTNxpr.ImageIndex = 2;
                                objTNxpr.SelectedImageIndex = 2;
                            }

                            objTN.Nodes.Add(objTNxpr);
                        }
                        parentNode.Nodes.Add(objTN);
                        objXPRTool.CloseXPR();
                    }
                    catch (Exception ex)
                    {
                        /*if (ex.GetBaseException() == NotImplementedException)
                        {*/
                            //MainWin.mOutput.OutputText = ("Unimplemented: Browsing XPR: " + System.IO.Path.GetFileName(file));
                            MainWin.mOutput.OutputText = (ex.Message + "at " + ex.Source);
                            //MainWin.mOutput.OutputText = (ex.StackTrace);
                        //}
                    }
                } else {
                    fi.path = file;
                    fi.name = filename;

                    fi.displayName = filename;
                    fi.filetype = FileType.File;

                    objTN.Text = fi.displayName;
                    objTN.Tag = fi;
                    objTN.ImageIndex = 2;
                    objTN.SelectedImageIndex = 2;

                    parentNode.Nodes.Add(objTN);
                }
            }


            return true;
        }


 
    }
}
