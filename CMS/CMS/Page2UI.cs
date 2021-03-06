﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using System.Management;
using System.Net;
using System.Net.NetworkInformation; 


namespace CMS
{


    public partial class Page2UI : Form
    {

        public static Excel.Workbook MyBook = null;
        public static Excel.Application MyApp = null;
        public static Excel.Worksheet MySheet = null;
        public static Excel.Application excelApp = null;
        public int lastRow = 0;
        
        

        public static string name, email_id;

        public Page2UI()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            // Set Form's Transperancy 100 %
            string myPath = Application.StartupPath + @"\..\..\Excel\Try.xlsx";
            this.Opacity = 0;
            string anotherPath = "C:\\edufun\\secondary.xlsx"
            anotherApp = new Excel.Application();
            Excel.Workbook wa;
            try
            {
                wa = anotherApp.Workbooks[System.IO.Path.GetFileName(anotherPath)];
            }
            catch
            {
                wa = anotherApp.Workbooks.Open(anotherPath);
            }
            ASheet = (Microsoft.Office.Interop.Excel.Worksheet)wa.Sheets[1];

           // var excelApp = (Excel.Application) System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            //if(excelApp==null)
             //   excelApp = new Excel.Application();
            // Start the Timer To Animate Form
            excelApp = new Excel.Application();
            Excel.Workbook wb;
            try
            {
             wb = excelApp.Workbooks[System.IO.Path.GetFileName(myPath)];
            }
            catch
            {
                wb = excelApp.Workbooks.Open(myPath);
            }
            timer1.Enabled = true;
            MySheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets[1]; // Explicit cast is not required here
            lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Enter your name");
            else
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                    MessageBox.Show("Enter school name");
                else
                {
                    if (string.IsNullOrEmpty(textBox3.Text))
                        MessageBox.Show("Enter email id");
                    else if (IsValidEmail(textBox3.Text) == false)
                    {
                        MessageBox.Show("Enter valid email id");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(textBox4.Text))
                            MessageBox.Show("Enter contact no.");
                        else if (textBox4.TextLength < 10)
                        {
                            MessageBox.Show("Enter valid contact no.");
                        }
                        else
                        {
                            if (comboBox1.SelectedItem == null)
                                MessageBox.Show("Enter your class");
                            else if (comboBox1.SelectedItem == "4th and below")
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                SaveExcel();                              
                                Page3UI_c pg3c = new Page3UI_c();
                                pg3c.Show();
                                name = textBox1.Text;
                                email_id = textBox3.Text;
                                Cursor.Current = Cursors.Default;
                                this.Visible = false;
                                this.Close();
                            }
                            else if (comboBox1.SelectedItem == "5th and 6th")
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                SaveExcel();
                                Page3UI_b pg3b = new Page3UI_b();
                                pg3b.Show();
                                name = textBox1.Text;
                                email_id = textBox3.Text;
                                Cursor.Current = Cursors.Default;
                                this.Visible = false;
                                this.Close();
                            }
                            else if (comboBox1.SelectedItem == "7th and above")
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                SaveExcel();                              
                                Page3UI_a pg3a = new Page3UI_a();
                                pg3a.Show();
                                name = textBox1.Text;
                                email_id = textBox3.Text;
                                Cursor.Current = Cursors.Default;
                                this.Visible = false;
                                this.Close();
                            }
                        }
                    }
                }
            }
            //button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only alphabet");
                textBox1.Text = textBox1.Text.Remove((textBox1.Text.Length - 1), 1);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only alphabet");
                textBox2.Text = textBox2.Text.Remove((textBox2.Text.Length - 1), 1);
            }
        }
        bool IsValidEmail(string email)
        {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove((textBox4.Text.Length - 1), 1);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .5;
        }

        private void Page2UI_Load(object sender, EventArgs e)
        {

        }
        public void SaveExcel()
        {
            string mac = GetMACAddress();
           // MySheet.Cells[lastRow , 2] = ASheet.Cells[3,2];
            MySheet.Cells[lastRow , 3] = ASheet.Cells[3,3];
            MySheet.Cells[lastRow , 4] = ASheet.Cells[3,4];
            MySheet.Cells[lastRow , 5] = ASheet.Cells[3,5];
            MySheet.Cells[lastRow , 6] = ASheet.Cells[3,6];
            MySheet.Cells[lastRow , 7] = ASheet.Cells[3,7];
            MySheet.Cells[lastRow, 8] = textBox1.Text;
            MySheet.Cells[lastRow, 9] = textBox4.Text;
            MySheet.Cells[lastRow, 10] = comboBox1.Text;
            MySheet.Cells[lastRow, 11] = textBox2.Text;
            MySheet.Cells[lastRow, 12] = textBox3.Text;
            MySheet.Cells[lastRow, 7] = mac;
            MySheet.Cells[lastRow, 13] = DateTime.Now.ToLongTimeString();
          //  MySheet.Cells[lastRow, 15] = DateTime.Now.ToLongTimeString();
          //  MySheet.Cells[lastRow, 16] = DateTime.Now.ToLongTimeString();
            excelApp.ActiveWorkbook.Save();
            excelApp.Workbooks.Close();
            excelApp.Quit();
            anotherApp.ActiveWorkbook.Save();
            anotherApp.Workbooks.Close();
            anotherApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }
        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            } return sMacAddress;
        }
    }
}