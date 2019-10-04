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
        }

        private void PizzaCostForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double diameter, costBeforeTax, costAfterTax;

            // convert the diameter to a double 
            diameter = 

            // calculate the Total cost and the Subtotal 
            lblAnsTotalC = 0.75 + 0.99 + 0.5(diameter) * 1.13;
            lblSubAns = 0.75 + 0.99 + 0.5(diameter) * 0.13;
        }
    }
}
