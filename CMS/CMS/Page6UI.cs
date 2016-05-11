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
    public partial class Page6UI : Form
    {
        public Page6UI()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Page6UI_Load(object sender, EventArgs e)
        {

        }

        private Page2UI page2 = new Page2UI();
        private Page7UI page7 = new Page7UI();
        private void button1_Click(object sender, EventArgs e)
        {
            page7.label1.Text = page2.textBox1.Text;
        }
    }
}
