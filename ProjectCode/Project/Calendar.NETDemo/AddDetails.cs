using Calendar.NETDemo;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace Calendar.NET
{
    public partial class AddDetails : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "mstore2";
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

        public AddDetails()
        {
            InitializeComponent();
        }

        private void EventDetailsLoad(object sender, EventArgs e)
        {
        }

        private void FillValues()
        {
            txtEventName.Text = _event.EventText;
            dtDate.Value = _event.Date;
            dtDate.CustomFormat = _event.IgnoreTimeComponent ? "yyyy/M/d" : "yyyy/M/d";//시간 찾기

            Text = char.ToUpper(_event.EventText[0]) + _event.EventText.Substring(1) + " Details";

            _newEvent = _event.Clone();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            String text = txtEventName.Text;
            String day = dtDate.Value.ToString("yyyy/M/d");
            String detail = textBox1.Text;
            Form1.addDay = day;

            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = ($"insert into 현장(이름, 날짜, 세부사항) values('{text}','{day}','{detail}');");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    table.Close();
                }
                var ce2 = new CustomEvent
                {
                    IgnoreTimeComponent = false,
                    EventText = text,
                    Date = Convert.ToDateTime(day),
                    EventLengthInHours = 2f,
                    RecurringFrequency = RecurringFrequencies.None,
                    EventFont = new Font("Verdana", 12, FontStyle.Regular),
                    Enabled = true,
                    EventColor = Color.FromArgb(120, 255, 120),
                    EventTextColor = Color.Black,
                    ThisDayForwardOnly=true
                };
                Form1.calendar1.AddEvent(ce2);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            Close();

            DialogResult = DialogResult.OK;

            Close();
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
