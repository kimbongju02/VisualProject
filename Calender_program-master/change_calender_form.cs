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
    public partial class change_calender_form : Form
    {
        public change_calender_form()
        {
            InitializeComponent();
        }

        private void change_calender_cancle_button_Click(object sender, EventArgs e)
        {
            click_calender_button_form click_Calender_Button_Form = new click_calender_button_form();
            click_Calender_Button_Form.Tag = this;
            click_Calender_Button_Form.Show();
            this.Hide();
        }
    }
}
