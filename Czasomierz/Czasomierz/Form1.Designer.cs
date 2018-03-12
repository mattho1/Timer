namespace Czasomierz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.buttonUpHour = new System.Windows.Forms.Button();
            this.buttonDownHour = new System.Windows.Forms.Button();
            this.buttonUpMinute = new System.Windows.Forms.Button();
            this.buttonDownMinute = new System.Windows.Forms.Button();
            this.buttonUpSecond = new System.Windows.Forms.Button();
            this.buttonDownSecond = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.buttonBackgroundWork = new System.Windows.Forms.Button();
            this.timerCalculatedTime = new System.Windows.Forms.Timer(this.components);
            this.notifyIconMonitor = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBoxText = new System.Windows.Forms.CheckBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBoxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHour
            // 
            this.textBoxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHour.Location = new System.Drawing.Point(19, 66);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(154, 143);
            this.textBoxHour.TabIndex = 0;
            this.textBoxHour.Text = "00";
            this.textBoxHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHour.TextChanged += new System.EventHandler(this.textBoxHour_TextChanged);
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMinute.Location = new System.Drawing.Point(201, 66);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(154, 143);
            this.textBoxMinute.TabIndex = 1;
            this.textBoxMinute.Text = "00";
            this.textBoxMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMinute.TextChanged += new System.EventHandler(this.textBoxMinute_TextChanged);
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSecond.Location = new System.Drawing.Point(383, 66);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(154, 143);
            this.textBoxSecond.TabIndex = 2;
            this.textBoxSecond.Text = "00";
            this.textBoxSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSecond.TextChanged += new System.EventHandler(this.textBoxSecond_TextChanged);
            // 
            // buttonUpHour
            // 
            this.buttonUpHour.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpHour.Image")));
            this.buttonUpHour.Location = new System.Drawing.Point(19, 28);
            this.buttonUpHour.Name = "buttonUpHour";
            this.buttonUpHour.Size = new System.Drawing.Size(154, 35);
            this.buttonUpHour.TabIndex = 3;
            this.buttonUpHour.UseVisualStyleBackColor = true;
            this.buttonUpHour.Click += new System.EventHandler(this.buttonUpHour_Click);
            // 
            // buttonDownHour
            // 
            this.buttonDownHour.Image = ((System.Drawing.Image)(resources.GetObject("buttonDownHour.Image")));
            this.buttonDownHour.Location = new System.Drawing.Point(19, 215);
            this.buttonDownHour.Name = "buttonDownHour";
            this.buttonDownHour.Size = new System.Drawing.Size(154, 35);
            this.buttonDownHour.TabIndex = 4;
            this.buttonDownHour.UseVisualStyleBackColor = true;
            this.buttonDownHour.Click += new System.EventHandler(this.buttonDownHour_Click);
            // 
            // buttonUpMinute
            // 
            this.buttonUpMinute.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpMinute.Image")));
            this.buttonUpMinute.Location = new System.Drawing.Point(201, 28);
            this.buttonUpMinute.Name = "buttonUpMinute";
            this.buttonUpMinute.Size = new System.Drawing.Size(154, 35);
            this.buttonUpMinute.TabIndex = 5;
            this.buttonUpMinute.UseVisualStyleBackColor = true;
            this.buttonUpMinute.Click += new System.EventHandler(this.buttonUpMinute_Click);
            // 
            // buttonDownMinute
            // 
            this.buttonDownMinute.Image = ((System.Drawing.Image)(resources.GetObject("buttonDownMinute.Image")));
            this.buttonDownMinute.Location = new System.Drawing.Point(201, 215);
            this.buttonDownMinute.Name = "buttonDownMinute";
            this.buttonDownMinute.Size = new System.Drawing.Size(154, 35);
            this.buttonDownMinute.TabIndex = 6;
            this.buttonDownMinute.UseVisualStyleBackColor = true;
            this.buttonDownMinute.Click += new System.EventHandler(this.buttonDownMinute_Click);
            // 
            // buttonUpSecond
            // 
            this.buttonUpSecond.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpSecond.Image")));
            this.buttonUpSecond.Location = new System.Drawing.Point(383, 28);
            this.buttonUpSecond.Name = "buttonUpSecond";
            this.buttonUpSecond.Size = new System.Drawing.Size(154, 35);
            this.buttonUpSecond.TabIndex = 7;
            this.buttonUpSecond.UseVisualStyleBackColor = true;
            this.buttonUpSecond.Click += new System.EventHandler(this.buttonUpSecond_Click);
            // 
            // buttonDownSecond
            // 
            this.buttonDownSecond.Image = ((System.Drawing.Image)(resources.GetObject("buttonDownSecond.Image")));
            this.buttonDownSecond.Location = new System.Drawing.Point(383, 215);
            this.buttonDownSecond.Name = "buttonDownSecond";
            this.buttonDownSecond.Size = new System.Drawing.Size(154, 35);
            this.buttonDownSecond.TabIndex = 8;
            this.buttonDownSecond.UseVisualStyleBackColor = true;
            this.buttonDownSecond.Click += new System.EventHandler(this.buttonDownSecond_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(31, 358);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 58);
            this.button7.TabIndex = 9;
            this.button7.Text = "START";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(395, 358);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 58);
            this.button8.TabIndex = 10;
            this.button8.Text = "STOP";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(213, 358);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 58);
            this.button9.TabIndex = 11;
            this.button9.Text = "PAUSE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.buttonDownSecond);
            this.groupBoxTime.Controls.Add(this.buttonUpSecond);
            this.groupBoxTime.Controls.Add(this.buttonDownMinute);
            this.groupBoxTime.Controls.Add(this.buttonUpMinute);
            this.groupBoxTime.Controls.Add(this.buttonDownHour);
            this.groupBoxTime.Controls.Add(this.buttonUpHour);
            this.groupBoxTime.Controls.Add(this.textBoxSecond);
            this.groupBoxTime.Controls.Add(this.textBoxMinute);
            this.groupBoxTime.Controls.Add(this.textBoxHour);
            this.groupBoxTime.Location = new System.Drawing.Point(12, 63);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(559, 264);
            this.groupBoxTime.TabIndex = 12;
            this.groupBoxTime.TabStop = false;
            // 
            // buttonBackgroundWork
            // 
            this.buttonBackgroundWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackgroundWork.Location = new System.Drawing.Point(395, 12);
            this.buttonBackgroundWork.Name = "buttonBackgroundWork";
            this.buttonBackgroundWork.Size = new System.Drawing.Size(154, 33);
            this.buttonBackgroundWork.TabIndex = 13;
            this.buttonBackgroundWork.Text = "HIDE";
            this.buttonBackgroundWork.UseVisualStyleBackColor = true;
            this.buttonBackgroundWork.Click += new System.EventHandler(this.buttonBackgroundWork_Click);
            // 
            // timerCalculatedTime
            // 
            this.timerCalculatedTime.Interval = 1000;
            this.timerCalculatedTime.Tick += new System.EventHandler(this.timerCalculatedTime_Tick);
            // 
            // notifyIconMonitor
            // 
            this.notifyIconMonitor.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMonitor.Icon")));
            this.notifyIconMonitor.Text = "notifyIcon1";
            this.notifyIconMonitor.Visible = true;
            this.notifyIconMonitor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMonitor_MouseDoubleClick);
            // 
            // checkBoxText
            // 
            this.checkBoxText.AutoSize = true;
            this.checkBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxText.Location = new System.Drawing.Point(31, 437);
            this.checkBoxText.Name = "checkBoxText";
            this.checkBoxText.Size = new System.Drawing.Size(177, 24);
            this.checkBoxText.TabIndex = 14;
            this.checkBoxText.Text = "Tekst komunikatu";
            this.checkBoxText.UseVisualStyleBackColor = true;
            this.checkBoxText.CheckedChanged += new System.EventHandler(this.checkBoxText_CheckedChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox.Location = new System.Drawing.Point(31, 467);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(517, 67);
            this.richTextBox.TabIndex = 15;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 562);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.checkBoxText);
            this.Controls.Add(this.buttonBackgroundWork);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Czasomierz";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.Button buttonUpHour;
        private System.Windows.Forms.Button buttonDownHour;
        private System.Windows.Forms.Button buttonUpMinute;
        private System.Windows.Forms.Button buttonDownMinute;
        private System.Windows.Forms.Button buttonUpSecond;
        private System.Windows.Forms.Button buttonDownSecond;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.Button buttonBackgroundWork;
        private System.Windows.Forms.Timer timerCalculatedTime;
        private System.Windows.Forms.NotifyIcon notifyIconMonitor;
        private System.Windows.Forms.CheckBox checkBoxText;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

