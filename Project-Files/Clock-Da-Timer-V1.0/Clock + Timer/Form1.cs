using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Diagnostics;

namespace Clock___Timer
{
    public partial class Clock_Da_Timer : Form
    {
        public String FL; WindowsMediaPlayer Th = new WindowsMediaPlayer();
        Timer T = new Timer(); Timer F = new Timer();
        public Clock_Da_Timer()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void T_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("hh:mm:ss");
            Time.Text = clock;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            T.Interval = 1000; F.Interval = 1000;
            T.Tick += new EventHandler(this.T_Tick);  F.Tick += new EventHandler(this.F_Tick);
            T.Start(); 
        }
        public void F_Tick(object sender, EventArgs e)
        {
            char [] G = Tim.Text.ToCharArray(); String h=(G[0].ToString()+G[1].ToString()),M=(G[3].ToString()+G[4].ToString()),S=(G[6].ToString()+G[7].ToString());
            Byte HS = Byte.Parse(h),MS=Byte.Parse(M),SS=byte.Parse(S);

            if (HS == 0 & MS == 0 & SS == 0)
            {
                F.Stop();  Th.URL = (FL); Th.controls.play();
            }
            if ( MS == 0 & HS == 0&HS>0)
            {
                SS = 59;
                MS -= 1;
            }
            else if (SS < 60 & SS > 0)
            {
                SS -= 1;
            }
            else SS = 0;
            if (MS == 0 && SS == 0&HS>0)
            {
                MS = 59;
                HS -= 1;
            }
            else if (MS < 60 & MS > 0 & SS == 0)
            {
                SS = 59;
                MS -= 1;
            }
            else if (MS == 0 & SS != 0)
            {
                MS = 0;
            }
              Tim.Text = string.Format("{0}:{1}:{2}", HS.ToString().PadLeft(2, '0'), MS.ToString().PadLeft(2, '0'), SS.ToString().PadLeft(2, '0'));
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string hr="0", Mn="0", Sc="0";
            if (string.IsNullOrWhiteSpace(Hrss.Text)) { hr = "00"; } else if (byte.Parse(Hrss.Text) < 10) {   hr = ("0" + Hrss.Text); }
            else  hr = Hrss.Text.ToString();
            if (string.IsNullOrWhiteSpace(Min.Text)) { Mn = "00"; }
            else if (byte.Parse(Min.Text) < 10) {    Mn = ("0" + Min.Text); }
            else Mn = Min.Text.ToString();
            if (string.IsNullOrWhiteSpace(Sec.Text)) { Sc = "00"; }
            else if (byte.Parse(Sec.Text) < 10) {   Sc = ("0" + Sec.Text); }
            else Sc = Sec.Text.ToString();
            Tim.Text = (hr + ":" + Mn + ":" + Sc);
            F.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            F.Stop(); Th.controls.stop();
        }

        public void Mp3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Z = new OpenFileDialog();
            //Z.DefaultExt = "";

            if (Z.ShowDialog() == System.Windows.Forms.DialogResult.OK && Z.FileName.Length > 0)
            {
                //Process b = new Process();
                FL = Z.FileName;
                //b.StartInfo.FileName = Z.FileName;
            }
        }
    }
}
