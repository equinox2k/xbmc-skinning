namespace XBMCSkinEditor.Components
{
    partial class SkinBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileBrowser));
            this.tvBrowser = new System.Windows.Forms.TreeView();
            this.ilBrowser = new System.Windows.Forms.ImageList(this.components);
            this.CMS_Image = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Text = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiOpenWith = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Image.SuspendLayout();
            this.CMS_Text.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvBrowser
            // 
            this.tvBrowser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBrowser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvBrowser.Location = new System.Drawing.Point(0, 0);
            this.tvBrowser.Name = "tvBrowser";
            this.tvBrowser.Size = new System.Drawing.Size(292, 266);
            this.tvBrowser.TabIndex = 2;
            this.tvBrowser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBrowser_AfterSelect);
            // 
            // ilBrowser
            // 
            this.ilBrowser.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBrowser.ImageStream")));
            this.ilBrowser.TransparentColor = System.Drawing.Color.Transparent;
            this.ilBrowser.Images.SetKeyName(0, "folder");
            this.ilBrowser.Images.SetKeyName(1, "file");
            this.ilBrowser.Images.SetKeyName(2, "image");
            this.ilBrowser.Images.SetKeyName(3, "skin");
            // 
            // CMS_Image
            // 
            this.CMS_Image.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImageToolStripMenuItem});
            this.CMS_Image.Name = "CMS_Image";
            this.CMS_Image.Size = new System.Drawing.Size(145, 26);
            this.CMS_Image.Text = "Img";
            // 
            // OpenImageToolStripMenuItem
            // 
            this.OpenImageToolStripMenuItem.Name = "OpenImageToolStripMenuItem";
            this.OpenImageToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.OpenImageToolStripMenuItem.Text = "Open Image";
            // 
            // CMS_Text
            // 
            this.CMS_Text.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiEdit,
            this.tmsiOpenWith});
            this.CMS_Text.Name = "CMS_Image";
            this.CMS_Text.Size = new System.Drawing.Size(179, 48);
            this.CMS_Text.Text = "txt";
            // 
            // tmsiEdit
            // 
            this.tmsiEdit.Name = "tmsiEdit";
            this.tmsiEdit.Size = new System.Drawing.Size(178, 22);
            this.tmsiEdit.Text = "Edit";
            // 
            // tmsiOpenWith
            // 
            this.tmsiOpenWith.Name = "tmsiOpenWith";
            this.tmsiOpenWith.Size = new System.Drawing.Size(178, 22);
            this.tmsiOpenWith.Text = "Open with Notepad";
            // 
            // SkinBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.tvBrowser);
            this.Name = "SkinBrowser";
            this.TabText = "Skin Browser";
            this.Text = "Skin Browser";
            this.Load += new System.EventHandler(this.Browser_Load);
            //this.FormClosed += new System.Windows.Forms.FormClosingEventHandler(this.Browser_Quit);
            this.CMS_Image.ResumeLayout(false);
            this.CMS_Text.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TreeView tvBrowser;
        internal System.Windows.Forms.ImageList ilBrowser;
        internal System.Windows.Forms.ContextMenuStrip CMS_Image;
        internal System.Windows.Forms.ToolStripMenuItem OpenImageToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip CMS_Text;
        internal System.Windows.Forms.ToolStripMenuItem tmsiEdit;
        internal System.Windows.Forms.ToolStripMenuItem tmsiOpenWith;
    }
}