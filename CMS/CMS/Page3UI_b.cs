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
    public partial class Page3UI_b : Form
    {
        
        public Page3UI_b()
        {
           
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.Opacity = 0;
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Content5math c5m = new Content5math();
            c5m.Show();
            Cursor.Current = Cursors.Default;
          
            this.Visible = false;
          
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Content5Science c5s = new Content5Science();
            c5s.Show();
            Cursor.Current = Cursors.Default;
           
            this.Visible = false;
           
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Content5Env c5e = new Content5Env();
            c5e.Show();
            Cursor.Current = Cursors.Default;
           
            this.Visible = false;
           
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 4;
        }
    }
}
