/**
 * About Screen for the Skin Editor
 * Copyright (c) 2007 EqUiNox and Sean Donnellan
 * This file is Licensed under the The MIT License, see License.MIT.txt for a copy of the License
 */

using System;
using System.Windows.Forms;
using Un4seen.BassMOD;
namespace XBMCSkinEditor.Windows
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.stp.Message = "--------------------------------- XBMC Skin Editor was created and designed by EqUiNox and Donno... GFX by Blackbolt...";
            this.stp.Message = this.stp.Message + "Big thanks go to: XBMC Team for creating such a great program and giving me inspiration to create this program. ";
            this.stp.Message = this.stp.Message + "J Marshall who put up with me asking continuous questions regarding the XBMC spec. ";
            this.stp.Started = true;
            /*
            bool ret = BassMOD.BASSMOD_Init(1, 44100, BASSInit.BASS_DEVICE_DEFAULT);
            //BASS_ERROR_DEVICE
            MessageBox.Show(ret + "" + BassMOD.BASSMOD_ErrorGetCode());
            int intHand = BassMOD.BASSMOD_MusicLoad(XBMCSkinEditor.Properties.Resources.Train, 0, Properties.Resources.Train.Length, BASSMusic.BASS_MUSIC_LOOP);
            MessageBox.Show("" + intHand);
            //Un4seen.BassMOD.BASSErrorCode.BASS_ERROR_INIT 
            BassMOD.BASSMOD_MusicPlay(); //intHand, true);*/
        }
    }
}