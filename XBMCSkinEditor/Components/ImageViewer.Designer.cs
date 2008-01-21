namespace XBMCSkinEditor.Components
{
    partial class ImageViewer : WeifenLuo.WinFormsUI.Docking.DockContent
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
            this.ImageViewerImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewerImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageViewerImageBox
            // 
            this.ImageViewerImageBox.BackgroundImage = global::XBMCSkinEditor.Properties.Resources.grid;
            this.ImageViewerImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageViewerImageBox.Location = new System.Drawing.Point(0, 0);
            this.ImageViewerImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.ImageViewerImageBox.Name = "ImageViewerImageBox";
            this.ImageViewerImageBox.Size = new System.Drawing.Size(712, 542);
            this.ImageViewerImageBox.TabIndex = 0;
            this.ImageViewerImageBox.TabStop = false;
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 542);
            this.Controls.Add(this.ImageViewerImageBox);
            this.Name = "ImageViewer";
            this.TabText = "ImageViewer";
            this.Text = "ImageViewer";
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewerImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageViewerImageBox;
    }
}