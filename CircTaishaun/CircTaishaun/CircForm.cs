/*
 * Created by: Taishaun Johnson
 * Created on: Sept,30,2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Top Down Design & Flow chart
 * This program Displays the circumference of a circle when given the radius
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircTaishaun
{
    public partial class frmCirc : Form
    {
        public frmCirc()
        {
            InitializeComponent();
        }

        private void LblStateCirc_Click(object sender, EventArgs e)
        {
            this.lblStateCirc.Hide();
            this.lblAns.Hide();

        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declaring constant
            const double PI = 3.14;

            // declaring variable 
            double radius, circumference;

            // Convert the circumference to a string 
            radius = double.Parse(txtRadius.Text);

            // calculate the radius of the circle 
            circumference = 2 * 3.14 * radius;

            this.lblAns.Text = Convert.ToString(circumference) + "cm";

            // Displays the circumference is.
            this.lblStateCirc.Show();
            this.lblAns.Show();



            
        }
     
    }
}
