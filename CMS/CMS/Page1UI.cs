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
    public partial class Page1UI : Form
    {
        
        public Page1UI()
        {

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1UI));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
          
           
            
            
           // this.pictureBox1= this.
            //pictureBox1.Image = Image.FromFile(Application.StartupPath + @"/../../startpage.gif");
        }

        private void  button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Page2UI pg2 = new Page2UI();
           pg2.Show();
            //for (int i = 0; i < 80000000; i++) ;
            Cursor.Current = Cursors.Default;
            this.Visible = false;
           
            this.Close();
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Page2UI pg2 = new Page2UI();
            pg2.Show();
            for (int i = 0; i < 80000000; i++) ;
            Cursor.Current = Cursors.Default;
            this.Visible = false;
           
            //this.Close();
        }
       

          
        
    }
}
