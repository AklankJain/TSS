using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
namespace CMS
{
    public partial class Page2UI : Form
    {
        public static string name;
        public Page2UI()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            // Set Form's Transperancy 100 %
            this.Opacity = 0;

            // Start the Timer To Animate Form
            timer1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Enter your name");
            else
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                    MessageBox.Show("Enter school name");
                else
                {
                    if (comboBox1.SelectedItem == null)
                        MessageBox.Show("Enter your class");
                    else if (comboBox1.SelectedItem == "4th and below")
                    {

                        Page3UI_c pg3c = new Page3UI_c();
                        pg3c.Show();
                        Thread.Sleep(2000);
                        this.Visible = false;
                    }
                    else if (comboBox1.SelectedItem == "5th and 6th")
                    {

                        Page3UI_b pg3b = new Page3UI_b();
                        pg3b.Show();
                        Thread.Sleep(2000);
                        this.Visible = false;
                    }
                    else if (comboBox1.SelectedItem == "7th and above")
                    {

                        Page3UI_a pg3a = new Page3UI_a();
                        pg3a.Show();
                        Thread.Sleep(2000);
                        this.Visible = false;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(textBox3.Text))
                            MessageBox.Show("Enter email id");
                        else if (IsValidEmail(textBox3.Text) == false)
                        {
                            MessageBox.Show("Enter valid email id");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(textBox4.Text))
                                MessageBox.Show("Enter contact no.");
                            else if (textBox4.TextLength < 10)
                            {
                                MessageBox.Show("Enter valid contact no.");
                            }
                        }
                    }
                }
            }
            name = textBox1.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        bool IsValidEmail(string email)
        {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove((textBox4.Text.Length - 1), 1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 4;
        }

        private void Page2UI_Load(object sender, EventArgs e)
        {

        }
    }
}