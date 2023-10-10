using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoniroSteam
{
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
        }
        private void btny_Click(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //string html = "<html><head>"; html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>"; html += "<center><iframe id='video' src='https://www.youtube.com/embed/{0}?autoplay={1}' width='{2}' height='{3}' frameborder='0' allowfullscreen='true'></iframe></center>"; html += "</body></html>";
           // string txtUrl = "https://www.youtube.com/";
            //webBrowser1.DocumentText = string.Format(html, txtUrl.Trim().Split('=')[1], "1", 560, 315);
        }
    }
}
