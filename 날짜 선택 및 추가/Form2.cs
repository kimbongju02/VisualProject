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

namespace TeamProject3
{

    public partial class Form2 : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "coding32";
        string _id = "root";
        string _pw = "1234";
        string _connectionAddress = "";
        public Form2()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            selectTable();

        }
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Form_Management form_Management = new Form_Management();
            form_Management.Show();
            form_Management.Tag = this;
            this.Hide();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
        }
    }
}
