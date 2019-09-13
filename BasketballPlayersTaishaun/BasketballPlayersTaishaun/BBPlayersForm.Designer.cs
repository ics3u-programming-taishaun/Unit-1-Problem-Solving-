namespace BasketballPlayersTaishaun
{
    partial class frmballPlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbPlayers = new System.Windows.Forms.GroupBox();
            this.mnuBallPlayers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnibasketballPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnilukaD = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTraeY = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKlayT = new System.Windows.Forms.ToolStripMenuItem();
            this.mniJimmyB = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.grbPlayers.SuspendLayout();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlayers
            // 
            this.grbPlayers.Controls.Add(this.lblPlayer);
            this.grbPlayers.Controls.Add(this.lblTeam);
            this.grbPlayers.Location = new System.Drawing.Point(65, 43);
            this.grbPlayers.Name = "grbPlayers";
            this.grbPlayers.Size = new System.Drawing.Size(588, 372);
            this.grbPlayers.TabIndex = 0;
            this.grbPlayers.TabStop = false;
            this.grbPlayers.Text = "groupBox1";
            // 
            // mnuBallPlayers
            // 
            this.mnuBallPlayers.Name = "mnuBallPlayers";
            this.mnuBallPlayers.Size = new System.Drawing.Size(61, 4);
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnibasketballPlayers});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(800, 24);
            this.mnu.TabIndex = 2;
            // 
            // mnibasketballPlayers
            // 
            this.mnibasketballPlayers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnilukaD,
            this.mniTraeY,
            this.mniKlayT,
            this.mniJimmyB});
            this.mnibasketballPlayers.Name = "mnibasketballPlayers";
            this.mnibasketballPlayers.Size = new System.Drawing.Size(165, 20);
            this.mnibasketballPlayers.Text = "Basketball Players and team";
            // 
            // mnilukaD
            // 
            this.mnilukaD.Name = "mnilukaD";
            this.mnilukaD.Size = new System.Drawing.Size(180, 22);
            this.mnilukaD.Text = "Luka Doncic";
            this.mnilukaD.Click += new System.EventHandler(this.MnilukaD_Click);
            // 
            // mniTraeY
            // 
            this.mniTraeY.Name = "mniTraeY";
            this.mniTraeY.Size = new System.Drawing.Size(180, 22);
            this.mniTraeY.Text = "Trae Young";
            // 
            // mniKlayT
            // 
            this.mniKlayT.Name = "mniKlayT";
            this.mniKlayT.Size = new System.Drawing.Size(180, 22);
            this.mniKlayT.Text = "Klay Thompson";
            // 
            // mniJimmyB
            // 
            this.mniJimmyB.Name = "mniJimmyB";
            this.mniJimmyB.Size = new System.Drawing.Size(180, 22);
            this.mniJimmyB.Text = "Jimmy Butler";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(116, 46);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(173, 63);
            this.lblTeam.TabIndex = 0;
            this.lblTeam.Text = "label1";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(192, 215);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(97, 35);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "label2";
            this.lblPlayer.Click += new System.EventHandler(this.Label2_Click);
            // 
            // frmballPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnu);
            this.Controls.Add(this.grbPlayers);
            this.MainMenuStrip = this.mnu;
            this.Name = "frmballPlayers";
            this.Text = "Basketball players and team";
            this.Load += new System.EventHandler(this.BBPlayersForm_Load);
            this.grbPlayers.ResumeLayout(false);
            this.grbPlayers.PerformLayout();
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlayers;
        private System.Windows.Forms.ContextMenuStrip mnuBallPlayers;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnibasketballPlayers;
        private System.Windows.Forms.ToolStripMenuItem mnilukaD;
        private System.Windows.Forms.ToolStripMenuItem mniTraeY;
        private System.Windows.Forms.ToolStripMenuItem mniKlayT;
        private System.Windows.Forms.ToolStripMenuItem mniJimmyB;
    }
}

