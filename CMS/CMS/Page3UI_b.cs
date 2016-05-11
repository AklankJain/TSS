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
    public partial class Page3UI_b : Form
    {
        public Page3UI_b()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Content5math c5m = new Content5math();
            c5m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Content5Science c5s = new Content5Science();
            c5s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Content5Env c5e = new Content5Env();
            c5e.Show();
        }
    }
}
