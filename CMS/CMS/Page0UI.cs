using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CMS
{
    public partial class Page0UI : Form
    {
        public static Excel.Workbook MyBook = null;
        public static Excel.Application MyApp = null;
        public static Excel.Worksheet MySheet = null;
        public static Excel.Application excelApp = null;
        int lastRow = 0;

        public Page0UI()
        {
            

            InitializeComponent();
            string myPath = @"C:\Users\DELL\TSS\CMS\CMS\Excel\Try.xlsx";
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
            MySheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets[1]; // Explicit cast is not required here
            lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers");
                textBox3.Text = textBox3.Text.Remove((textBox3.Text.Length - 1), 1);
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Enter Store ID");
            else
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                    MessageBox.Show("Enter valid ISP");
                else
                {
                    if (string.IsNullOrEmpty(textBox4.Text))
                        MessageBox.Show("Enter address");
                    else
                    {
                        if (string.IsNullOrEmpty(textBox5.Text))
                            MessageBox.Show("Enter city");
                        else
                        {
                            if (string.IsNullOrEmpty(textBox3.Text))
                                MessageBox.Show("Enter contact no.");
                            else if (textBox3.TextLength < 10)
                            {
                                MessageBox.Show("Enter valid contact no.");
                            }
                            else
                            SaveExcel();
                            Page1UI pg1 = new Page1UI();
                            pg1.Show();
                            this.Visible = false;
                            //this.Close();

                       /*     var delay = Task.Run(async () =>
                            {

                                Page1UI pg1 = new Page1UI();
                                pg1.Show();
                                Thread.Sleep(1000);
                                this.Visible = false;
                            }*/
                        }
                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only alphabet");
                textBox5.Text = textBox5.Text.Remove((textBox5.Text.Length - 1), 1);
            }
        }
        public void SaveExcel()
            {
            
            lastRow += 1;
            MySheet.Cells[lastRow, 1] = lastRow - 1;
            MySheet.Cells[lastRow, 2] = textBox1.Text;
            MySheet.Cells[lastRow, 3] = textBox2.Text;
            MySheet.Cells[lastRow, 4] = textBox3.Text;
        //    MySheet.Cells[lastRow, 5] = textBox4.Text;
        //    MySheet.Cells[lastRow, 6] = textBox5.Text;
            excelApp.ActiveWorkbook.Save();
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
        public int getlastRow()
        {
            return lastRow;
        }
    }
}
