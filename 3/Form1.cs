using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISFLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            List<char> a = new List<char>();

            if (checkBox1.Checked)
            {
                for (char i = 'A'; i <= 'Z'; i++)
                    a.Add(i);
            }
            if (checkBox2.Checked)
            {
                for (char i = 'a'; i <= 'z'; i++)
                    a.Add(i);
            }
            if (checkBox3.Checked)
            {
                for (char i = 'А'; i <= 'Я'; i++)
                    a.Add(i);
            }
            if (checkBox4.Checked)
            {
                for (char i = 'а'; i <= 'я'; i++)
                    a.Add(i);
            }
            if (checkBox5.Checked)
            {
                for (char i = ' '; i <= '/'; i++)
                    a.Add(i);
                for (char i = ':'; i <= '@'; i++)
                    a.Add(i);
                for (char i = '['; i <= '`'; i++)
                    a.Add(i);
                for (char i = '{'; i <= '~'; i++)
                    a.Add(i);
            }
            if (checkBox6.Checked)
            {
                for (char i = '0'; i <= '9'; i++)
                    a.Add(i);
            }

            double p = Convert.ToDouble(textBox1.Text);
            double v = Convert.ToDouble(textBox2.Text);
            double t = Convert.ToDouble(textBox3.Text);
            double s  = Math.Floor(v * t / p);
            label7.Text = s.ToString();
            label8.Text = a.Count.ToString();
            label9.Text = Math.Ceiling(Math.Log(s, a.Count)).ToString();
            Random rand = new Random();
            for (int i = 0; i < Convert.ToInt32(label9.Text); i++) textBox4.Text += a[rand.Next() % a.Count].ToString();
        }
    }
}
