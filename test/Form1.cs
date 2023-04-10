using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 3 || textBox1.Text.Length > 15)
            {
                label4.Text = "В имени не должно быть меньше 3 и больше 15 символов";
                return;
            }

            if (textBox2.Text.Length < 2 || textBox2.Text.Length > 25)
            {
                label4.Text = "В фамилии не должно быть меньше 2 и больше 25 символов";
                return;
            }

            label4.Text = "Успешно";
        }
    }
}
