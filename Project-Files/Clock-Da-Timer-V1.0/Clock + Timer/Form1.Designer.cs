namespace Clock___Timer
{
    partial class Clock_Da_Timer
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
            this.Time = new System.Windows.Forms.Label();
            this.Tim = new System.Windows.Forms.Label();
            this.Sec = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.Hrss = new System.Windows.Forms.TextBox();
            this.Hrs = new System.Windows.Forms.Label();
            this.Mins = new System.Windows.Forms.Label();
            this.Secs = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Mp3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(111, 9);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(290, 75);
            this.Time.TabIndex = 0;
            this.Time.Text = "00:00:00";
            this.Time.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tim
            // 
            this.Tim.AutoSize = true;
            this.Tim.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Location = new System.Drawing.Point(145, 113);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(220, 56);
            this.Tim.TabIndex = 1;
            this.Tim.Text = "00:00:00";
            // 
            // Sec
            // 
            this.Sec.Location = new System.Drawing.Point(450, 205);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(62, 20);
            this.Sec.TabIndex = 2;
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(251, 205);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(70, 20);
            this.Min.TabIndex = 3;
            // 
            // Hrss
            // 
            this.Hrss.Location = new System.Drawing.Point(69, 205);
            this.Hrss.Name = "Hrss";
            this.Hrss.Size = new System.Drawing.Size(62, 20);
            this.Hrss.TabIndex = 4;
            // 
            // Hrs
            // 
            this.Hrs.AutoSize = true;
            this.Hrs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hrs.Location = new System.Drawing.Point(20, 208);
            this.Hrs.Name = "Hrs";
            this.Hrs.Size = new System.Drawing.Size(43, 14);
            this.Hrs.TabIndex = 5;
            this.Hrs.Text = "Hours:";
            // 
            // Mins
            // 
            this.Mins.AutoSize = true;
            this.Mins.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mins.Location = new System.Drawing.Point(190, 208);
            this.Mins.Name = "Mins";
            this.Mins.Size = new System.Drawing.Size(55, 14);
            this.Mins.TabIndex = 6;
            this.Mins.Text = "Minutes:";
            // 
            // Secs
            // 
            this.Secs.AutoSize = true;
            this.Secs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secs.Location = new System.Drawing.Point(386, 208);
            this.Secs.Name = "Secs";
            this.Secs.Size = new System.Drawing.Size(58, 14);
            this.Secs.TabIndex = 7;
            this.Secs.Text = "Seconds:";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(79, 270);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(98, 23);
            this.Start.TabIndex = 8;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(251, 270);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(92, 23);
            this.Stop.TabIndex = 9;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Mp3
            // 
            this.Mp3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mp3.Location = new System.Drawing.Point(414, 270);
            this.Mp3.Name = "Mp3";
            this.Mp3.Size = new System.Drawing.Size(89, 23);
            this.Mp3.TabIndex = 10;
            this.Mp3.Text = "Alarm Tone";
            this.Mp3.UseVisualStyleBackColor = true;
            this.Mp3.Click += new System.EventHandler(this.Mp3_Click);
            // 
            // Clock_Da_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 305);
            this.Controls.Add(this.Mp3);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Secs);
            this.Controls.Add(this.Mins);
            this.Controls.Add(this.Hrs);
            this.Controls.Add(this.Hrss);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.Time);
            this.Name = "Clock_Da_Timer";
            this.Text = "Clock-Da-Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Tim;
        private System.Windows.Forms.TextBox Sec;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Hrss;
        private System.Windows.Forms.Label Hrs;
        private System.Windows.Forms.Label Mins;
        private System.Windows.Forms.Label Secs;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Mp3;
    }
}

