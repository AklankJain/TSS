using System;
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

namespace CMS
{
    public partial class Page7UI : Form
    {
        public Page7UI()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.pictureBox1.BackgroundImage.Save(@"D:/name.jpg", ImageFormat.Jpeg);
            //this.pictureBox1.BackgroundImage.Dispose();

           /* this.pictureBox1.Paint += new PaintEventHandler((sender, e) =>
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                string text = "Text";

                SizeF textSize = e.Graphics.MeasureString(text, Font);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (this.pictureBox1.Width / 2) - (textSize.Width / 2);
                locationToDraw.Y = (this.pictureBox1.Height / 2) - (textSize.Height / 2);

                e.Graphics.DrawString(text, Font, Brushes.Black, locationToDraw);
            });*/

            Bitmap bitimg = new System.Drawing.Bitmap(this.pictureBox1.BackgroundImage);
            Graphics graphicimg = Graphics.FromImage(bitimg);

            graphicimg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            graphicimg.DrawString(label1.Text , new Font("Arial" , 50 , FontStyle.Bold ), new SolidBrush(Color.DarkOrange)
              , new Point(2200 , 1320));

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
            this.Visible = false;
            Page8UI pg8 = new Page8UI();
            pg8.Show();
        }
       /*bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }*/
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
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();

                    message.From = new MailAddress("from@gmail.com");
                    message.To.Add(new MailAddress(textBox1.Text));
                    message.Subject = "Test";
                    message.Body = "Content";

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("from@gmail.com", "password");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                    MessageBox.Show("Mail send");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("err: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string imageUrl = Request.Form["image_url"];
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("link", imageUrl);
            data.Add("picture", imageUrl);
            FaceBookConnect.Post(Session["Code"].ToString(), "me/feed", data);
            ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Image has been shared.');", true);*/
        }

    }
}