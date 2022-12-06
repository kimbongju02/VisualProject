namespace Calender_program
{
    partial class add_date_form
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
            this.add_date_date_lable = new System.Windows.Forms.Label();
            this.add_date_time_lable = new System.Windows.Forms.Label();
            this.add_date_field_lable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.add_date_detail_lable = new System.Windows.Forms.Label();
            this.add_date_detail_richtextbox = new System.Windows.Forms.RichTextBox();
            this.add_date_add_button = new System.Windows.Forms.Button();
            this.add_date_cancle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_date_date_lable
            // 
            this.add_date_date_lable.AutoSize = true;
            this.add_date_date_lable.Font = new System.Drawing.Font("굴림", 13F);
            this.add_date_date_lable.Location = new System.Drawing.Point(29, 23);
            this.add_date_date_lable.Name = "add_date_date_lable";
            this.add_date_date_lable.Size = new System.Drawing.Size(44, 18);
            this.add_date_date_lable.TabIndex = 0;
            this.add_date_date_lable.Text = "날짜";
            // 
            // add_date_time_lable
            // 
            this.add_date_time_lable.AutoSize = true;
            this.add_date_time_lable.Font = new System.Drawing.Font("굴림", 13F);
            this.add_date_time_lable.Location = new System.Drawing.Point(29, 61);
            this.add_date_time_lable.Name = "add_date_time_lable";
            this.add_date_time_lable.Size = new System.Drawing.Size(44, 18);
            this.add_date_time_lable.TabIndex = 1;
            this.add_date_time_lable.Text = "시간";
            // 
            // add_date_field_lable
            // 
            this.add_date_field_lable.AutoSize = true;
            this.add_date_field_lable.Font = new System.Drawing.Font("굴림", 13F);
            this.add_date_field_lable.Location = new System.Drawing.Point(29, 99);
            this.add_date_field_lable.Name = "add_date_field_lable";
            this.add_date_field_lable.Size = new System.Drawing.Size(80, 18);
            this.add_date_field_lable.TabIndex = 2;
            this.add_date_field_lable.Text = "현장이름";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(306, 21);
            this.textBox3.TabIndex = 5;
            // 
            // add_date_detail_lable
            // 
            this.add_date_detail_lable.AutoSize = true;
            this.add_date_detail_lable.Font = new System.Drawing.Font("굴림", 13F);
            this.add_date_detail_lable.Location = new System.Drawing.Point(29, 148);
            this.add_date_detail_lable.Name = "add_date_detail_lable";
            this.add_date_detail_lable.Size = new System.Drawing.Size(80, 18);
            this.add_date_detail_lable.TabIndex = 6;
            this.add_date_detail_lable.Text = "세부사항";
            // 
            // add_date_detail_richtextbox
            // 
            this.add_date_detail_richtextbox.Location = new System.Drawing.Point(32, 169);
            this.add_date_detail_richtextbox.Name = "add_date_detail_richtextbox";
            this.add_date_detail_richtextbox.Size = new System.Drawing.Size(389, 187);
            this.add_date_detail_richtextbox.TabIndex = 7;
            this.add_date_detail_richtextbox.Text = "";
            // 
            // add_date_add_button
            // 
            this.add_date_add_button.Location = new System.Drawing.Point(497, 284);
            this.add_date_add_button.Name = "add_date_add_button";
            this.add_date_add_button.Size = new System.Drawing.Size(93, 26);
            this.add_date_add_button.TabIndex = 8;
            this.add_date_add_button.Text = "추가";
            this.add_date_add_button.UseVisualStyleBackColor = true;
            this.add_date_add_button.Click += new System.EventHandler(this.add_date_add_button_Click);
            // 
            // add_date_cancle_button
            // 
            this.add_date_cancle_button.Location = new System.Drawing.Point(497, 330);
            this.add_date_cancle_button.Name = "add_date_cancle_button";
            this.add_date_cancle_button.Size = new System.Drawing.Size(93, 26);
            this.add_date_cancle_button.TabIndex = 9;
            this.add_date_cancle_button.Text = "취소";
            this.add_date_cancle_button.UseVisualStyleBackColor = true;
            this.add_date_cancle_button.Click += new System.EventHandler(this.add_date_cancle_button_Click);
            // 
            // add_date_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 397);
            this.Controls.Add(this.add_date_cancle_button);
            this.Controls.Add(this.add_date_add_button);
            this.Controls.Add(this.add_date_detail_richtextbox);
            this.Controls.Add(this.add_date_detail_lable);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_date_field_lable);
            this.Controls.Add(this.add_date_time_lable);
            this.Controls.Add(this.add_date_date_lable);
            this.Name = "add_date_form";
            this.Text = "일정 변경 버튼 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_date_date_lable;
        private System.Windows.Forms.Label add_date_time_lable;
        private System.Windows.Forms.Label add_date_field_lable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label add_date_detail_lable;
        private System.Windows.Forms.RichTextBox add_date_detail_richtextbox;
        private System.Windows.Forms.Button add_date_add_button;
        private System.Windows.Forms.Button add_date_cancle_button;
    }
}