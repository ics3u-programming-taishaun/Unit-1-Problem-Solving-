using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCost22Taishaun
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
            const double LARGE_PIZZA = 12.00;
            const double MEDIUM_PIZZA = 10.00;
            const double SMALL_PIZZA = 8.00;
            const double HST = 0.13;
            const double TOPPINGS = 0.80; 
        }

        private void PizzaCostForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double , costBeforeTax, costAfterTax;

            // convert the diameter to a double 
            diameter = 

            // calculate the Total cost and the Subtotal 
            lblAnsTotalC = 0.75 + 0.99 + 0.5(diameter) * 1.13;
            lblSubAns = 0.75 + 0.99 + 0.5(diameter) * 0.13;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
