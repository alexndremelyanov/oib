using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISFLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String f1(String a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++) sum += a[i];
            return (sum % 256).ToString();
        }
        private string f2(String a)
        {
            int sum = 0;
            int[] b = new int[a.Length]; b[0] = 155;
            for (int i = 1; i < a.Length; i++) b[i] = (13 * b[i - 1] + 19) % 256;
            for (int i = 0; i < a.Length; i++) b[i] ^= a[i];
            for (int i = 0; i < a.Length; i++) sum += b[i];
            return (sum % 256).ToString();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text, b = textBox6.Text, c= textBox9.Text, d = textBox12.Text;
            textBox2.Text = f1(a); textBox5.Text = f1(b); textBox8.Text = f1(c); textBox11.Text = f1(d);
            textBox3.Text = f2(a); textBox4.Text = f2(b); textBox7.Text = f2(c); textBox10.Text = f2(d);
        }
    }
}
