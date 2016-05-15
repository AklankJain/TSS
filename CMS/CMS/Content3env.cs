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
    public partial class Content3env : Form
    {
        public Content3env()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            axShockwaveFlash1.Movie = Application.StartupPath + @"\..\..\34\Env\1\main.swf";
            axShockwaveFlash1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //axShockwaveFlash1.Movie = Application.StartupPath + @"\..\..\34\Env\1\main.swf";
            //axShockwaveFlash1.StopPlay();
            axShockwaveFlash1.Dispose();
            //axShockwaveFlash1.StopPlay();
            Page5UI pg5 = new Page5UI();
            pg5.Show();
            //Thread.Sleep(1000);
            this.Visible = false;
            this.Close();
            //axShockwaveFlash1.StopPlay();
            //axShockwaveFlash1.Stop();
        }
    }
}
