using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calendar.NET
{
    public partial class AddDetails : Form
    {
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
            dtDate.CustomFormat = _event.IgnoreTimeComponent ? "M/d/yyyy" : "M/d/yyyy";//시간 찾기

            Text = char.ToUpper(_event.EventText[0]) + _event.EventText.Substring(1) + " Details";

            _newEvent = _event.Clone();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            _newEvent.EventText = txtEventName.Text;
            _newEvent.Date = dtDate.Value;
            String[] result = { txtEventName.Text , dtDate.Value.ToString(format: "dd-MM-yy") };

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
