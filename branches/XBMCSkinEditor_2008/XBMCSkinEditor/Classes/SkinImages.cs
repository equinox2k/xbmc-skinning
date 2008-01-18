using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace XBMCSkinEditor.Classes
{
    using System.Drawing.Imaging;

    public class ImageFrame
    {

        private Image frame;
        private int delay;

        public Image Frame
        {
            get { return frame; }
            set { frame = value; }
        }

        public int Delay
        {
            get { return delay; }
            set { delay = value; }
        }

    }

    public class SkinImage
    {

        public event ShowFrameEventHandler ShowFrame;
        public delegate void ShowFrameEventHandler(Image Image);

        private int _Loops;
        private System.Collections.ArrayList frames = new System.Collections.ArrayList();
        
        //private System.Timers.Timer _Timer;
        private int frame = 0;
        private int loops = 1;

        public int Loops
        {
            get { return this.loops; }
            set { this.loops = value; }
        }

        public System.Collections.ArrayList Frames
        {

            get { return this.frames; }
            set { this.frames = value; }
        }

        public void Load(string FileName)
        {
            
        byte[] bytDelays = null;
        Image objImage = Image.FromFile(FileName);
        //FrameDimension objDimension = new FrameDimension(objImage.FrameDimensionsList(0));
        
        this.frame = 0;
        _Loops = 0;
        
        foreach ( PropertyItem objPropertyItem in objImage.PropertyItems) {
            switch (objPropertyItem.Id) {
                case 20736:
                    bytDelays = objImage.GetPropertyItem(objPropertyItem.Id).Value;
                    break;
                case 20737:
                    _Loops = BitConverter.ToInt16(objImage.GetPropertyItem(objPropertyItem.Id).Value, 0);
                    break;
            }
        }
        
        this.frames.Clear();
        /*for (int intLoop = 0; intLoop <= objImage.GetFrameCount(objDimension) - 1; intLoop++) {
            
            ImageFrame objImageFrame = new ImageFrame();
            System.IO.MemoryStream objMemoryStream = new System.IO.MemoryStream();
            
            objImage.SelectActiveFrame(objDimension, intLoop);
            objImage.Save(objMemoryStream, System.Drawing.Imaging.ImageFormat.Png);
            
            if (bytDelays == null) {
                objImageFrame.Delay = 0;
            }
            else {
                objImageFrame.Delay = BitConverter.ToInt32(bytDelays, intLoop * 4) * 10;
            }
            
            objImageFrame.Frame = System.Drawing.Image.FromStream(objMemoryStream);
            _Frames.Add(objImageFrame);
            
        }*/
        
    }
        /*
        public void Animate()
        {

            if (_Frames.Count > 0)
            {

                _Loop = _Loops;
                _Frame = 0;
                _Timer = new Timer();
                _Timer.Tick += TimerTick;

                _Timer.Interval = 100;
                //_Frames.Item(0).Delay
                _Timer.Enabled = true;

            }

        }
        */
        private void TimerTick(object sender, System.EventArgs e)
        {
            if (ShowFrame != null)
            {
                //ShowFrame(this.frames[this.frame].Frame);
            }

            this.frame += 1;
            if (this.frame == this.frames.Count)
                this.frame = 0;
        }
    }


}

