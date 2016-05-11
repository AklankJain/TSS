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
    public partial class Content5_2Math : Form
    {
        public Content5_2Math()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            axShockwaveFlash1.Movie = Application.StartupPath + @"\..\..\56\Math\2\main.swf";
            axShockwaveFlash1.Play();
        }
    }
}
