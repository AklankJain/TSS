using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class Page3UI_c : Form
    {
        public Page3UI_c()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Content3env c3e = new Content3env();
            c3e.Show();
           
            this.Visible = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Content3math c3m = new Content3math();
            c3m.Show();
            
            this.Visible = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Content3science c3s = new Content3science();
            c3s.Show();
            this.Visible = false;
            this.Close();

            
        }
    }
}
