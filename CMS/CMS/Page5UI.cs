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
using Excel = Microsoft.Office.Interop.Excel;

namespace CMS
{
    public partial class Page5UI : Form
    {
        public static Excel.Workbook MyBook = null;
        public static Excel.Application MyApp = null;
        public static Excel.Worksheet MySheet = null;
        public static Excel.Application excelApp = null;
        public int lastRow = 0;

        public Page5UI()
        {

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
            MySheet.Cells[lastRow, 15] = DateTime.Now.ToLongTimeString();
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.Opacity = 0;
            timer1.Enabled = true;
        }
        public int count = 0,count1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Size = new System.Drawing.Size(100, 109);
            //for (int i = 0; i < 100000000; i++) ;
            count = 1;
            if(count==1 && count1==1)
            {
                Cursor.Current = Cursors.WaitCursor;
                MySheet.Cells[lastRow, 18] = "Y";
                SaveExcel();
                Page6UI p6 = new Page6UI();
                p6.Show();
                //Thread.Sleep(1000);
                Cursor.Current = Cursors.Default;
                this.Visible = false;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Size = new System.Drawing.Size(100, 109);
           
            count = 1;
            if(count==1 && count1==1)
            {
                //for (int i = 0; i < 100000000; i++) ;
                Cursor.Current = Cursors.WaitCursor;
                MySheet.Cells[lastRow, 18] = "N";
                SaveExcel();              
                Page6UI p6 = new Page6UI();
                p6.Show();
                //Thread.Sleep(1000);
                Cursor.Current = Cursors.Default;
                this.Visible = false;
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Size = new System.Drawing.Size(100, 109);
            
            count1 = 1;
            
                
           
                if (count == 1 && count1 == 1)
                {
                 //   for (int i = 0; i < 100000000; i++) ;
                    Cursor.Current = Cursors.WaitCursor;
                    MySheet.Cells[lastRow, 19] = "Y";
                    SaveExcel();               
                    Page6UI p6 = new Page6UI();
                    p6.Show();
                    //Thread.Sleep(1000);
                    Cursor.Current = Cursors.Default;
                    this.Visible = false;
                    this.Close();
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.Size = new System.Drawing.Size(100, 109);
           
            
            count1 = 1;
            
            
            if(count==1 && count1==1)
            {
               // for (int i = 0; i < 100000000; i++) ;
                Cursor.Current = Cursors.WaitCursor;
                MySheet.Cells[lastRow, 19] = "N";
                SaveExcel();
                Page6UI p6 = new Page6UI();
                p6.Show();
                //Thread.Sleep(1000);
                Cursor.Current = Cursors.Default;
                this.Visible = false;
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 5;
        }
        public void SaveExcel()
        {
            
           // lastRow = 1;
            MySheet.Cells[lastRow, 16] = DateTime.Now.ToLongTimeString();
            excelApp.ActiveWorkbook.Save();
            excelApp.Workbooks.Close();
            excelApp.Quit();
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
    }
}
