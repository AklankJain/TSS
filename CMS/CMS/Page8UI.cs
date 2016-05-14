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
    public partial class Page8UI : Form
    {
        public Page8UI()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
            this.Visible = false;
            Page1UI p1 = new Page1UI();

            // Set Form's Transperancy 100 %
            this.Opacity = 100;

            p1.Opacity = 50;
            p1.Visible = true;
            //p1.Show();
            // Start the Timer To Animate Form
            timer1.Enabled = true;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            
            this.Opacity -= 0.07;
            p1.Opacity += .7;
            this.Opacity -= 0.07;

        }
    }
}
