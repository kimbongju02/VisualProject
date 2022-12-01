namespace TeamProject2
{
    partial class Form_Management
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewPhoneBook = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.fieldInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewPhoneBook
            // 
            this.listViewPhoneBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPhoneBook.FullRowSelect = true;
            this.listViewPhoneBook.HideSelection = false;
            this.listViewPhoneBook.Location = new System.Drawing.Point(58, 118);
            this.listViewPhoneBook.Name = "listViewPhoneBook";
            this.listViewPhoneBook.Size = new System.Drawing.Size(494, 272);
            this.listViewPhoneBook.TabIndex = 28;
            this.listViewPhoneBook.UseCompatibleStateImageBehavior = false;
            this.listViewPhoneBook.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            this.columnHeader3.Width = 150;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(444, 61);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(102, 36);
            this.buttonSelect.TabIndex = 27;
            this.buttonSelect.Text = "검색";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(645, 318);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 31);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "인원 삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(644, 281);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 31);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "정보 변경";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(644, 244);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 31);
            this.buttonInsert.TabIndex = 24;
            this.buttonInsert.Text = "인원 추가";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // fieldInsert
            // 
            this.fieldInsert.Location = new System.Drawing.Point(644, 207);
            this.fieldInsert.Name = "fieldInsert";
            this.fieldInsert.Size = new System.Drawing.Size(100, 31);
            this.fieldInsert.TabIndex = 23;
            this.fieldInsert.Text = "현장에 추가";
            this.fieldInsert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(55, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "이름";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(109, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(287, 21);
            this.textBoxName.TabIndex = 21;
            // 
            // Form_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewPhoneBook);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.fieldInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form_Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Form_Management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listViewPhoneBook;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button fieldInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

