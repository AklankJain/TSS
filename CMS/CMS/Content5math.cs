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
    public partial class Content5math : Form
    {
        public Content5math()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            axShockwaveFlash1.Movie = Application.StartupPath + @"\..\..\56\Math\1\main.swf";
            axShockwaveFlash1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Content5_2Math c52m = new Content5_2Math();
            c52m.Show();
            Thread.Sleep(1000);
            this.Visible = false;
        }
    }
}
