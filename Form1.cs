using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeamProject2
{
    public partial class Form_Management : Form
    {
        

        string _server = "localhost";
        int _port = 3306;
        string _database = "coding32";
        string _id = "root";
        string _pw = "dy12121004?";
        string _connectionAddress = "";
        public Form_Management()
        {

            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void Form_Management_Load(object sender, EventArgs e)  //실행될 때 테이블 조회. 테이블 내용 불러옴
        {
          
            selectTable();
          
        }

        private void buttonInsert_Click(object sender, EventArgs e)  //인원추가 버튼 클릭시 form2 열림
        {

            Form_Insert form_Insert = new Form_Insert();

            form_Insert.ShowDialog();
            

        }

        public  void selectTable()   //테이블 조회  리스트뷰에 테이블 내용 불러옴
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM co32table");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listViewPhoneBook.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["Id"].ToString();
                        item.SubItems.Add(table["Name"].ToString());
                        item.SubItems.Add(table["PhoneNumber"].ToString());

                        listViewPhoneBook.Items.Add(item);
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)  //인원 삭제 버튼 클릭
        {
            if (MessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                    {


                        mysql.Open();
                        int pos = listViewPhoneBook.SelectedItems[0].Index;
                        int index = Convert.ToInt32(listViewPhoneBook.Items[pos].Text);
                        string deleteQuery = string.Format("DELETE FROM co32table WHERE id={0};", index);

                        MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
                        if (command.ExecuteNonQuery() != 1)
                            MessageBox.Show("Failed to delete data.");

                        Form_Insert form_Insert = new Form_Insert();

                        form_Insert.textBoxName.Text = "";
                        form_Insert.textBoxPhone.Text = "";

                        selectTable();

                    }
                } 
            
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

                MessageBox.Show("삭제되었습니다.");
            }
            else
            {

            }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Form_Insert form_Insert = new Form_Insert();

            form_Insert.ShowDialog();

           
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
          
            }
        }
    }

 



