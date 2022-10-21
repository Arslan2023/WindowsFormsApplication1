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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int money = 0;
        int summa;
        private void button1_Click(object sender, EventArgs e)
        {
            summa = Convert.ToInt32(textBox2.Text);
            if (summa < 1500)
            {
                MessageBox.Show("Ну не скупитесь, заплатите больше!");
            }
            else
            {
                MessageBox.Show("Спасибо вам за поддержку!");
                money += Convert.ToInt32(textBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (summa <= 0)
            {
                MessageBox.Show("Сначала оплатите!");
            }
            else
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(money);
        }
    }
}
