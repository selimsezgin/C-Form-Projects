using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteElmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" || textBox1.Text == "Admin" && textBox2.Text == "admin087")
            {
                Form2 emlakkayit = new Form2();
                emlakkayit.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar.ToString() == "*")
            {
                textBox2.PasswordChar = char.Parse("\0");
            }
            else
            {
                textBox2.PasswordChar = char.Parse("*");
            }
        }
    }
}
