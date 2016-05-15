using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CMS
{


    public partial class Page6UI : Form
    {
        public static Excel.Workbook MyBook = null;
        public static Excel.Application MyApp = null;
        public static Excel.Worksheet MySheet = null;
        public static Excel.Application excelApp = null;
        public int lastRow = 0;

        public Page6UI()
        {
            string myPath = Application.StartupPath + @"\..\..\Excel\Try.xlsx";
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
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        private void Page6UI_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            SaveExcel();
            Cursor.Current = Cursors.WaitCursor;
            Page7UI page7 = new Page7UI();
            //page7.label1.Text = Page2UI.name;
            page7.Show();
            for (int i = 0; i < 100000000; i++) ;
                Cursor.Current = Cursors.Default;
            this.Visible = false;
        }
        public void SaveExcel()
        {
            
           // lastRow = 1;
            MySheet.Cells[lastRow, 17] = DateTime.Now.ToLongTimeString();
            excelApp.ActiveWorkbook.Save();
            excelApp.Workbooks.Close();
            excelApp.Quit();
        }
    }
}
