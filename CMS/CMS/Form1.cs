using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Dynamic;
using MSHTML;
namespace CMS
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            long app = 628293357321818;
            string redirect = "https://www.facebook.com/connect/login_success.html";


            /* HtmlElement headElement = webBrowser1.Document.GetElementsByTagName("head")[0];
             HtmlElement scriptElement = webBrowser1.Document.CreateElement("script");
             IHTMLScriptElement element = (IHTMLScriptElement)scriptElement.DomElement;
             element.text = "function sayHello() { alert('hello') }";
             headElement.AppendChild(scriptElement);
             webBrowser1.Document.InvokeScript("sayHello");*/



            //         var request = (HttpWebRequest)WebRequest.Create("http://www.example.com/recepticle.aspx");

            //           var response = (HttpWebResponse)request.GetResponse();

            //         var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            /* string sURL;
             sURL =  "https://graph.facebook.com/v2.6/me?access_token=628293357321818";
             WebRequest wrGETURL;
             wrGETURL = WebRequest.Create(sURL);
             Stream objStream;
             objStream = wrGETURL.GetResponse().GetResponseStream();
             */


            /*    dynamic parameters = new ExpandoObject();
                parameters.title = "test title";
                parameters.message = "test message";

                string acccessToken = fb.AccessToken;
                FacebookClient appp = new FacebookClient(acccessToken);
                try
                {
                    var postId = fb.Post( fb.AccessToken+ "/feed", parameters);
                }
                catch (FacebookOAuthException ex)
                { //handle oauth exception } catch (FacebookApiException ex) { //handle facebook exception
                }*/
            //   var postId = fb.Post(fb.AccessToken + "/feed", "hello");
            /*string str = "<script></script>";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", str, false);
           
             var fb = new FacebookClient();
             dynamic result = fb.Get("oauth/access_token", new
             {
                 client_id = "628293357321818",
                 client_secret = "04de42c5c7216b9225be670ec74d25a9",
                 grant_type = "client_credentials"
             });
             //fb.AccessToken = result.access_token;
             string save = "EAAI7bfJgvloBAAVyQp1Cow5pig2JuLKtwEuZCk5sSaU1NxkNCPfOdtTTYvvUEL6CjLX7Acl43rVJI0qpZA5IlvTwp9GgjX6evc43x1AYmw9amj3Lusz1rNhdifd57Bh8YzfWkZCEsccjZB8ZCiSGB9uZCfBSt1ZAGAxzOkSIVOlZCAZDZD";
             webBrowser1.Navigate("https://graph.facebook.com/v2.6/me?access_token=EAAI7bfJgvloBAAVyQp1Cow5pig2JuLKtwEuZCk5sSaU1NxkNCPfOdtTTYvvUEL6CjLX7Acl43rVJI0qpZA5IlvTwp9GgjX6evc43x1AYmw9amj3Lusz1rNhdifd57Bh8YzfWkZCEsccjZB8ZCiSGB9uZCfBSt1ZAGAxzOkSIVOlZCAZDZD");
             Console.Write(fb.AccessToken);
         }
         private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
         {

         }*/
        }
    }
}
