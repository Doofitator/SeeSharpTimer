namespace SeeSharpTimer
{
    partial class Timer
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
            this.ProjectSelector = new System.Windows.Forms.ComboBox();
            this.StartStop = new System.Windows.Forms.Button();
            this.NewProject = new System.Windows.Forms.Button();
            this.DeleteProject = new System.Windows.Forms.Button();
            this.Days = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.Minutes = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.HistoryBox = new System.Windows.Forms.TextBox();
            this.DayTimer = new System.Windows.Forms.Timer(this.components);
            this.HourTimer = new System.Windows.Forms.Timer(this.components);
            this.MinuteTimer = new System.Windows.Forms.Timer(this.components);
            this.SecondTimer = new System.Windows.Forms.Timer(this.components);
            this.ProjectTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProjectSelector
            // 
            this.ProjectSelector.FormattingEnabled = true;
            this.ProjectSelector.Location = new System.Drawing.Point(56, 40);
            this.ProjectSelector.Name = "ProjectSelector";
            this.ProjectSelector.Size = new System.Drawing.Size(121, 21);
            this.ProjectSelector.TabIndex = 0;
            // 
            // StartStop
            // 
            this.StartStop.Location = new System.Drawing.Point(81, 156);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(75, 23);
            this.StartStop.TabIndex = 1;
            this.StartStop.Text = "Start timer";
            this.StartStop.UseVisualStyleBackColor = true;
            // 
            // NewProject
            // 
            this.NewProject.Location = new System.Drawing.Point(33, 248);
            this.NewProject.Name = "NewProject";
            this.NewProject.Size = new System.Drawing.Size(75, 23);
            this.NewProject.TabIndex = 2;
            this.NewProject.Text = "NewProject";
            this.NewProject.UseVisualStyleBackColor = true;
            // 
            // DeleteProject
            // 
            this.DeleteProject.Location = new System.Drawing.Point(137, 248);
            this.DeleteProject.Name = "DeleteProject";
            this.DeleteProject.Size = new System.Drawing.Size(75, 23);
            this.DeleteProject.TabIndex = 3;
            this.DeleteProject.Text = "DeleteProject";
            this.DeleteProject.UseVisualStyleBackColor = true;
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Location = new System.Drawing.Point(30, 99);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(13, 13);
            this.Days.TabIndex = 4;
            this.Days.Text = "0";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(72, 99);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(13, 13);
            this.Hours.TabIndex = 5;
            this.Hours.Text = "0";
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Location = new System.Drawing.Point(114, 99);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(13, 13);
            this.Minutes.TabIndex = 6;
            this.Minutes.Text = "0";
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Location = new System.Drawing.Point(156, 99);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(13, 13);
            this.Seconds.TabIndex = 7;
            this.Seconds.Text = "0";
            // 
            // HistoryBox
            // 
            this.HistoryBox.Location = new System.Drawing.Point(266, 13);
            this.HistoryBox.Multiline = true;
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(192, 317);
            this.HistoryBox.TabIndex = 8;
            // 
            // DayTimer
            // 
            this.DayTimer.Interval = 60000;
            // 
            // HourTimer
            // 
            this.HourTimer.Interval = 60000;
            // 
            // MinuteTimer
            // 
            this.MinuteTimer.Interval = 60000;
            // 
            // SecondTimer
            // 
            this.SecondTimer.Interval = 1000;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 342);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.DeleteProject);
            this.Controls.Add(this.NewProject);
            this.Controls.Add(this.StartStop);
            this.Controls.Add(this.ProjectSelector);
            this.Name = "Timer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProjectSelector;
        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.Button NewProject;
        private System.Windows.Forms.Button DeleteProject;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.TextBox HistoryBox;
        private System.Windows.Forms.Timer DayTimer;
        private System.Windows.Forms.Timer HourTimer;
        private System.Windows.Forms.Timer MinuteTimer;
        private System.Windows.Forms.Timer SecondTimer;
        private System.Windows.Forms.Timer ProjectTimer;
    }
}

