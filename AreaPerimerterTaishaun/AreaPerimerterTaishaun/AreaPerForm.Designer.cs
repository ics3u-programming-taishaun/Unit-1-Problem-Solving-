namespace AreaPerimerterTaishaun
{
    partial class frmAreaPer
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtAnsLength = new System.Windows.Forms.TextBox();
            this.txtAnsWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblAnsPer = new System.Windows.Forms.Label();
            this.lblAnsA = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAnsP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(45, 65);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(211, 46);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (m)";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(45, 206);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(192, 46);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width (m)";
            // 
            // txtAnsLength
            // 
            this.txtAnsLength.Location = new System.Drawing.Point(332, 88);
            this.txtAnsLength.Name = "txtAnsLength";
            this.txtAnsLength.Size = new System.Drawing.Size(100, 20);
            this.txtAnsLength.TabIndex = 2;
            this.txtAnsLength.TextChanged += new System.EventHandler(this.TxtAnsLength_TextChanged);
            // 
            // txtAnsWidth
            // 
            this.txtAnsWidth.Location = new System.Drawing.Point(332, 232);
            this.txtAnsWidth.Name = "txtAnsWidth";
            this.txtAnsWidth.Size = new System.Drawing.Size(100, 20);
            this.txtAnsWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(587, 151);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 40);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(134, 329);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(217, 31);
            this.lblPerimeter.TabIndex = 5;
            this.lblPerimeter.Text = "The perimeter is:";
            this.lblPerimeter.Click += new System.EventHandler(this.LblPerimeter_Click);
            // 
            // lblAnsPer
            // 
            this.lblAnsPer.AutoSize = true;
            this.lblAnsPer.Location = new System.Drawing.Point(404, 344);
            this.lblAnsPer.Name = "lblAnsPer";
            this.lblAnsPer.Size = new System.Drawing.Size(0, 13);
            this.lblAnsPer.TabIndex = 6;
            // 
            // lblAnsA
            // 
            this.lblAnsA.AutoSize = true;
            this.lblAnsA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsA.Location = new System.Drawing.Point(444, 421);
            this.lblAnsA.Name = "lblAnsA";
            this.lblAnsA.Size = new System.Drawing.Size(50, 24);
            this.lblAnsA.TabIndex = 7;
            this.lblAnsA.Text = "label";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(170, 403);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(167, 31);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "The Area is: ";
            // 
            // lblAnsP
            // 
            this.lblAnsP.AutoSize = true;
            this.lblAnsP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsP.Location = new System.Drawing.Point(444, 344);
            this.lblAnsP.Name = "lblAnsP";
            this.lblAnsP.Size = new System.Drawing.Size(60, 24);
            this.lblAnsP.TabIndex = 9;
            this.lblAnsP.Text = "label1";
            this.lblAnsP.Click += new System.EventHandler(this.LblAnsP_Click);
            // 
            // frmAreaPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnsP);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAnsA);
            this.Controls.Add(this.lblAnsPer);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAnsWidth);
            this.Controls.Add(this.txtAnsLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmAreaPer";
            this.Text = "Area Perimeter of Rectangle by Taishaun J";
            this.Load += new System.EventHandler(this.FrmAreaPer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtAnsLength;
        private System.Windows.Forms.TextBox txtAnsWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblAnsPer;
        private System.Windows.Forms.Label lblAnsA;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAnsP;
    }
}

