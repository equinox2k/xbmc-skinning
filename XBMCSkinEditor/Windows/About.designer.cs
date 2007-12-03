namespace XBMCSkinEditor.Windows
{
    partial class About
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
            this.stp = new XBMCSkinEditor.Components.ScrollingTextPanel();
            this.SuspendLayout();
            // 
            // stp
            // 
            this.stp.BackColor = System.Drawing.Color.Transparent;
            this.stp.ForeColor = System.Drawing.Color.White;
            this.stp.Interval = 50;
            this.stp.Location = new System.Drawing.Point(12, 12);
            this.stp.Message = "\"--------------------------------- XBMC Skin Editor was created and designed by E" +
                "qUiNox and Donno... GFX by Blackbolt...";
            this.stp.Name = "stp";
            this.stp.ScrollSpeed = 2;
            this.stp.Size = new System.Drawing.Size(300, 52);
            this.stp.Started = true;
            this.stp.TabIndex = 0;
            this.stp.Paint += new System.Windows.Forms.PaintEventHandler(this.stp_Paint);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(314, 72);
            this.Controls.Add(this.stp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.DoubleClick += new System.EventHandler(this.About_DClick);
            this.ResumeLayout(false);

        }

        #endregion
        internal XBMCSkinEditor.Components.ScrollingTextPanel stp;
    }
}