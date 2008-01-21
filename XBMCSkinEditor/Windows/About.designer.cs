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
            this.stp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stp.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stp.ForeColor = System.Drawing.Color.White;
            this.stp.Interval = 50;
            this.stp.Location = new System.Drawing.Point(10, 10);
            this.stp.Margin = new System.Windows.Forms.Padding(10);
            this.stp.Message = "\"--------------------------------- XBMC Skin Editor was created and designed by EqUiNox" +
                " and Donno... GFX by Blackbolt...";
            this.stp.Name = "stp";
            this.stp.Padding = new System.Windows.Forms.Padding(10);
            this.stp.ScrollSpeed = 2;
            this.stp.Size = new System.Drawing.Size(342, 51);
            this.stp.Started = true;
            this.stp.TabIndex = 0;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(362, 71);
            this.Controls.Add(this.stp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal XBMCSkinEditor.Components.ScrollingTextPanel stp;
    }
}