using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalandarApp_Test
{
    public partial class Form3 : Form
    {
        string[] task1 = new string[] { "공사장", "09:00", "서면1번가" };
        string[] task2 = new string[] { "콘서트", "20:00", "동의대학교 열린음악당" };
        string[] task3 = new string[] { "운동장", "13:00", "동의대학교 대운동장" };

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("일정이 삭제되었습니다.", "일정 삭제");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("일정 삭제를 취소하시겠습니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                Close();
                MessageBox.Show("정상적으로 종료되었습니다.");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(task1[0]);
            comboBox1.Items.Add(task2[0]);
            comboBox1.Items.Add(task3[0]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox1.SelectedItem) == task1[0])
            {
                textBox1.Text = task1[1];
                textBox2.Text = task1[2];
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == task2[0])
            {
                textBox1.Text = task2[1];
                textBox2.Text = task2[2];
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == task3[0])
            {
                textBox1.Text = task3[1];
                textBox2.Text = task3[2];
            }
        }
    }
}
