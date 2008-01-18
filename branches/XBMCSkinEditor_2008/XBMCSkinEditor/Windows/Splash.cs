using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XBMCSkinEditor.Dialogs
{
    public class Splash : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label m_ver;
        private System.Windows.Forms.Label m_gfx;
        private System.Windows.Forms.Label m_dev;
        private System.Windows.Forms.Label m_dev2;
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

        public Splash()
        {
            InitializeComponent();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_ver = new System.Windows.Forms.Label();
            this.m_gfx = new System.Windows.Forms.Label();
            this.m_dev = new System.Windows.Forms.Label();
            this.m_dev2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_ver
            // 
            this.m_ver.BackColor = System.Drawing.Color.Transparent;
            this.m_ver.ForeColor = System.Drawing.Color.White;
            this.m_ver.Location = new System.Drawing.Point(276, 112);
            this.m_ver.Name = "m_ver";
            this.m_ver.Size = new System.Drawing.Size(203, 22);
            this.m_ver.TabIndex = 0;
            this.m_ver.Text = "Version: 0.0.0.0";
            this.m_ver.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_gfx
            // 
            this.m_gfx.AutoSize = true;
            this.m_gfx.BackColor = System.Drawing.Color.Transparent;
            this.m_gfx.ForeColor = System.Drawing.Color.Black;
            this.m_gfx.Location = new System.Drawing.Point(386, 282);
            this.m_gfx.Name = "m_gfx";
            this.m_gfx.Size = new System.Drawing.Size(93, 13);
            this.m_gfx.TabIndex = 2;
            this.m_gfx.Text = "GFX By: Blackbolt";
            // 
            // m_dev
            // 
            this.m_dev.AutoSize = true;
            this.m_dev.BackColor = System.Drawing.Color.Transparent;
            this.m_dev.ForeColor = System.Drawing.Color.MidnightBlue;
            this.m_dev.Location = new System.Drawing.Point(351, 308);
            this.m_dev.Name = "m_dev";
            this.m_dev.Size = new System.Drawing.Size(128, 13);
            this.m_dev.TabIndex = 1;
            this.m_dev.Text = "Developed By: |EqUiNoX|";
            // 
            // m_dev2
            // 
            this.m_dev2.AutoSize = true;
            this.m_dev2.BackColor = System.Drawing.Color.Transparent;
            this.m_dev2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.m_dev2.Location = new System.Drawing.Point(419, 333);
            this.m_dev2.Name = "m_dev2";
            this.m_dev2.Size = new System.Drawing.Size(60, 13);
            this.m_dev2.TabIndex = 3;
            this.m_dev2.Text = "and Donno";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::XBMCSkinEditor.Properties.Resources.splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(505, 405);
            this.Controls.Add(this.m_dev);
            this.Controls.Add(this.m_dev2);
            this.Controls.Add(this.m_gfx);
            this.Controls.Add(this.m_ver);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void Splash_Load(object sender, EventArgs e)
        {
            
        }
    }
}