﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
//using System.Drawing;
//using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;
using Facebook;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Dynamic;


namespace CMS
{
    public partial class Page7UI : Form
    {
        public static Excel.Workbook MyBook = null;
        public static Excel.Application MyApp = null;
        public static Excel.Worksheet MySheet = null;
        public static Excel.Application excelApp = null;
        public int lastRow = 0;
        
        public Page7UI()
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

            // Set Form's Transperancy 100 %
            this.Opacity = 0;

            // Start the Timer To Animate Form
            timer1.Enabled = true;
            label1.Text = Page2UI.name;
            textBox1.Text = Page2UI.email_id;
            Bitmap bitimg = new System.Drawing.Bitmap(this.pictureBox1.BackgroundImage);
            Graphics graphicimg = Graphics.FromImage(bitimg);

            graphicimg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            graphicimg.DrawString(label1.Text, new Font("Arial", 50, FontStyle.Bold), new SolidBrush(Color.DarkOrange)
              , new Point(2200, 1320));

            //graphicimg.ContentType = "image/jpeg";
            bitimg.Save(Application.StartupPath + @"/../../Certificate/" + label1.Text + ".jpg", ImageFormat.Jpeg);

            graphicimg.Dispose();
            bitimg.Dispose();


        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SaveExcel();
           Page8UI pg8 = new Page8UI();
            pg8.Show();
            //Thread.Sleep(1000);
            Cursor.Current = Cursors.Default;
            this.Visible = false;
            
            this.Close();
        }
        bool IsValidEmail(string email)
        {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(textBox1.Text) == false)
            {
                MessageBox.Show("Enter valid email id");
            }
            else
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();

                    message.From = new MailAddress("delledufun@gmail.com");
                    message.To.Add(new MailAddress(textBox1.Text));
                    message.To.Add(new MailAddress("delledufun@gmail.com"));
                    message.Subject = "DELL EDUFun – Appreciation Certificate";
                    message.Body = "Dear " + label1.Text + "," + System.Environment.NewLine + System.Environment.NewLine +
                        "Thank you for participating in Dell \"Fun with Education Program\" at Dell Exclusive Brand Store."
                        + System.Environment.NewLine + System.Environment.NewLine + "Please find attached your exclusive Dell-certificate of appreciation." +
                         System.Environment.NewLine + System.Environment.NewLine + "Thank You," + System.Environment.NewLine + "DELL EDUFun";
                    var filename =Application.StartupPath +  @"/../../Certificate/" + label1.Text + ".jpg";
                    Attachment attachment = new Attachment(filename);
                    attachment.Name = label1.Text + ".jpg";
                    message.Attachments.Add(attachment);

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("delledufun@gmail.com", "delledufun0501");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                    MessageBox.Show("Mail send");
                    MySheet.Cells[lastRow, 22] = "Y";
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("err: " + ex.Message);
                }
            }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 4;
        }
        public void SaveExcel()
        {

            // lastRow = 1;
            MySheet.Cells[lastRow, 21] = "Y";
            MySheet.Cells[lastRow, 20] = DateTime.Now.ToLongTimeString();
            excelApp.ActiveWorkbook.Save();
            excelApp.Workbooks.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }
            
        


        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Form1 fr1 = new Form1();
            fr1.Show();
            //System.Diagnostics.Process.Start("www.facebook.com");
            Cursor.Current = Cursors.Default;
        }

        }
       
}

     

 