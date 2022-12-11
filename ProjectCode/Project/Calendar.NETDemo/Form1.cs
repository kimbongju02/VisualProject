using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calendar.NET;
using TeamProject3;
using MySql.Data.MySqlClient;



namespace Calendar.NETDemo
{
    public partial class Form1 : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "calendardb";
        string _id = "root";
        string _pw = "Halkeye14!";
        string _connectionAddress = "";
        [CustomRecurringFunction("RehabDates", "Calculates which days I should be getting Rehab")]

        public static String addDay="";//날짜 추가버튼에서 사용할 날짜
        public static String addButtonName = "";

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
            
            calendar1.CalendarDate = DateTime.Today; // 오늘 날짜 자동 설정
            calendar1.CalendarView = CalendarViews.Month;
            calendar1.AllowEditingEvents = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDetails f1 = new AddDetails();
            f1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format($"SELECT * FROM 현장");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        var ce2 = new CustomEvent // 현장 추가 이벤트
                        {
                            IgnoreTimeComponent = false,
                            EventText = table["CalendarField"].ToString(),
                            Date = Convert.ToDateTime(table["CalendarDay"].ToString()),
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

        private void button3_Click(object sender, EventArgs e)
        {
            InputPeople f2 = new InputPeople();
            f2.Show();
        }

        private void 인원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamProject3.Form_Management People = new TeamProject3.Form_Management();
            People.Show();
        }
    }
}
