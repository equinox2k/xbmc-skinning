namespace XBMCSkinEditor.Components
{
    partial class ErrorLog
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
            this.lstErrors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstErrors
            // 
            this.lstErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstErrors.FormattingEnabled = true;
            this.lstErrors.Location = new System.Drawing.Point(0, 0);
            this.lstErrors.Name = "lstErrors";
            this.lstErrors.Size = new System.Drawing.Size(292, 264);
            this.lstErrors.TabIndex = 0;
            // 
            // ErrorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lstErrors);
            this.Name = "ErrorLog";
            this.TabText = "Error Logs";
            this.Text = "Error Logs";
            this.Load += new System.EventHandler(this.ErrorLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstErrors;


    }
}