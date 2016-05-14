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
    public partial class Content5Science_2 : Form
    {
        public Content5Science_2()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            axShockwaveFlash1.Movie = Application.StartupPath + @"\..\..\56\Science\2\main.swf";
            axShockwaveFlash1.Play();
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            Page5UI pg5 = new Page5UI();
            pg5.Show();
            Thread.Sleep(1000);
            this.Visible = false;
        }
    }
}
