using Calendar.NET;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities.Encoders;
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
using ListView = System.Windows.Forms.ListView;
using static System.Net.Mime.MediaTypeNames;

namespace Calendar.NETDemo
{
    public partial class InputPeople : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "calendardb";
        string _id = "root";
        string _pw = "bong02";
        string _connectionAddress = "";
        [CustomRecurringFunction("RehabDates", "Calculates which days I should be getting Rehab")]

        private IEvent _event;
        private IEvent _newEvent;

        public IEvent Event
        {
            get { return _event; }
            set
            {
                _event = value;
                FillValues();
            }
        }

        public IEvent NewEvent
        {
            get { return _newEvent; }
        }

        public InputPeople()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            selectTable();
        }

        public void selectTable() // DB 로딩, 폼 Load 시 인원 및 현장 표시
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM 인원");
                    string selectQuery2 = string.Format("SELECT * FROM 현장");
                    string selectQuery3 = string.Format("SELECT * FROM 인원투입");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlCommand command2 = new MySqlCommand(selectQuery2, mysql);
                    MySqlCommand command3 = new MySqlCommand(selectQuery3, mysql);



                    listView1.Items.Clear();
                    listView2.Items.Clear();

                    MySqlDataReader table = command.ExecuteReader(); // 인원 테이블 읽기
                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        //item.Text = table["ID"].ToString();
                        item.SubItems.Add(table["PeopleName"].ToString());
                        item.SubItems.Add(table["Age"].ToString());
                        item.SubItems.Add(table["Sex"].ToString());
                        item.SubItems.Add(table["Height"].ToString());
                        item.SubItems.Add(table["Weight"].ToString());
                        item.SubItems.Add(table["PhoneNumber"].ToString());
                        item.SubItems.Add(table["Address"].ToString());
                        listView1.Items.Add(item);
                    }
                    table.Close();

                    MySqlDataReader table2 = command2.ExecuteReader(); // 현장 테이블 읽기
                    while (table2.Read())
                    {
                        ListViewItem item2 = new ListViewItem();
                        //item2.Text = table2["ID"].ToString();
                        item2.SubItems.Add(table2["CalendarField"].ToString());
                        item2.SubItems.Add(table2["CalendarDay"].ToString());
                        item2.SubItems.Add(table2["CalendarDetail"].ToString());
                        listView2.Items.Add(item2);
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void EventDetailsLoad(object sender, EventArgs e)
        {
        }

        private void FillValues()
        {
            txtName.Text = _event.EventText;
            dtDate.Value = _event.Date;
            dtDate.CustomFormat = _event.IgnoreTimeComponent ? "yyyy/M/d" : "yyyy/M/d"; //시간 찾기

            Text = char.ToUpper(_event.EventText[0]) + _event.EventText.Substring(1) + " Details";

            _newEvent = _event.Clone();
        }

        private void btnOK_Click(object sender, EventArgs e) // 인원 현장투입 이벤트 발생, 현장투입 DB에 정보 저장
        {
            String name = txtName.Text;
            String day = dtDate.Value.ToString("yyyy/M/d");
            String detail = txtPlace.Text;

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string diableSafe = "SET SQL_SAFE_UPDATES = 0";
                    string selectQuery = ($"update 인원 set PeopleDay='{day}' where PeopleName='{name}';");
                    string ableSafe = "SET SQL_SAFE_UPDATES = 1";

                    MySqlCommand command1 = new MySqlCommand(diableSafe, mysql);
                    MySqlDataReader table1 = command1.ExecuteReader();
                    table1.Close();
                    MySqlCommand command2 = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table2 = command2.ExecuteReader();
                    table2.Close();
                    MySqlCommand command3 = new MySqlCommand(ableSafe, mysql);
                    MySqlDataReader table3 = command3.ExecuteReader();
                    table3.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            Close();

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) // 텍스트박스에 인원 정보 연결
        {
            ListView listview = sender as ListView;

            int index = listview.FocusedItem.Index;
            txtName.Text = listview.Items[index].SubItems[1].Text;
            txtAge.Text = listview.Items[index].SubItems[2].Text;
            txtSex.Text = listview.Items[index].SubItems[3].Text;
            txtHeight.Text = listview.Items[index].SubItems[4].Text;
            txtWeight.Text = listview.Items[index].SubItems[5].Text;
            txtPhone.Text = listview.Items[index].SubItems[6].Text;
            txtAddress.Text = listview.Items[index].SubItems[7].Text;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e) // 텍스트박스에 투입 장소 연결
        {
            ListView listview = sender as ListView;

            int index = listview.FocusedItem.Index;
            txtPlace.Text = listview.Items[index].SubItems[1].Text;
            dtDate.Text = listview.Items[index].SubItems[2].Text;
        }
    }
}