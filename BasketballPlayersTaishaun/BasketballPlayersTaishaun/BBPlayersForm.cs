/*
 * Created by: Taishaun Johnson
 * Created on: sept.13, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Basketball Players 
 * This program displays team name, star player and team logo.
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

namespace BasketballPlayersTaishaun
{
    public partial class frmballPlayers : Form
    {
        public frmballPlayers()
        {
            InitializeComponent();
        }

        private void BBPlayersForm_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        // Add team name Dallas and star player Doncic and show team logo.
        private void MnilukaD_Click(object sender, EventArgs e)
        {
            this.lblTeam.Text = "Dallas Mavericks";
            this.lblPlayer.Text = "Luka Doncic";
            picGSW.Image = (Properties.Resources.mavericks_logo_dallas_sports_fanatic);
        }

        // Add team name Atlanta and star player Young and show team logo.
        private void MniTraeY_Click(object sender, EventArgs e)
        {
            this.lblTeam.Text = "Atlanta Hawks";
            this.lblPlayer.Text = "Trae Young";
            picGSW.Image = (Properties.Resources.Atlanta);
               
        }

        // Add team name Miami and star player Butler and show team logo.
        private void MniJimmyB_Click(object sender, EventArgs e)
        {
            this.lblTeam.Text = "Miami Heat";
            this.lblPlayer.Text = "Jimmy Butler";
            picGSW.Image = (Properties.Resources.black_miami_heat_logo);

        }

        // Add team name GSW and star player Thompson and show team logo.
        private void MniKlayT_Click_1(object sender, EventArgs e)
        {
            this.lblTeam.Text = "GS Warriors";
            this.lblPlayer.Text = "Klay Thompson";
            picGSW.Image = (Properties.Resources.warriors);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
