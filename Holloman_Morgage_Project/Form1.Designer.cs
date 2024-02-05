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
            this.lblPrinciple = new System.Windows.Forms.Label();
            this.txtPrinciple = new System.Windows.Forms.TextBox();
            this.lblYearGrade = new System.Windows.Forms.Label();
            this.rad15Y = new System.Windows.Forms.RadioButton();
            this.rad30Y = new System.Windows.Forms.RadioButton();
            this.radOY = new System.Windows.Forms.RadioButton();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.cboInterest = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrinciple
            // 
            this.lblPrinciple.AutoSize = true;
            this.lblPrinciple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinciple.Location = new System.Drawing.Point(29, 9);
            this.lblPrinciple.Name = "lblPrinciple";
            this.lblPrinciple.Size = new System.Drawing.Size(95, 20);
            this.lblPrinciple.TabIndex = 1;
            this.lblPrinciple.Text = "Principle: ";
            // 
            // txtPrinciple
            // 
            this.txtPrinciple.Location = new System.Drawing.Point(140, 9);
            this.txtPrinciple.Name = "txtPrinciple";
            this.txtPrinciple.Size = new System.Drawing.Size(135, 22);
            this.txtPrinciple.TabIndex = 2;
            // 
            // lblYearGrade
            // 
            this.lblYearGrade.AutoSize = true;
            this.lblYearGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearGrade.Location = new System.Drawing.Point(12, 40);
            this.lblYearGrade.Name = "lblYearGrade";
            this.lblYearGrade.Size = new System.Drawing.Size(123, 20);
            this.lblYearGrade.TabIndex = 3;
            this.lblYearGrade.Text = "Terms in Years";
            // 
            // rad15Y
            // 
            this.rad15Y.AutoSize = true;
            this.rad15Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad15Y.Location = new System.Drawing.Point(32, 72);
            this.rad15Y.Name = "rad15Y";
            this.rad15Y.Size = new System.Drawing.Size(86, 22);
            this.rad15Y.TabIndex = 4;
            this.rad15Y.Text = "15 Year";
            this.rad15Y.UseVisualStyleBackColor = true;
            // 
            // rad30Y
            // 
            this.rad30Y.AutoSize = true;
            this.rad30Y.Checked = true;
            this.rad30Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad30Y.Location = new System.Drawing.Point(32, 100);
            this.rad30Y.Name = "rad30Y";
            this.rad30Y.Size = new System.Drawing.Size(86, 22);
            this.rad30Y.TabIndex = 0;
            this.rad30Y.TabStop = true;
            this.rad30Y.Text = "30 Year";
            this.rad30Y.UseVisualStyleBackColor = true;
            // 
            // radOY
            // 
            this.radOY.AutoSize = true;
            this.radOY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOY.Location = new System.Drawing.Point(32, 128);
            this.radOY.Name = "radOY";
            this.radOY.Size = new System.Drawing.Size(86, 22);
            this.radOY.TabIndex = 5;
            this.radOY.TabStop = true;
            this.radOY.Text = "Other...";
            this.radOY.UseVisualStyleBackColor = true;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(140, 128);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(114, 22);
            this.txtOther.TabIndex = 6;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(30, 169);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(75, 20);
            this.lblInterest.TabIndex = 7;
            this.lblInterest.Text = "Intrest: ";
            // 
            // cboInterest
            // 
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
            this.cboInterest.Location = new System.Drawing.Point(140, 169);
            this.cboInterest.Name = "cboInterest";
            this.cboInterest.Size = new System.Drawing.Size(85, 24);
            this.cboInterest.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(32, 199);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(222, 35);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(22, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 44);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(140, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 44);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 294);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cboInterest);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.radOY);
            this.Controls.Add(this.rad30Y);
            this.Controls.Add(this.rad15Y);
            this.Controls.Add(this.lblYearGrade);
            this.Controls.Add(this.txtPrinciple);
            this.Controls.Add(this.lblPrinciple);
            this.MaximumSize = new System.Drawing.Size(311, 341);
            this.Name = "frmMain";
            this.Text = "Todd Holloman : Morgage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrinciple;
        private System.Windows.Forms.TextBox txtPrinciple;
        private System.Windows.Forms.Label lblYearGrade;
        private System.Windows.Forms.RadioButton rad15Y;
        private System.Windows.Forms.RadioButton rad30Y;
        private System.Windows.Forms.RadioButton radOY;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.ComboBox cboInterest;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

