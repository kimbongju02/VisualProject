using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender_program
{
    public partial class click_calender_button_form : Form
    {
        public click_calender_button_form()
        {
            InitializeComponent();
        }

        private void change_calender_button_Click(object sender, EventArgs e)
        {
            change_calender_form cdf = new change_calender_form();
            cdf.Tag = this;
            cdf.Show();
            this.Hide();
        }

        private void add_calender_button_Click(object sender, EventArgs e)
        {
            add_date_form adf = new add_date_form();
            adf.Tag = this;
            adf.Show();
            this.Hide();
        }
    }
}
