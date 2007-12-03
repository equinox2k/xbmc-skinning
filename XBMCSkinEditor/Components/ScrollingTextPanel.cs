using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace XBMCSkinEditor.Components
{
    public class ScrollingTextPanel : Panel
    {
        private int intScrollSpeed = 2;
        private int intSinOffset = 0;
        private int intCharWidth = 0;
        private int intPixelOffset = 0;
        private int intCharPos = 0;
        private string strMessage = "";
        private Timer timer = new Timer(); //WithEvents

        public ScrollingTextPanel() {
            this.DoubleBuffered = true;
            this.timer.Interval = 100;
            this.timer.Enabled = false;
            this.timer.Tick +=new EventHandler(Timer_Tick);
            //this.InitializeComponent();
        }
        private void Timer_Tick(object sender, EventArgs eventarg) {
            this.Invalidate();
        }
        public bool Started {
            get {
                return timer.Enabled;
            }
            set {
                this.timer.Enabled = value;
            }
        }
         public string Message {
            get {
                return this.strMessage;
            }
            set {
                this.strMessage = value;
            }
        }
            public int Interval {
            get {
                return this.timer.Interval ;
            }
            set {
                this.timer.Interval = value;
            }
        }
        public int ScrollSpeed {
            get {
                return this.intScrollSpeed;
            }
            set {
                this.intScrollSpeed = value;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (strMessage == "") { return; }
            string strChar = "";
            Graphics objGraphics = e.Graphics;
            objGraphics.PageUnit = GraphicsUnit.Pixel;
            intSinOffset += 20;
            if (intSinOffset >= 360) { 
                intSinOffset -= 360; 
            }

            if (intPixelOffset >= intCharWidth)
            {
                intCharPos += 1;
                if (intCharPos < strMessage.Length)
                {
                    strChar = strMessage.Substring(intCharPos, 1);
                }
                else
                {
                    strChar = strMessage.Substring(0, 1);
                }
                SizeF objSizeF = objGraphics.MeasureString(strChar, this.Font); 
                intPixelOffset -= intCharWidth;
                intCharWidth = (int)objSizeF.Width;       
            }
            if (intCharPos >= strMessage.Length) { intCharPos = 0; }
            int intCurChar = intCharPos;
            int intCurPosX = 0;

            do
            {

                if (intCurChar >= strMessage.Length) { intCurChar = 0; }
                strChar = strMessage.Substring(intCurChar, 1);

                SizeF objSizeF = objGraphics.MeasureString(strChar, this.Font);
                
                int intYOffset = (int)(Math.Sin(Math.PI * ((intSinOffset + (intCurPosX * 2)) / 180.0)) * ((this.Height - (objSizeF.Height * 2)) / 2));
                objGraphics.DrawString(strChar, this.Font, new SolidBrush(this.ForeColor), intCurPosX - intPixelOffset, 0 + (this.Height / 2) - (objSizeF.Height / 2) + intYOffset);
                //objGraphics.DrawString(strChar, Me.Font, New SolidBrush(Me.ForeColor), intCurPosX - intPixelOffset, 0 + (Me.Height / 2) - (objSizeF.Height / 2) + intYOffset)
                intCurPosX += (int)(objSizeF.Width);
                intCurChar += 1;

            } while (intCurPosX - intPixelOffset > this.Width);

            intPixelOffset += intScrollSpeed;
            base.OnPaint(e);
        }

     
    }
}
