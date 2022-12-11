namespace Calendar.NETDemo
{
    partial class InputPeople
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
            this.label9 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCalendarField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPeopleDay = new System.Windows.Forms.TextBox();
            this.txtUniform = new System.Windows.Forms.TextBox();
            this.txtPeopleDetail = new System.Windows.Forms.TextBox();
            this.txtCalendarDetail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PeopleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uniform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PeopleDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PeopleDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "투입 현장";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(791, 411);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 39);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(791, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 39);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PeopleName,
            this.Phone,
            this.Address,
            this.Age,
            this.Sex,
            this.Height,
            this.Weight,
            this.Uniform,
            this.PeopleDay,
            this.PeopleDetail});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(828, 156);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "인원 목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "성별";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "신장";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "체중";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "연락처";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "주소";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 203);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(74, 21);
            this.txtName.TabIndex = 30;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(813, 203);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(54, 21);
            this.txtSex.TabIndex = 32;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(69, 232);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(74, 21);
            this.txtHeight.TabIndex = 33;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(203, 230);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(82, 21);
            this.txtWeight.TabIndex = 34;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(203, 203);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(151, 21);
            this.txtPhone.TabIndex = 35;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(395, 203);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(281, 21);
            this.txtAddress.TabIndex = 36;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(35, 287);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(450, 208);
            this.listView2.TabIndex = 37;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "이름";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "날짜";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "세부사항";
            this.columnHeader11.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "투입 날짜";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(503, 302);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(359, 21);
            this.dtDate.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 40;
            this.label11.Text = "투입 장소";
            // 
            // txtCalendarField
            // 
            this.txtCalendarField.Location = new System.Drawing.Point(503, 341);
            this.txtCalendarField.Name = "txtCalendarField";
            this.txtCalendarField.Size = new System.Drawing.Size(358, 21);
            this.txtCalendarField.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 42;
            this.label3.Text = "나이";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(723, 203);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(49, 21);
            this.txtAge.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 44;
            this.label12.Text = "복장";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 45;
            this.label13.Text = "투입 날짜";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(549, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 12);
            this.label14.TabIndex = 46;
            this.label14.Text = "세부 사항";
            // 
            // txtPeopleDay
            // 
            this.txtPeopleDay.Location = new System.Drawing.Point(438, 230);
            this.txtPeopleDay.Name = "txtPeopleDay";
            this.txtPeopleDay.Size = new System.Drawing.Size(100, 21);
            this.txtPeopleDay.TabIndex = 47;
            // 
            // txtUniform
            // 
            this.txtUniform.Location = new System.Drawing.Point(326, 229);
            this.txtUniform.Name = "txtUniform";
            this.txtUniform.Size = new System.Drawing.Size(43, 21);
            this.txtUniform.TabIndex = 48;
            // 
            // txtPeopleDetail
            // 
            this.txtPeopleDetail.Location = new System.Drawing.Point(612, 230);
            this.txtPeopleDetail.Multiline = true;
            this.txtPeopleDetail.Name = "txtPeopleDetail";
            this.txtPeopleDetail.Size = new System.Drawing.Size(255, 49);
            this.txtPeopleDetail.TabIndex = 49;
            // 
            // txtCalendarDetail
            // 
            this.txtCalendarDetail.Location = new System.Drawing.Point(505, 380);
            this.txtCalendarDetail.Multiline = true;
            this.txtCalendarDetail.Name = "txtCalendarDetail";
            this.txtCalendarDetail.Size = new System.Drawing.Size(280, 115);
            this.txtCalendarDetail.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(501, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 12);
            this.label15.TabIndex = 51;
            this.label15.Text = "세부 사항";
            // 
            // PeopleName
            // 
            this.PeopleName.Text = "이름";
            // 
            // Phone
            // 
            this.Phone.Text = "연락처";
            this.Phone.Width = 100;
            // 
            // Address
            // 
            this.Address.Text = "주소";
            this.Address.Width = 100;
            // 
            // Age
            // 
            this.Age.Text = "나이";
            this.Age.Width = 50;
            // 
            // Sex
            // 
            this.Sex.Text = "성별";
            this.Sex.Width = 50;
            // 
            // Height
            // 
            this.Height.Text = "신장";
            // 
            // Weight
            // 
            this.Weight.Text = "체중";
            // 
            // Uniform
            // 
            this.Uniform.Text = "복장";
            this.Uniform.Width = 50;
            // 
            // PeopleDay
            // 
            this.PeopleDay.Text = "투입 날짜";
            this.PeopleDay.Width = 100;
            // 
            // PeopleDetail
            // 
            this.PeopleDetail.Text = "세부사항";
            this.PeopleDetail.Width = 150;
            // 
            // InputPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 507);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCalendarDetail);
            this.Controls.Add(this.txtPeopleDetail);
            this.Controls.Add(this.txtUniform);
            this.Controls.Add(this.txtPeopleDay);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCalendarField);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label9);
            this.Name = "InputPeople";
            this.Text = "InputPeople";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCalendarField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPeopleDay;
        private System.Windows.Forms.TextBox txtUniform;
        private System.Windows.Forms.TextBox txtPeopleDetail;
        private System.Windows.Forms.TextBox txtCalendarDetail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader PeopleName;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Uniform;
        private System.Windows.Forms.ColumnHeader PeopleDay;
        private System.Windows.Forms.ColumnHeader PeopleDetail;
    }
}