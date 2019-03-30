using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_008
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string firstValue = inputFirstValue.Text;
            string secondValue = inputSecondValue.Text;
            int valueOne = int.Parse(firstValue);
            int valueTwo = int.Parse(secondValue);

            int sum = valueOne + valueTwo;

            string result = "The result of your addition is " + sum;
            resultLabel.Text = result;
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            string firstValue = inputFirstValue.Text;
            string secondValue = inputSecondValue.Text;
            int valueOne = int.Parse(firstValue);
            int valueTwo = int.Parse(secondValue);

            int sub = valueOne - valueTwo;

            string result = "The result of your addition is " + sub;
            resultLabel.Text = result;
        }

        protected void multiplicationButton_Click(object sender, EventArgs e)
        {
            string firstValue = inputFirstValue.Text;
            string secondValue = inputSecondValue.Text;
            int valueOne = int.Parse(firstValue);
            int valueTwo = int.Parse(secondValue);

            int product = valueOne * valueTwo;

            string result = "The result of your addition is " + product;
            resultLabel.Text = result;
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            string firstValue = inputFirstValue.Text;
            string secondValue = inputSecondValue.Text;
            int valueOne = int.Parse(firstValue);
            int valueTwo = int.Parse(secondValue);

            int div = valueOne / valueTwo;

            string result = "The result of your addition is " + div;
            resultLabel.Text = result;
        }
    }
}