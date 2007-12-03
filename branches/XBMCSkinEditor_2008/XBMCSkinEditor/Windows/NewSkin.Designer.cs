namespace XBMCSkinEditor.Windows
{
    partial class NewSkin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDWR = new System.Windows.Forms.ComboBox();
            this.cboDR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVersion = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtZoom = new System.Windows.Forms.TextBox();
            this.txtSkinName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreateSkin = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboDWR);
            this.groupBox1.Controls.Add(this.cboDR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboVersion);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.txtZoom);
            this.groupBox1.Controls.Add(this.txtSkinName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 180);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skin Infomation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Zoom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Default Wide Resolution";
            // 
            // cboDWR
            // 
            this.cboDWR.FormattingEnabled = true;
            this.cboDWR.Items.AddRange(new object[] {
            "PAL",
            "PAL16x9",
            "NTSC",
            "NTSC16x9",
            "480p",
            "720p",
            "1080i"});
            this.cboDWR.Location = new System.Drawing.Point(159, 126);
            this.cboDWR.Name = "cboDWR";
            this.cboDWR.Size = new System.Drawing.Size(137, 21);
            this.cboDWR.TabIndex = 17;
            this.cboDWR.Text = "PAL16x9";
            // 
            // cboDR
            // 
            this.cboDR.FormattingEnabled = true;
            this.cboDR.Items.AddRange(new object[] {
            "PAL",
            "PAL16x9",
            "NTSC",
            "NTSC16x9",
            "480p",
            "720p",
            "1080i"});
            this.cboDR.Location = new System.Drawing.Point(158, 99);
            this.cboDR.Name = "cboDR";
            this.cboDR.Size = new System.Drawing.Size(137, 21);
            this.cboDR.TabIndex = 16;
            this.cboDR.Text = "PAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Default Resolution";
            // 
            // cboVersion
            // 
            this.cboVersion.FormattingEnabled = true;
            this.cboVersion.Items.AddRange(new object[] {
            "2.1",
            "2.0"});
            this.cboVersion.Location = new System.Drawing.Point(158, 56);
            this.cboVersion.Name = "cboVersion";
            this.cboVersion.Size = new System.Drawing.Size(137, 21);
            this.cboVersion.TabIndex = 14;
            this.cboVersion.Text = "2.1";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(20, 64);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 13);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "Version";
            // 
            // txtZoom
            // 
            this.txtZoom.Location = new System.Drawing.Point(159, 153);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(136, 20);
            this.txtZoom.TabIndex = 12;
            this.txtZoom.Text = "1";
            // 
            // txtSkinName
            // 
            this.txtSkinName.Location = new System.Drawing.Point(159, 30);
            this.txtSkinName.Name = "txtSkinName";
            this.txtSkinName.Size = new System.Drawing.Size(136, 20);
            this.txtSkinName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Skin Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 180);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resolutions";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(4, 155);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(52, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "1080i";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(6, 132);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(50, 17);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "720p";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(6, 109);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(50, 17);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "480p";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(6, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "NTSC16x9";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(6, 42);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(55, 17);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "NTSC";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(6, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "PAL16x9";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "PAL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 74);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // btnCreateSkin
            // 
            this.btnCreateSkin.Location = new System.Drawing.Point(324, 217);
            this.btnCreateSkin.Name = "btnCreateSkin";
            this.btnCreateSkin.Size = new System.Drawing.Size(78, 40);
            this.btnCreateSkin.TabIndex = 13;
            this.btnCreateSkin.Text = "Create Skin";
            this.btnCreateSkin.UseVisualStyleBackColor = true;
            this.btnCreateSkin.Click += new System.EventHandler(this.btnCreateSkin_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtName4);
            this.groupBox4.Controls.Add(this.txtName2);
            this.groupBox4.Controls.Add(this.txtName3);
            this.groupBox4.Controls.Add(this.txtName1);
            this.groupBox4.Location = new System.Drawing.Point(12, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 83);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Credits";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(6, 19);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(200, 20);
            this.txtName1.TabIndex = 12;
            this.txtName1.Text = "1";
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(6, 45);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(200, 20);
            this.txtName3.TabIndex = 13;
            this.txtName3.Text = "3";
            // 
            // txtName4
            // 
            this.txtName4.Location = new System.Drawing.Point(217, 45);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(200, 20);
            this.txtName4.TabIndex = 15;
            this.txtName4.Text = "4";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(217, 19);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(200, 20);
            this.txtName2.TabIndex = 14;
            this.txtName2.Text = "2";
            // 
            // NewSkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 373);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCreateSkin);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewSkin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Skin";
            this.Load += new System.EventHandler(this.NewSkin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDWR;
        private System.Windows.Forms.ComboBox cboDR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboVersion;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtZoom;
        private System.Windows.Forms.TextBox txtSkinName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCreateSkin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtName1;

    }
}