﻿using System;
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
    public partial class Content5Env : Form
    {
        public Content5Env()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            axShockwaveFlash1.Movie = Application.StartupPath + @"\..\..\56\Env\1\main.swf";
            axShockwaveFlash1.Play();
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }
    }
}
