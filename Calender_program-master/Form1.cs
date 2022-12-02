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
 
    public partial class Form1 : Form
    {
         int month = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void monthbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(month_combobox.SelectedIndex == 0)
            {
                month = 1;
                
            }
            else if (month_combobox.SelectedIndex == 1)
            {
                month = 2;
            }
            else if (month_combobox.SelectedIndex == 2)
            {
                month = 3;
            }
            else if (month_combobox.SelectedIndex == 3)
            {
                month = 4;
            }
            else if (month_combobox.SelectedIndex == 4)
            {
                month = 5;
            }
            else if (month_combobox.SelectedIndex == 5)
            {
                month = 6;
            }
            else if (month_combobox.SelectedIndex == 6)
            {
                month = 7;
            }
            else if (month_combobox.SelectedIndex == 7)
            {
                month = 8;
            }
            else if (month_combobox.SelectedIndex == 8)
            {
                month = 9;
            }
            else if (month_combobox.SelectedIndex == 9)
            {
                month = 10;
            }
            else if (month_combobox.SelectedIndex == 10)
            {
                month = 11;
            }
            else if (month_combobox.SelectedIndex == 11)
            {
                month = 12;
            }
            month_text.Text = month.ToString()+" 월";
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_button_Click(object sender, EventArgs e)
        {
           click_calender_button_form f1 = new click_calender_button_form();
            f1.Tag = this;
            f1.Show();
            this.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void person_button_Click(object sender, EventArgs e)
        {

        }
    }
    
}
