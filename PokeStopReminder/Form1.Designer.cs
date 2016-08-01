namespace PokeStopReminder
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblNextAlertTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblLastAlertTime = new System.Windows.Forms.Label();
            this.lblCurrentStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(20, 59);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(157, 59);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblNextAlertTime
            // 
            this.lblNextAlertTime.AutoSize = true;
            this.lblNextAlertTime.Location = new System.Drawing.Point(100, 35);
            this.lblNextAlertTime.Name = "lblNextAlertTime";
            this.lblNextAlertTime.Size = new System.Drawing.Size(0, 13);
            this.lblNextAlertTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Alert Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Next Alert Time:";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(100, 9);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentStatus.TabIndex = 5;
            // 
            // lblLastAlertTime
            // 
            this.lblLastAlertTime.AutoSize = true;
            this.lblLastAlertTime.Location = new System.Drawing.Point(100, 22);
            this.lblLastAlertTime.Name = "lblLastAlertTime";
            this.lblLastAlertTime.Size = new System.Drawing.Size(0, 13);
            this.lblLastAlertTime.TabIndex = 6;
            // 
            // lblCurrentStatusLabel
            // 
            this.lblCurrentStatusLabel.AutoSize = true;
            this.lblCurrentStatusLabel.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentStatusLabel.Name = "lblCurrentStatusLabel";
            this.lblCurrentStatusLabel.Size = new System.Drawing.Size(77, 13);
            this.lblCurrentStatusLabel.TabIndex = 7;
            this.lblCurrentStatusLabel.Text = "Current Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Copyright 2016 Timothy George www.tgeorge.net";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentStatusLabel);
            this.Controls.Add(this.lblLastAlertTime);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNextAlertTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "PokeStop Reminder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblNextAlertTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblLastAlertTime;
        private System.Windows.Forms.Label lblCurrentStatusLabel;
        private System.Windows.Forms.Label label1;
    }
}

