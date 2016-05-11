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
    public partial class Content7Math_2 : Form
    {
        public Content7Math_2()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            axShockwaveFlash1.Movie = Application.StartupPath + @"\..\..\78\Math\2\main.swf";
            axShockwaveFlash1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Page5UI pg5 = new Page5UI();
            pg5.Show();
        }
    }
}
