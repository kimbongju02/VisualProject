using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
         
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 showForm2 = new Form2();

            showForm2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 showForm3 = new Form3();

            showForm3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 showForm4 = new Form4();

            showForm4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 showForm5 = new Form5();

            showForm5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
