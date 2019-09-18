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
            double length;
            double width;
            double area;
            double perimeter;

            length = double.Parse(txtAnsLength.Text);
            width = double.Parse(txtAnsWidth.Text);

            area = length * width;
            perimeter = 2 * length + 2 * width;

            this.lblAnsA.Text = Convert.ToString(area) + " squared meters";
            this.lblAnsP.Text = Convert.ToString(perimeter) + " meters";

            this.lblPerimeter.Show();
            this.lblArea.Show();
            this.lblAnsP.Show();
            this.lblAnsA.Show();
             

        }
    }
}
