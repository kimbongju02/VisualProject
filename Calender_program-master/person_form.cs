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
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Calender_program
{

    public partial class person_form : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "member1";
        string _id = "root";
        string _pw = "1234";
        string _connectionAddress = "";
        public person_form()
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
                    string selectQuery = string.Format("SELECT * FROM root");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    while(table.Read())
                    {
                        person_name_listbox.Items.Add(table["Name"].ToString());
                        person_phonenumber_listbox.Items.Add(table["PhoneNumber"].ToString());
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void person_phonenumber_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_date_add_button_Click(object sender, EventArgs e)
        {
           
            if (person_name_listbox.SelectedIndex==-1)
            {
                MessageBox.Show("error");
            }
            else
            {
               
                person_add_people__button_form person_Add_People__Button_Form = new person_add_people__button_form();
                person_Add_People__Button_Form.settext(person_name_listbox.SelectedItem.ToString());
                person_Add_People__Button_Form.Tag = this;
                person_Add_People__Button_Form.Show();
                this.Hide();
            }

        }

        private void add_date_cancle_button_Click(object sender, EventArgs e)
        {
        }

        private void person_name_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_date_cancle_button_Click_1(object sender, EventArgs e)
        {

            person_click__add_person person_Click__Add_Person = new person_click__add_person();
            person_Click__Add_Person.Tag = this;
            person_Click__Add_Person.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Tag = this;
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    int pos = person_name_listbox.SelectedIndex;
                    string deleteQuery = string.Format("DELETE FROM root WHERE Id={0};",pos );
                    MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");
                    

                    _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
