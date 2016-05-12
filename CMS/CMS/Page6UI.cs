using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Visible = false;
            Page7UI page7 = new Page7UI();
            page7.label1.Text = Page2UI.name;
            page7.Show();
        }
    }
}
