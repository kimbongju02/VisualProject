using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace TeamProject3
{
    public partial class Form_Management : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "calendardb";
        string _id = "root";
        string _pw = "bong02";
        string _connectionAddress = "";

        public Form_Management()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};" +
                "Persist Security Info=True;Convert Zero Datetime=True", _server, _port, _database, _id, _pw);
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
                    string selectQuery = string.Format("SELECT * FROM 인원");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listViewPhoneBook.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.SubItems.Add(table["PeopleName"].ToString());
                        item.SubItems.Add(table["PhoneNumber"].ToString());
                        item.SubItems.Add(table["Address"].ToString());
                        item.SubItems.Add(table["Sex"].ToString());
                        item.SubItems.Add(table["Height"].ToString());
                        item.SubItems.Add(table["Weight"].ToString());
                        item.SubItems.Add(table["Uniform"].ToString());
                        item.SubItems.Add(table["PeopleDetail"].ToString());
                        item.SubItems.Add(table["PeopleDay"].ToString());
                        item.SubItems.Add(table["PeopleDay"].ToString());
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
                    string insertQuery = string.Format("INSERT INTO 인원 (PeopleName, PhoneNumber, Address, Sex, Height, Weight, Uniform, PeopleDetail, PeopleDay) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}','0000-00-00');",
                        textBoxName.Text, textBoxPhone.Text, textBoxAddress.Text, textBoxSex.Text, 
                        textBoxHeight.Text, textBoxWeight.Text, textBoxUniform.Text, textBoxDetail.Text);

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
                    string updateQuery = string.Format($"UPDATE 인원 SET  PhoneNumber = '{textBoxPhone.Text}',  " +
                        $"Address = '{textBoxAddress.Text}', Sex = '{textBoxSex.Text}', Height = '{textBoxHeight.Text}',  " +
                        $"Weight = '{textBoxWeight.Text}', Uniform = '{textBoxUniform.Text}', PeopleDetail = '{textBoxDetail.Text}' " +
                        $"where  PeopleName='{textBoxName.Text}';");

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
                        string diableSafe = "SET SQL_SAFE_UPDATES = 0";
                        string deleteQuery = string.Format($"DELETE FROM 인원 WHERE PeopleName='{textBoxName.Text}';");
                        string ableSafe = "SET SQL_SAFE_UPDATES = 1";

                        MySqlCommand command1 = new MySqlCommand(diableSafe, mysql);
                        MySqlCommand command2 = new MySqlCommand(deleteQuery, mysql);
                        MySqlCommand command4 = new MySqlCommand(ableSafe, mysql);

                        if (command2.ExecuteNonQuery() != 1)
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
            textBoxDate.Text = listview.Items[index].SubItems[9].Text;
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
                   
                    string selectQuery = string.Format("SELECT * FROM 인원");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listViewPhoneBook.Items.Clear();


                    while (table.Read())
                    {
                        if (table["PeopleName"].ToString() == textBoxName0.Text)   
                        {

                            ListViewItem item = new ListViewItem();
                            item.SubItems.Add(table["PeopleName"].ToString());
                            item.SubItems.Add(table["PhoneNumber"].ToString());
                            item.SubItems.Add(table["Address"].ToString());
                            item.SubItems.Add(table["Sex"].ToString());
                            item.SubItems.Add(table["Height"].ToString());
                            item.SubItems.Add(table["Weight"].ToString());
                            item.SubItems.Add(table["Uniform"].ToString());
                            item.SubItems.Add(table["PeopleDetail"].ToString());
                            item.SubItems.Add(table["PeopleDay"].ToString());
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

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToInt32(Keys.Back)))    //숫자와만 입력가능
            {
                e.Handled = true;
                MessageBox.Show("숫자만입력가능합니다.");
            }
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToInt32(Keys.Back)))    //숫자와 만 입력가능
            {
                e.Handled = true;
                MessageBox.Show("숫자만입력가능합니다.");
            }
        }

        private void deleteDay_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string diableSafe = "SET SQL_SAFE_UPDATES = 0";
                    string deletePeople = ($"update 인원 set PeopleDay={0000-00-00} where PeopleName='{textBoxName.Text}';");
                    string ableSafe = "SET SQL_SAFE_UPDATES = 1";

                    MySqlCommand command1 = new MySqlCommand(diableSafe, mysql);
                    MySqlDataReader table1 = command1.ExecuteReader();
                    table1.Close();
                    MySqlCommand command2 = new MySqlCommand(deletePeople, mysql);
                    MySqlDataReader table2 = command2.ExecuteReader();
                    table2.Close();
                    MySqlCommand command4 = new MySqlCommand(ableSafe, mysql);
                    MySqlDataReader table4 = command4.ExecuteReader();
                    table4.Close();

                    textBoxName.Text = "";
                    textBoxPhone.Text = "";
                    textBoxAddress.Text = "";
                    textBoxSex.Text = "";
                    textBoxHeight.Text = "";
                    textBoxWeight.Text = "";
                    textBoxUniform.Text = "";
                    textBoxDetail.Text = "";
                    textBoxDate.Text= "";
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            selectTable();
        }
    }
}