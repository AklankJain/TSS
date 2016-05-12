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
    public partial class Page5UI : Form
    {
        public Page5UI()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        public int count = 0,count1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count = 1;
            if(count==1 && count1==1)
            {
                this.Visible=false;
                Page6UI p6 = new Page6UI();
                p6.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 1;
            if(count==1 && count1==1)
            {
                this.Visible=false;
                Page6UI p6 = new Page6UI();
                p6.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count1 = 1;
            if(count==1 && count1==1)
            {
                this.Visible=false;
                Page6UI p6 = new Page6UI();
                p6.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count1 = 1;
            if(count==1 && count1==1)
            {
                this.Visible=false;
                Page6UI p6 = new Page6UI();
                p6.Show();
            }
        }
    }
}
