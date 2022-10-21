using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") | (textBox2.Text != "") | (textBox3.Text != "") | (textBox4.Text != "") | (textBox5.Text != "") | (textBox6.Text != "")){
                MessageBox.Show("Вы не заполнили некоторые таблицы");
            }
            else
            {
                MessageBox.Show("Вы успешно записаны в волонтеры! Поздравляем!");
                Close();
            }
        }
    }
}
