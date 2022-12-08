using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calendar.NET;
using MySql.Data.MySqlClient;



namespace Calendar.NETDemo
{
    public partial class Form1 : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "mstore2";
        string _id = "root";
        string _pw = "bong02";
        string _connectionAddress = "";
        [CustomRecurringFunction("RehabDates", "Calculates which days I should be getting Rehab")]

        public static String addDay="";//날짜 추가버튼에서 사용할 날짜

        private bool RehabDays(IEvent evnt, DateTime day)
        {
            if (day.DayOfWeek == DayOfWeek.Monday || day.DayOfWeek == DayOfWeek.Friday)
            {
                if (day.Ticks >= (new DateTime(2012, 7, 1)).Ticks)
                    return false;
                return true;
            }

            return false;
        }

        public Form1()
        {
            InitializeComponent();
            
            calendar1.CalendarDate = new DateTime(2012, 5, 2, 0, 0, 0);
            calendar1.CalendarView = CalendarViews.Month;
            calendar1.AllowEditingEvents = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDetails f1 = new AddDetails();
            f1.Show();
            MessageBox.Show(addDay);
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format($"SELECT * FROM 현장 where 날짜='{addDay}'");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        var ce2 = new CustomEvent
                        {
                            IgnoreTimeComponent = false,
                            EventText = table["이름"].ToString(),
                            Date = Convert.ToDateTime(table["날짜"].ToString()),
                            EventLengthInHours = 2f,
                            RecurringFrequency = RecurringFrequencies.None,
                            EventFont = new Font("Verdana", 12, FontStyle.Regular),
                            Enabled = true,
                            EventColor = Color.FromArgb(120, 255, 120),
                            EventTextColor = Color.Black,
                            ThisDayForwardOnly=true
                        };
                        calendar1.AddEvent(ce2);
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Form1 button1_Click\n"+exc.Message);
            }
        }  
        
    }
}
