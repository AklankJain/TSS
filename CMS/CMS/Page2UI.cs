using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    if (string.IsNullOrEmpty(textBox3.Text))
                        MessageBox.Show("Enter email id");
                    else
                    {
                        if (string.IsNullOrEmpty(textBox4.Text))
                            MessageBox.Show("Enter contact no.");
                        else
                        {
                            if (comboBox1.SelectedItem == null)
                                MessageBox.Show("Select class");
                            else
                            {
                                if (comboBox1.SelectedItem == "4th and below")
                                {
                                    this.Visible = false;
                                    Page3UI_a pg3a = new Page3UI_a();
                                    pg3a.Show();
                                }
                                if (comboBox1.SelectedItem == "5th and 6th")
                                {
                                    this.Visible = false;
                                    Page3UI_b pg3b = new Page3UI_b();
                                    pg3b.Show();
                                }
                                if (comboBox1.SelectedItem == "7th and above")
                                {
                                    this.Visible = false;
                                    Page3UI_c pg3c = new Page3UI_c();
                                    pg3c.Show();
                                }

                            }
                        }
                    }

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            name = textBox1.Text;
            Page3UI_a pg3a = new Page3UI_a();
            pg3a.Show();
        }
    }
}
