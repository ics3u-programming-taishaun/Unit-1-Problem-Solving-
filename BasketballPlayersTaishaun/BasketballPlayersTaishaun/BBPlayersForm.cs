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

        private void MnilukaD_Click(object sender, EventArgs e)
        {
            this.lblTeam.Text = "Dallas Mavericks";
            this.lblPlayer.Text = "Luka Doncic";
        }
    }
}
