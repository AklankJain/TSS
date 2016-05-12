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
            // Set Form's Transperancy 100 %
            this.Opacity = 100;

            // Start the Timer To Animate Form
            timer1.Enabled = true;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            
            this.Opacity -= 0.07;
            

        }
    }
}
