namespace Calender_program
{
    partial class person_form
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
            this.person_search_textbox = new System.Windows.Forms.TextBox();
            this.person_search_lable = new System.Windows.Forms.Label();
            this.person_search_button = new System.Windows.Forms.Button();
            this.person_name_textbox = new System.Windows.Forms.RichTextBox();
            this.person_name_listbox = new System.Windows.Forms.ListBox();
            this.person_phonenumber_textbox = new System.Windows.Forms.RichTextBox();
            this.person_phonenumber_listbox = new System.Windows.Forms.ListBox();
            this.add_person_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // person_search_textbox
            // 
            this.person_search_textbox.Font = new System.Drawing.Font("굴림", 13F);
            this.person_search_textbox.Location = new System.Drawing.Point(74, 26);
            this.person_search_textbox.Name = "person_search_textbox";
            this.person_search_textbox.Size = new System.Drawing.Size(426, 27);
            this.person_search_textbox.TabIndex = 0;
            // 
            // person_search_lable
            // 
            this.person_search_lable.AutoSize = true;
            this.person_search_lable.Font = new System.Drawing.Font("굴림", 13F);
            this.person_search_lable.Location = new System.Drawing.Point(12, 28);
            this.person_search_lable.Name = "person_search_lable";
            this.person_search_lable.Size = new System.Drawing.Size(56, 18);
            this.person_search_lable.TabIndex = 1;
            this.person_search_lable.Text = "검색 :";
            // 
            // person_search_button
            // 
            this.person_search_button.Font = new System.Drawing.Font("굴림", 13F);
            this.person_search_button.Location = new System.Drawing.Point(506, 26);
            this.person_search_button.Name = "person_search_button";
            this.person_search_button.Size = new System.Drawing.Size(104, 27);
            this.person_search_button.TabIndex = 2;
            this.person_search_button.Text = "찾기";
            this.person_search_button.UseVisualStyleBackColor = true;
            // 
            // person_name_textbox
            // 
            this.person_name_textbox.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.person_name_textbox.Location = new System.Drawing.Point(74, 73);
            this.person_name_textbox.Name = "person_name_textbox";
            this.person_name_textbox.Size = new System.Drawing.Size(154, 30);
            this.person_name_textbox.TabIndex = 3;
            this.person_name_textbox.Text = "이름 ";
            // 
            // person_name_listbox
            // 
            this.person_name_listbox.FormattingEnabled = true;
            this.person_name_listbox.ItemHeight = 12;
            this.person_name_listbox.Location = new System.Drawing.Point(76, 100);
            this.person_name_listbox.Name = "person_name_listbox";
            this.person_name_listbox.Size = new System.Drawing.Size(154, 244);
            this.person_name_listbox.TabIndex = 4;
            this.person_name_listbox.SelectedIndexChanged += new System.EventHandler(this.person_name_listbox_SelectedIndexChanged);
            // 
            // person_phonenumber_textbox
            // 
            this.person_phonenumber_textbox.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.person_phonenumber_textbox.Location = new System.Drawing.Point(225, 73);
            this.person_phonenumber_textbox.Name = "person_phonenumber_textbox";
            this.person_phonenumber_textbox.Size = new System.Drawing.Size(275, 30);
            this.person_phonenumber_textbox.TabIndex = 5;
            this.person_phonenumber_textbox.Text = "전화번호";
            // 
            // person_phonenumber_listbox
            // 
            this.person_phonenumber_listbox.FormattingEnabled = true;
            this.person_phonenumber_listbox.ItemHeight = 12;
            this.person_phonenumber_listbox.Location = new System.Drawing.Point(225, 101);
            this.person_phonenumber_listbox.Name = "person_phonenumber_listbox";
            this.person_phonenumber_listbox.Size = new System.Drawing.Size(275, 244);
            this.person_phonenumber_listbox.TabIndex = 6;
            this.person_phonenumber_listbox.SelectedIndexChanged += new System.EventHandler(this.person_phonenumber_listbox_SelectedIndexChanged);
            // 
            // add_person_button
            // 
            this.add_person_button.Location = new System.Drawing.Point(517, 227);
            this.add_person_button.Name = "add_person_button";
            this.add_person_button.Size = new System.Drawing.Size(93, 26);
            this.add_person_button.TabIndex = 11;
            this.add_person_button.Text = "인원 추가";
            this.add_person_button.UseVisualStyleBackColor = true;
            this.add_person_button.Click += new System.EventHandler(this.add_date_cancle_button_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "인원 삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "정보 변경";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(517, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 26);
            this.button3.TabIndex = 14;
            this.button3.Text = "뒤로 가기 ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // person_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 397);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add_person_button);
            this.Controls.Add(this.person_phonenumber_listbox);
            this.Controls.Add(this.person_phonenumber_textbox);
            this.Controls.Add(this.person_name_listbox);
            this.Controls.Add(this.person_name_textbox);
            this.Controls.Add(this.person_search_button);
            this.Controls.Add(this.person_search_lable);
            this.Controls.Add(this.person_search_textbox);
            this.Name = "person_form";
            this.Text = "인원메뉴버튼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox person_search_textbox;
        private System.Windows.Forms.Label person_search_lable;
        private System.Windows.Forms.Button person_search_button;
        private System.Windows.Forms.RichTextBox person_name_textbox;
        private System.Windows.Forms.RichTextBox person_phonenumber_textbox;
        private System.Windows.Forms.Button add_person_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox person_name_listbox;
        public System.Windows.Forms.ListBox person_phonenumber_listbox;
        private System.Windows.Forms.Button button3;
    }
}