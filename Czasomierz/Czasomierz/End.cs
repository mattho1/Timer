using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Czasomierz
{
    public partial class End : Form
    {
        System.Media.SoundPlayer soundClick = new System.Media.SoundPlayer();

        public End(bool isNewText, string newText)
        {
            InitializeComponent();
            if (isNewText)
            {
                label1.Enabled = false;
                richTextBox1.Text = newText;
            }else
            {
                richTextBox1.Visible = false;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PlaySound()
        {
            try
            {
                soundClick.SoundLocation = "alarm.wav";
                for (int i = 0; i < 5; i++)
                {
                    soundClick.Play();
                    System.Threading.Thread.Sleep(1500);
                }
            }
            catch
            {
                //wychwytywanie błędu braku pliku dzwiękowego, raczej nei zachodzi ale nie wyświetla komunikatu
            }
        }

        private void End_Load(object sender, EventArgs e)
        {
            Thread thr = new Thread(PlaySound);
            thr.Start();
        }
    }
}
