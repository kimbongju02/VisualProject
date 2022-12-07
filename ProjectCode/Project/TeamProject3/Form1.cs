using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace TeamProject3
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

        //로드시 테이블 조회
        private void Form1_Load(object sender, EventArgs e)  
        {
            selectTable();
        }

        //테이블 조회  리스트뷰에 테이블 내용 불러옴
        public void selectTable()  
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
                        item.Text = table["ID"].ToString();
                        item.SubItems.Add(table["Name"].ToString());
                        item.SubItems.Add(table["PhoneNumber"].ToString());
                        item.SubItems.Add(table["Address"].ToString());
                        item.SubItems.Add(table["Sex"].ToString());
                        item.SubItems.Add(table["Height"].ToString());
                        item.SubItems.Add(table["Weight"].ToString());
                        item.SubItems.Add(table["Uniform"].ToString());
                        item.SubItems.Add(table["Detail"].ToString());
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

        //인원 추가 버튼 클릭
        private void buttonInsert_Click(object sender, EventArgs e)   
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {

                    mysql.Open();
                    string insertQuery = string.Format("INSERT INTO co32table (Name, PhoneNumber, Address, Sex, Height, Weight, Uniform, Detail) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                        textBoxName.Text, textBoxPhone.Text, textBoxAddress.Text, textBoxSex.Text, textBoxHeight.Text, textBoxWeight.Text, textBoxUniform.Text, textBoxDetail.Text);

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");

                    textBoxName.Text = "";
                    textBoxPhone.Text = "";
                    textBoxAddress.Text = "";
                    textBoxSex.Text = "";
                    textBoxHeight.Text = "";
                    textBoxWeight.Text = "";
                    textBoxUniform.Text = "";
                    textBoxDetail.Text = "";

                    selectTable();
                    MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //정보변경 버튼 클릭시
        private void buttonUpdate_Click(object sender, EventArgs e)   
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    int pos = listViewPhoneBook.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listViewPhoneBook.Items[pos].Text);
                    string updateQuery = string.Format("UPDATE co32table SET Name = '{1}', PhoneNumber = '{2}',  Address = '{3}', Sex = '{4}', Height = '{5}',  Weight = '{6}', Uniform = '{7}', Detail = '{8}' WHERE id={0};", index,
                        textBoxName.Text, textBoxPhone.Text, textBoxAddress.Text, textBoxSex.Text, textBoxHeight.Text, textBoxWeight.Text, textBoxUniform.Text, textBoxDetail.Text);

                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    textBoxName.Text = "";
                    textBoxPhone.Text = "";
                    textBoxAddress.Text = "";
                    textBoxSex.Text = "";
                    textBoxHeight.Text = "";
                    textBoxWeight.Text = "";
                    textBoxUniform.Text = "";
                    textBoxDetail.Text = "";

                    selectTable();
                    MessageBox.Show("정상적으로 데이터가 변경되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //인원삭제 버튼 클릭시
        private void buttonDelete_Click(object sender, EventArgs e)  
        {
            if (MessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {

                try
                {
                    using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                    {


                        mysql.Open();
                        int pos = listViewPhoneBook.SelectedItems[0].Index;
                        int index = Convert.ToInt32(listViewPhoneBook.Items[pos].Text);
                        string deleteQuery = string.Format("DELETE FROM co32table WHERE Id={0};", index);

                        MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
                        if (command.ExecuteNonQuery() != 1)
                            MessageBox.Show("Failed to delete data.");

                        textBoxName.Text = "";
                        textBoxPhone.Text = "";
                        textBoxAddress.Text = "";
                        textBoxSex.Text = "";
                        textBoxHeight.Text = "";
                        textBoxWeight.Text = "";
                        textBoxUniform.Text = "";
                        textBoxDetail.Text = "";

                        selectTable();
                        MessageBox.Show("삭제되었습니다.");
                    }
                }
                
             
                catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                
            }
           
        

        //리스트뷰 항목 선택시 텍스트 박스에 테이블 내용 불러옴
        private void listViewPhoneBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview = sender as ListView;

            int index = listview.FocusedItem.Index;
            textBoxName.Text = listview.Items[index].SubItems[1].Text;
            textBoxPhone.Text = listview.Items[index].SubItems[2].Text;
            textBoxAddress.Text = listview.Items[index].SubItems[3].Text;
            textBoxSex.Text = listview.Items[index].SubItems[4].Text;
            textBoxHeight.Text = listview.Items[index].SubItems[5].Text;
            textBoxWeight.Text = listview.Items[index].SubItems[6].Text;
            textBoxUniform.Text = listview.Items[index].SubItems[7].Text;
            textBoxDetail.Text = listview.Items[index].SubItems[8].Text;
        }
        //비우기 버튼 클릭시
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            textBoxSex.Text = "";
            textBoxHeight.Text = "";
            textBoxWeight.Text = "";
            textBoxUniform.Text = "";
            textBoxDetail.Text = "";
        }

        //취소 버튼 클릭시
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //인원 검색 버튼 클릭시
        private void buttonSelect_Click(object sender, EventArgs e)     
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
                        if (table["Name"].ToString() == textBoxName0.Text)   
                        {

                            ListViewItem item = new ListViewItem();
                            item.Text = table["ID"].ToString();
                            item.SubItems.Add(table["Name"].ToString());
                            item.SubItems.Add(table["PhoneNumber"].ToString());
                            item.SubItems.Add(table["Address"].ToString());
                            item.SubItems.Add(table["Sex"].ToString());
                            item.SubItems.Add(table["Height"].ToString());
                            item.SubItems.Add(table["Weight"].ToString());
                            item.SubItems.Add(table["Uniform"].ToString());
                            item.SubItems.Add(table["Detail"].ToString());
                            listViewPhoneBook.Items.Add(item);

                        }
                        else if(textBoxName0.Text=="" )
                        {
                            selectTable();
                        }
                    }

                    
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        
        }


        //전화번호 텍스트 상자 입력
        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)  
        {
           
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == Convert.ToInt32(Keys.Back)))    //숫자와 '-' 만 입력가능
            {
                e.Handled = true;
                MessageBox.Show("숫자와-만입력가능합니다.");
            }


        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            selectTable();
        }
    }
}
         
           
  

