namespace Holloman_Morgage_Project
{
    partial class frmMain
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
            this.txtPrinciple = new System.Windows.Forms.TextBox();
            this.lblPrinciple = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.rad30Y = new System.Windows.Forms.RadioButton();
            this.rad15Y = new System.Windows.Forms.RadioButton();
            this.lblIntEx = new System.Windows.Forms.Label();
            this.cboInterest = new System.Windows.Forms.ComboBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrinciple
            // 
            this.txtPrinciple.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrinciple.Location = new System.Drawing.Point(237, 15);
            this.txtPrinciple.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrinciple.Name = "txtPrinciple";
            this.txtPrinciple.Size = new System.Drawing.Size(292, 34);
            this.txtPrinciple.TabIndex = 1;
            // 
            // lblPrinciple
            // 
            this.lblPrinciple.AutoSize = true;
            this.lblPrinciple.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinciple.Location = new System.Drawing.Point(31, 15);
            this.lblPrinciple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrinciple.Name = "lblPrinciple";
            this.lblPrinciple.Size = new System.Drawing.Size(149, 36);
            this.lblPrinciple.TabIndex = 7;
            this.lblPrinciple.Text = "Principle:";
            this.lblPrinciple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(237, 186);
            this.txtOther.Margin = new System.Windows.Forms.Padding(4);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(217, 34);
            this.txtOther.TabIndex = 3;
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOther.Location = new System.Drawing.Point(16, 187);
            this.radOther.Margin = new System.Windows.Forms.Padding(4);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(112, 33);
            this.radOther.TabIndex = 3;
            this.radOther.TabStop = true;
            this.radOther.Text = "Other...";
            this.radOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radOther.UseVisualStyleBackColor = true;
            this.radOther.CheckedChanged += new System.EventHandler(this.radOther_CheckedChanged);
            // 
            // rad30Y
            // 
            this.rad30Y.AutoSize = true;
            this.rad30Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad30Y.Location = new System.Drawing.Point(16, 144);
            this.rad30Y.Margin = new System.Windows.Forms.Padding(4);
            this.rad30Y.Name = "rad30Y";
            this.rad30Y.Size = new System.Drawing.Size(101, 29);
            this.rad30Y.TabIndex = 0;
            this.rad30Y.TabStop = true;
            this.rad30Y.Text = "30 Year";
            this.rad30Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rad30Y.UseVisualStyleBackColor = true;
            // 
            // rad15Y
            // 
            this.rad15Y.AutoSize = true;
            this.rad15Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad15Y.Location = new System.Drawing.Point(16, 101);
            this.rad15Y.Margin = new System.Windows.Forms.Padding(4);
            this.rad15Y.Name = "rad15Y";
            this.rad15Y.Size = new System.Drawing.Size(101, 29);
            this.rad15Y.TabIndex = 2;
            this.rad15Y.TabStop = true;
            this.rad15Y.Text = "15 Year";
            this.rad15Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rad15Y.UseVisualStyleBackColor = true;
            // 
            // lblIntEx
            // 
            this.lblIntEx.AutoSize = true;
            this.lblIntEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntEx.Location = new System.Drawing.Point(351, 255);
            this.lblIntEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntEx.Name = "lblIntEx";
            this.lblIntEx.Size = new System.Drawing.Size(47, 38);
            this.lblIntEx.TabIndex = 10;
            this.lblIntEx.Text = "%";
            this.lblIntEx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboInterest
            // 
            this.cboInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInterest.FormattingEnabled = true;
            this.cboInterest.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.cboInterest.Location = new System.Drawing.Point(237, 255);
            this.cboInterest.Margin = new System.Windows.Forms.Padding(4);
            this.cboInterest.Name = "cboInterest";
            this.cboInterest.Size = new System.Drawing.Size(104, 37);
            this.cboInterest.TabIndex = 1;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(29, 251);
            this.lblInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(143, 38);
            this.lblInterest.TabIndex = 9;
            this.lblInterest.Text = "Interest:";
            this.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.DarkGray;
            this.lblYear.Location = new System.Drawing.Point(3, 66);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(148, 25);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Term of Years";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(75, 308);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(381, 53);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(117, 380);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 29);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.Location = new System.Drawing.Point(200, 415);
            this.lblTotalNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(0, 32);
            this.lblTotalNum.TabIndex = 17;
            this.lblTotalNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(16, 464);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(184, 52);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(361, 464);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 48);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 524);
            this.Controls.Add(this.lblIntEx);
            this.Controls.Add(this.txtPrinciple);
            this.Controls.Add(this.cboInterest);
            this.Controls.Add(this.lblPrinciple);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.radOther);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rad30Y);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.rad15Y);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnCalc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(557, 571);
            this.MinimumSize = new System.Drawing.Size(557, 571);
            this.Name = "frmMain";
            this.Text = "Todd Holloman : Morgage Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrinciple;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton rad30Y;
        private System.Windows.Forms.RadioButton rad15Y;
        private System.Windows.Forms.TextBox txtPrinciple;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.ComboBox cboInterest;
        private System.Windows.Forms.Label lblIntEx;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

