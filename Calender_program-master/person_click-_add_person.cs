using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace Calender_program
{
    public partial class person_click__add_person : Form
    {

        string _server = "localhost";
        int _port = 3306;
        string _database = "member1";
        string _id = "root";
        string _pw = "1234";
        string _connectionAddress = "";
        public person_click__add_person()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
            {

                mysql.Open();
                string insertQuery = string.Format("INSERT INTO root (Name, PhoneNumber, Address, Sex, Height, Weight, Uniform, Detail) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                  namebox.Text, phonenumberbox.Text, addressbox.Text, genderbox.Text, clothbox.Text, weightbox.Text, heightbox.Text, detailbox.Text);
                   MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("인서트 성공");
                }
                else
                {
                    MessageBox.Show("인서트 실패");

                }

            }
            person_form person_Form = new person_form();
            person_Form.Tag = this;
            person_Form.Show();
            this.Hide();
        }

        private void heightbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void weightbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
