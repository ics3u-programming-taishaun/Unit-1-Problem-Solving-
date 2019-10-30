namespace PizzaCost22Taishaun
{
    partial class frmPizzaCost
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
            this.lblSmallPizza = new System.Windows.Forms.Label();
            this.txtNumDia = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalC = new System.Windows.Forms.Label();
            this.lblAnsTotalC = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblSubAns = new System.Windows.Forms.Label();
            this.lblMediumPizza = new System.Windows.Forms.Label();
            this.lblLargePizza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSmallPizza
            // 
            this.lblSmallPizza.AutoSize = true;
            this.lblSmallPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallPizza.Location = new System.Drawing.Point(97, 84);
            this.lblSmallPizza.Name = "lblSmallPizza";
            this.lblSmallPizza.Size = new System.Drawing.Size(147, 26);
            this.lblSmallPizza.TabIndex = 0;
            this.lblSmallPizza.Text = "Small Pizza =";
            // 
            // txtNumDia
            // 
            this.txtNumDia.Location = new System.Drawing.Point(418, 126);
            this.txtNumDia.Name = "txtNumDia";
            this.txtNumDia.Size = new System.Drawing.Size(100, 20);
            this.txtNumDia.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(607, 96);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(105, 50);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblTotalC
            // 
            this.lblTotalC.AutoSize = true;
            this.lblTotalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalC.Location = new System.Drawing.Point(224, 291);
            this.lblTotalC.Name = "lblTotalC";
            this.lblTotalC.Size = new System.Drawing.Size(129, 26);
            this.lblTotalC.TabIndex = 3;
            this.lblTotalC.Text = "Total Cost =";
            // 
            // lblAnsTotalC
            // 
            this.lblAnsTotalC.AutoSize = true;
            this.lblAnsTotalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsTotalC.Location = new System.Drawing.Point(487, 291);
            this.lblAnsTotalC.Name = "lblAnsTotalC";
            this.lblAnsTotalC.Size = new System.Drawing.Size(74, 24);
            this.lblAnsTotalC.TabIndex = 4;
            this.lblAnsTotalC.Text = "Answer";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(224, 382);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(117, 26);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "SubTotal =";
            // 
            // lblSubAns
            // 
            this.lblSubAns.AutoSize = true;
            this.lblSubAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubAns.Location = new System.Drawing.Point(499, 384);
            this.lblSubAns.Name = "lblSubAns";
            this.lblSubAns.Size = new System.Drawing.Size(74, 24);
            this.lblSubAns.TabIndex = 6;
            this.lblSubAns.Text = "Answer";
            // 
            // lblMediumPizza
            // 
            this.lblMediumPizza.AutoSize = true;
            this.lblMediumPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediumPizza.Location = new System.Drawing.Point(102, 132);
            this.lblMediumPizza.Name = "lblMediumPizza";
            this.lblMediumPizza.Size = new System.Drawing.Size(175, 26);
            this.lblMediumPizza.TabIndex = 7;
            this.lblMediumPizza.Text = "Medium Pizza = ";
            // 
            // lblLargePizza
            // 
            this.lblLargePizza.AutoSize = true;
            this.lblLargePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargePizza.Location = new System.Drawing.Point(102, 181);
            this.lblLargePizza.Name = "lblLargePizza";
            this.lblLargePizza.Size = new System.Drawing.Size(146, 26);
            this.lblLargePizza.TabIndex = 8;
            this.lblLargePizza.Text = "Large Pizza =";
            this.lblLargePizza.Click += new System.EventHandler(this.Label1_Click);
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLargePizza);
            this.Controls.Add(this.lblMediumPizza);
            this.Controls.Add(this.lblSubAns);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblAnsTotalC);
            this.Controls.Add(this.lblTotalC);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumDia);
            this.Controls.Add(this.lblSmallPizza);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost by Taishaun Johnson";
            this.Load += new System.EventHandler(this.PizzaCostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSmallPizza;
        private System.Windows.Forms.TextBox txtNumDia;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalC;
        private System.Windows.Forms.Label lblAnsTotalC;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblSubAns;
        private System.Windows.Forms.Label lblMediumPizza;
        private System.Windows.Forms.Label lblLargePizza;
    }
}

