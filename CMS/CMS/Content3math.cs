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
    public partial class Content3math : Form
    {
        public Content3math()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            axShockwaveFlash1.Movie = Application.StartupPath + @"\..\..\34\Math\1\main.swf";
            axShockwaveFlash1.Play();
        }
      /*  private void button1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Stop();
            Page5UI pg5 = new Page5UI();
            pg5.Show();
            Thread.Sleep(1000);
            this.Visible = false;
        }
        */
        private void button1_Click_1(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            Page5UI pg5 = new Page5UI();
            pg5.Show();
            Thread.Sleep(1000);
            this.Visible = false;
        }

        
    }
}
