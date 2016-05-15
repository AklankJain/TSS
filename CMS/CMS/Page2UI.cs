using System;
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
           // var MyApp = (Microsoft.Office.Interop.Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            //if (MyApp == null)
             //   MyApp = new Microsoft.Office.Interop.Excel.Application();
            //MyApp = new Microsoft.Office.Interop.Excel.Application();
            //MyApp.Visible = false;
           // MyBook = excelApp.Workbooks.Open(myPath);
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
                                SaveExcel();
                                Page3UI_c pg3c = new Page3UI_c();
                                pg3c.Show();
                                Thread.Sleep(2000);
                                this.Visible = false;
                            }
                            else if (comboBox1.SelectedItem == "5th and 6th")
                            {
                                SaveExcel();
                                Page3UI_b pg3b = new Page3UI_b();
                                pg3b.Show();
                                Thread.Sleep(2000);
                                this.Visible = false;
                            }
                            else if (comboBox1.SelectedItem == "7th and above")
                            {
                                SaveExcel();
                                Page3UI_a pg3a = new Page3UI_a();
                                pg3a.Show();
                                Thread.Sleep(2000);
                                this.Visible = false;
                            }
                        }
                    }   
                }
            }
            name = textBox1.Text;
            email_id = textBox3.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
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
            this.Opacity += 4;
        }

        private void Page2UI_Load(object sender, EventArgs e)
        {

        }
        public void SaveExcel()
        {
            string mac = GetMACAddress();
            
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