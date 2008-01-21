namespace XBMCSkinEditor.Components
{
    partial class FileBrowser 
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
            this.cmImage = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.cmText = new System.Windows.Forms.ContextMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.CMS_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvBrowser
            // 
            this.tvBrowser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBrowser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvBrowser.ImageIndex = 2;
            this.tvBrowser.ImageList = this.ilBrowser;
            this.tvBrowser.Location = new System.Drawing.Point(0, 0);
            this.tvBrowser.Name = "tvBrowser";
            this.tvBrowser.SelectedImageIndex = 0;
            this.tvBrowser.Size = new System.Drawing.Size(292, 266);
            this.tvBrowser.StateImageList = this.ilBrowser;
            this.tvBrowser.TabIndex = 2;
            this.tvBrowser.Click += new System.EventHandler(this.tvBrowser_Click);
            this.tvBrowser.DoubleClick += new System.EventHandler(this.tvBrowser_DoubleClick);
            // 
            // ilBrowser
            // 
            this.ilBrowser.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBrowser.ImageStream")));
            this.ilBrowser.TransparentColor = System.Drawing.Color.Transparent;
            this.ilBrowser.Images.SetKeyName(0, "");
            this.ilBrowser.Images.SetKeyName(1, "");
            this.ilBrowser.Images.SetKeyName(2, "");
            this.ilBrowser.Images.SetKeyName(3, "");
            
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
            // cmImage
            // 
            this.cmImage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Open Image";
            this.menuItem1.Click += new System.EventHandler(this.miOpenImage_MouseUp);
            // 
            // cmText
            // 
            this.cmText.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
            //this.cmText.Popup += new System.EventHandler(this.cmText_Popup);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Edit";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Open in Notepad";
            // 
            // FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.tvBrowser);
            this.Name = "FileBrowser";
            this.ShowIcon = false;
            this.TabText = "File Browser";
            this.Text = "File Browser";
            this.Load += new System.EventHandler(this.FileBrowser_Load);
            this.CMS_Image.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TreeView tvBrowser;
        internal System.Windows.Forms.ImageList ilBrowser;
        internal System.Windows.Forms.ContextMenuStrip CMS_Image;
        internal System.Windows.Forms.ToolStripMenuItem OpenImageToolStripMenuItem;
        private System.Windows.Forms.ContextMenu cmImage;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.ContextMenu cmText;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
    }
}