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
    public partial class Content3science : Form
    {
        public Content3science()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            axShockwaveFlash1.Movie = Application.StartupPath + @"\..\..\34\Science\1\main.swf";
            axShockwaveFlash1.Play();
        }

        private void Content3science_Load(object sender, EventArgs e)
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
