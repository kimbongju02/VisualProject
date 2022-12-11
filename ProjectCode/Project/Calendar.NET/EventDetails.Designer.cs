namespace Calendar.NET
{
    partial class EventDetails
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnOk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DetailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InputPeopleName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontDialog1
            // 
            this.fontDialog1.ScriptsOnly = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 338);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 28);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 338);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "현장 날짜";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "yyyy/M/d";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(131, 31);
            this.dtDate.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(265, 25);
            this.dtDate.TabIndex = 10;
            this.dtDate.Value = new System.DateTime(2022, 12, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "현장 이름";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(131, 82);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtEventName.Multiline = true;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(265, 25);
            this.txtEventName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "세부사항";
            // 
            // DetailTextBox
            // 
            this.DetailTextBox.Location = new System.Drawing.Point(47, 186);
            this.DetailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetailTextBox.Multiline = true;
            this.DetailTextBox.Name = "DetailTextBox";
            this.DetailTextBox.Size = new System.Drawing.Size(349, 146);
            this.DetailTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "투입 인원";
            // 
            // InputPeopleName
            // 
            this.InputPeopleName.Location = new System.Drawing.Point(133, 128);
            this.InputPeopleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputPeopleName.Multiline = true;
            this.InputPeopleName.Name = "InputPeopleName";
            this.InputPeopleName.ReadOnly = true;
            this.InputPeopleName.Size = new System.Drawing.Size(263, 50);
            this.InputPeopleName.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputPeopleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DetailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventDetails";
            this.Load += new System.EventHandler(this.EventDetailsLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DetailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputPeopleName;
        private System.Windows.Forms.Button button1;
    }
}