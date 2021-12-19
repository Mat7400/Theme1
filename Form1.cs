using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Theme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text = textBox1.Text;
            double b = Convert.ToDouble(text);
            int a = (int)b;
            //Округление
            int aa = (int)Math.Round(b);
            double c = Math.Sqrt(b);
            string ab = "string";
            MessageBox.Show(b.ToString() + " intR=" + aa.ToString()+" koren="+c);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            HttpWebResponse req = (HttpWebResponse) WebRequest.Create("https://yandex.ru").GetResponse();

            string html = new StreamReader(req.GetResponseStream()).ReadToEnd();
            req.Close();
            MessageBox.Show(html);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            double b = Convert.ToDouble(text);
            
            int a = (int)b;
            //Округление
            int aa = (int)Math.Round(b);
            double c = Math.Sqrt(b);
            string ab = "test";
            int res = Adding(a, aa);
            string str = AddingS(ab, ab);
            MessageBox.Show(str);
            
        }
        private int Adding(object a, object b)
        {
            return (int)a + (int)b;
        }
        private string AddingS(object a, object b)
        {
            return (string)a + " - " + (string)b;
        }
    }
}
