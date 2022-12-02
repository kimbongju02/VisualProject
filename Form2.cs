using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TeamProject2
{
    public partial class Form_Insert : Form
    {

        string _server = "localhost";
        int _port = 3306;
        string _database = "coding32";
        string _id = "root";
        string _pw = "dy12121004?";
        string _connectionAddress = "";

        public Form_Insert()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void buttonInsert_Click(object sender, EventArgs e)  //등록 버튼 클릭 테이블에 내용 저장
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {

                    mysql.Open();   
                    string insertQuery = string.Format("INSERT INTO co32table (Name, PhoneNumber, Address, Sex, Height, Weight, Uniform, Day, Detail) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');",
                        textBoxName.Text, textBoxPhone.Text, textBoxAddress.Text, textBoxSex.Text, textBoxHeight.Text, textBoxWeight.Text, textBoxSex.Text, textBoxUniform.Text, textBoxDetail.Text);

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");

                    textBoxName.Text = "";
                    textBoxPhone.Text = "";
                    textBoxAddress.Text = "";
                    textBoxHeight.Text = "";
                    textBoxWeight.Text = "";
                    textBoxSex.Text = "";
                    textBoxUniform.Text = "";
                    textBoxDetail.Text = "";


                    Form_Management form_Management = new Form_Management();
                    form_Management.selectTable();
                    form_Management.Tag = this;
                    this.Hide();
                    form_Management.Close();
                    MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Management form_Management1 = new Form_Management();
                    form_Management1.Tag = this;
                    form_Management1.Show();
                    this.Hide();
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)  //취소 버튼 클릭
        {
            this.Close();  
        }


    }
}
