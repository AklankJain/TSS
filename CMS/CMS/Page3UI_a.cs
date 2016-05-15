﻿using System;
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
    public partial class Page3UI_a : Form
    {
        public Page3UI_a()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Content7Math c7m = new Content7Math();
            c7m.Show();
            Cursor.Current = Cursors.Default;
            this.Visible = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Content7Science c7s = new Content7Science();
            c7s.Show();
            Cursor.Current = Cursors.Default;
            this.Visible = false;
            this.Close();
        }
    }
}
