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
    public partial class Page3UI_c : Form
    {
        public Page3UI_c()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.Opacity = 0;
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Content3env c3e = new Content3env();
            c3e.Show();
            Cursor.Current = Cursors.Default;
            this.Visible = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Content3math c3m = new Content3math();
            c3m.Show();
            Cursor.Current = Cursors.Default;
            
            this.Visible = false;
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Content3science c3s = new Content3science();
           c3s.Show();
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
