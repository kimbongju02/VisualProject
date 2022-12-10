namespace Calendar.NETDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            calendar1 = new Calendar.NET.Calendar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(952, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "현장추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(952, 528);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "인원 추가";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // calendar1
            // 
            calendar1.AllowEditingEvents = false;
            calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            calendar1.BackColor = System.Drawing.Color.Transparent;
            calendar1.CalendarDate = new System.DateTime(2012, 4, 24, 13, 16, 0, 0);
            calendar1.CalendarView = Calendar.NET.CalendarViews.Month;
            calendar1.DateHeaderFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            calendar1.DayOfWeekFont = new System.Drawing.Font("Arial", 10F);
            calendar1.DaysFont = new System.Drawing.Font("Arial", 10F);
            calendar1.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            calendar1.DimDisabledEvents = true;
            calendar1.HighlightCurrentDay = true;
            calendar1.LoadPresetHolidays = true;
            calendar1.Location = new System.Drawing.Point(16, 14);
            calendar1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            calendar1.Name = "calendar1";
            calendar1.ShowArrowControls = true;
            calendar1.ShowDashedBorderOnDisabledEvents = true;
            calendar1.ShowDateInHeader = true;
            calendar1.ShowDisabledEvents = false;
            calendar1.ShowEventTooltips = true;
            calendar1.ShowTodayButton = true;
            calendar1.Size = new System.Drawing.Size(952, 618);
            calendar1.TabIndex = 0;
            calendar1.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 634);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(calendar1);
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public static NET.Calendar calendar1;
    }
}

