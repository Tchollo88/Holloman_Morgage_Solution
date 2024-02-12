using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Holloman_Morgage_Project
{
    public partial class frmMain : Form
    {
        /** Class - Programming I - IT101  
          Name - Todd Holloman                       Holloman_Morgage_Solution

            -comment to teacher-
        I hope the comments help you identify what each part of my code does and helps you navigate it more easily.

        Still having a problem with the math, I am missing something from my caculation and don't know what it is.

        **/
        
        public frmMain()
        {
            InitializeComponent();
        }

        /**private access codes**/

        //Exit program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clears all fields to initial setup (start-up setup)
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtPrinciple.Text = string.Empty;
            this.txtOther.Text = string.Empty;
            this.rad15Y.Checked = false;
            this.rad30Y.Checked = true;
            this.radOther.Checked = false;
            this.cboInterest.SelectedIndex = -1;
            lblTotal.Text = string.Empty;
            lblTotalNum.Text = string.Empty;
        }

        //Initializes calculation, prints text to labels
        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            if (txtPrinciple.Text != "" &&
                cboInterest.SelectedIndex != -1)
            {
                total = mtotal(princ(), rate(), year(), pow_mor(rate(), year()));

                lblTotal.Location = new Point(105, 310);
                lblTotal.ForeColor = Color.Black;
                lblTotal.Text = "Monthly Payment is:";

                lblTotalNum.Location = new Point(155, 340);
                lblTotalNum.ForeColor = Color.Black;
                lblTotalNum.Text = total.ToString("C2");
            }
            else
            {
                lblTotal.Location = new Point(35, 310);
                lblTotal.ForeColor = Color.Red;
                lblTotal.Text = "The fields were filled out incorrectly,";

                lblTotalNum.Location = new Point(10, 340);
                lblTotalNum.ForeColor = Color.Red;
                lblTotalNum.Text = "please fill in all areas and try again.";
            }
            

        }


        /**Public access codes**/

        //Builds the principle variable, or (P)
        public decimal princ()
        {
            /*princ = p*/
            decimal amount = 0;
            amount = decimal.Parse(txtPrinciple.Text);
            return amount;
        }

        //Builds the years of agreement variable, or (N)
        public decimal year()
        {
            /*year = n*/
            decimal year = 0;

            if(rad15Y.Checked)
            {
                return year = 12 * 15;
            }
            else if (rad30Y.Checked)
            {
                return year = 12 * 30;
            }
            else if (radOther.Checked)
            {
                return year = 12 * decimal.Parse(txtOther.Text);
            }
            return year;
        }

        //Builds the interest rate variable, and converts is to percentage, (R)
        public decimal rate()
        {
            /*rate = r*/
            decimal rate = decimal.Parse(cboInterest.Text);
            rate = rate / 100;
            rate = rate / 12;
            rate = truncP(rate);
            return rate;
        }

        //Takes (R) and (N) and converts it into a power variable, or (U)
        public decimal pow_mor(decimal r, decimal n)
        {
            /*pow = u */
            r = r + 1;
            decimal pow = (decimal)Math.Pow((double)r, (double)n);
            return pow;
        }

        //Computes the math to the mortgage formula, broke it down to simple terms
        public decimal mtotal(decimal p, decimal r, decimal n, decimal u)
        {
            /*| calc = m | formula m = P[r(1+r)^n/((1+r)^n)-1)] |*/
            //calc = p * (r * (1 + r) * n) / ((1 + r) * n) - 1);
            decimal top = r * u;            
            decimal bott = u - 1;            
            decimal rem = top / bott;            
            decimal calc = p * rem;

            //Truncates calculation to prep it for currency string
            calc = truncT(calc);
            calc = Math.Round(calc,0,MidpointRounding.AwayFromZero);
            
            return calc;
        }

        //Truncates to the 10,000th value
        public decimal truncP(decimal r)
        {
            r = r * 10000;
            r = Math.Truncate(r);
            r = r / 10000;

            return r;
        }

        //Truncates to the 100th value
        public decimal truncT(decimal r)
        {
            r = r * 100;
            r = Math.Truncate(r);
            r = r / 100;

            return r;
        }

        
    }
}
