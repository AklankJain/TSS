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
    public partial class Content3env : Form
    {
        public Content3env()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            axShockwaveFlash1.Movie = @"C:\DellEduFun\34\Env\1\main.swf";
            axShockwaveFlash1.Play();
        }
    }
}
