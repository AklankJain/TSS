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
    public partial class Content7Math : Form
    {
        public Content7Math()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            axShockwaveFlash1.Movie = Application.StartupPath + @"\..\..\78\Math\1\main.swf";
            axShockwaveFlash1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            axShockwaveFlash1.Dispose();
            Content7Math_2 c7m2 = new Content7Math_2();
            c7m2.Show();
           // Thread.Sleep(1000);
            Cursor.Current = Cursors.Default;
            this.Visible = false;
            this.Close();
        }
    }
}
