using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Czasomierz
{
    public partial class Form1 : Form
    {
        int hour, minute, second;
        bool pause, startTimer, isNewText;
        public Form1()
        {
            startTimer = false;
            pause = false;
            isNewText = false;
            InitializeComponent();
            richTextBox.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void InitializationTimer()
        {
            hour = 0;
            minute = 0;
            second = 0;
            ModifyTime();
        }
        private void ModifyTime()
        {
            ModifyHour();
            ModifyMinute();
            ModifySecond();
        }
        private void ModifyHour()
        {
            if(hour < 10)
            {
                textBoxHour.Text = "0" + hour;
            }else
            {
                textBoxHour.Text = hour.ToString();
            }
        }
        private void ModifyMinute()
        {
            if (minute < 10)
            {
                textBoxMinute.Text = "0" + minute;
            }
            else
            {
                textBoxMinute.Text = minute.ToString();
            }
        }
        private void ModifySecond()
        {
            if (second < 10)
            {
                textBoxSecond.Text = "0" + second;
            }
            else
            {
                textBoxSecond.Text = second.ToString();
            }
        }
        private void timerCalculatedTime_Tick(object sender, EventArgs e)
        {
            int time = hour * 60 * 60 + minute * 60 + second;
            --time;
            if(time <= 0)
            {
                CalculateTime(time);
                ModifyTime();
                ShowWindow();
                groupBoxTime.Enabled = true;
                startTimer = false;
                timerCalculatedTime.Stop();
                OpenEndWIndow();
            }
            else
            {
                CalculateTime(time);
                ModifyTime();
            }
        }
        private void CalculateTime(int time)
        {
            hour = time / (60 * 60);
            minute = (time - hour * 60 * 60) / 60;
            second = time % 60;
        }

        private void notifyIconMonitor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }
        private void ShowWindow()
        {
            Show();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            notifyIconMonitor.Visible = false;
        }
        private void buttonBackgroundWork_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIconMonitor.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timerCalculatedTime.Stop();
            startTimer = false;
            InitializationTimer();
            groupBoxTime.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (startTimer)
            {
                if (!pause)
                {
                    timerCalculatedTime.Stop();
                    button9.Text = "RESUME";
                }
                else
                {
                    timerCalculatedTime.Start();
                    button9.Text = "PAUSE";
                }
                pause = !pause;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (hour != 0 || minute != 0 || second != 0) { 
                 timerCalculatedTime.Start();
                 startTimer = true;
                 groupBoxTime.Enabled = false;
            }
        }

        private void buttonDownHour_Click(object sender, EventArgs e)
        {
            hour--;
            if (hour < 0)
            {
                hour = 23;
            }
            ModifyHour();
        }

        private void buttonDownMinute_Click(object sender, EventArgs e)
        {
            minute--;
            if (minute < 0)
            {
                minute = 59;
            }
            ModifyMinute();
        }

        private void buttonDownSecond_Click(object sender, EventArgs e)
        {
            second--;
            if (second < 0)
            {
                second = 59;
            }
            ModifySecond();
        }

        private void buttonUpMinute_Click(object sender, EventArgs e)
        {
            minute++;
            if (minute > 59)
            {
                minute = 0;
            }
            ModifyMinute();
        }

        private void textBoxHour_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!textBoxHour.Text.Equals(""))
                {
                    int newHour = Int32.Parse(textBoxHour.Text);
                    if (newHour < 24 && newHour >= 0)
                    {
                        hour = newHour;
                    }
                    else
                    {
                        hour = 0;
                        ModifyHour();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawne dane.");
                ModifyHour();
            }
        }

        private void textBoxMinute_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!textBoxMinute.Text.Equals(""))
                {
                    int newMinute = Int32.Parse(textBoxMinute.Text);
                    if (newMinute < 60 && newMinute >= 0)
                    {
                        minute = newMinute;
                    }
                    else
                    {
                        minute = 0;
                        ModifyMinute();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawne dane.");
                ModifyMinute();
            }
        }

        private void textBoxSecond_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!textBoxSecond.Text.Equals(""))
                {
                    int newSecond = Int32.Parse(textBoxSecond.Text);
                    if(newSecond < 60 && newSecond >= 0)
                    {
                        second = newSecond;
                    }else
                    {
                        second = 0;
                        ModifySecond();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawne dane.");
                ModifySecond();
            }
        }

        private void checkBoxText_CheckedChanged(object sender, EventArgs e)
        {
            isNewText = !isNewText;
            if (isNewText)
            {
                richTextBox.Enabled = true;
            }else
            {
                richTextBox.Enabled = false;
            }
        }

        private void buttonUpSecond_Click(object sender, EventArgs e)
        {
            second++;
            if (second > 59)
            {
                second = 0;
            }
            ModifySecond();
        }

        private void buttonUpHour_Click(object sender, EventArgs e)
        {
            hour++;
            if(hour > 23)
            {
                hour = 0;
            }
            ModifyHour();
        }

        private void OpenEndWIndow()
        {
            End endWindow = new End(isNewText, richTextBox.Text);
            endWindow.ShowDialog();
        }
    }
}
