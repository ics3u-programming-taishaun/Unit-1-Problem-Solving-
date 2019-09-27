using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaPerimerterTaishaun
{
    public partial class frmAreaPer : Form
    {
        public frmAreaPer()
        {
            InitializeComponent();
        }

        private void LblPerimeter_Click(object sender, EventArgs e)
        {
            // Hide the following labels 
            this.lblPerimeter.Hide();
            this.lblArea.Hide();
            this.lblAnsA.Hide();
            this.lblAnsP.Hide();
        }

        private void TxtAnsLength_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void LblAnsP_Click(object sender, EventArgs e)
        {

        }

        private void FrmAreaPer_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare variables 
            double length;
            double width;
            double area;
            double perimeter;

            // convert the string from each text box to a double  
            length = double.Parse(txtAnsLength.Text);
            width = double.Parse(txtAnsWidth.Text);

            // calculate the area and the perimerter 
            area = length * width;
            perimeter = 2 * length + 2 * width;

            // insert the area and perimeter
            this.lblAnsA.Text = Convert.ToString(area) + " squared meters";
            this.lblAnsP.Text = Convert.ToString(perimeter) + " meters";

            // display the perim
            this.lblPerimeter.Show();
            this.lblArea.Show();
            this.lblAnsP.Show();
            this.lblAnsA.Show();
             

        }
    }
}
