using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private readonly WebService1 w = new WebService1();
        private int numA;
        private int numB;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void parseTexts()
        {
            try
            {
                numA = int.Parse(TextBox1.Text);
                numB = int.Parse(TextBox2.Text);
            }
            catch
            {
                Label3.Text = "Введите корректные значения!";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            this.parseTexts();
            Label2.Text = w.getSum(numA, numB).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.parseTexts();
            Label2.Text = w.getSubstraction(numA, numB).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            this.parseTexts();
            Label2.Text = w.getMultiplie(numA, numB).ToString();
        }
    }
}