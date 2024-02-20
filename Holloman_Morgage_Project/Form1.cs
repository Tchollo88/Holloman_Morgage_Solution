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
        **/
        
        public frmMain()
        {
            InitializeComponent();
        }

        /**private access codes**/

        //Locks btnClear and disables txtOther default on intialization
        private void frmMain_Load(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            txtOther.Enabled = false;
        }

        //enables the txt box when selecting radOther
        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            if(radOther.Checked)
            {
                txtOther.Enabled = true;

            }
        }

        //Exit program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Clears all fields to initial setup(start-up setup), locks btnClear
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
            
            btnClear.Enabled = false;
            rad30Y.Focus();
        }

        //Initializes calculation, prints text to labels
        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal other;
            decimal principle;

            bool princcheck = decimal.TryParse(txtPrinciple.Text, out principle);
            bool othercheck = decimal.TryParse(txtOther.Text, out other);
            bool txtcheck = decimal.TryParse(txtOther.Text, out other) && decimal.TryParse(txtPrinciple.Text, out principle);

            if (txtPrinciple.Text == string.Empty &&
                radOther.Checked && txtOther.Enabled == false &&
                cboInterest.SelectedIndex == -1 || 
                txtPrinciple.Text == string.Empty &&
                cboInterest.SelectedIndex == -1)
            {
                lblTotal.Location = new Point(30, 310);
                lblTotal.ForeColor = Color.Red;
                lblTotal.Text = "The fields were filled out incorrectly,";

                lblTotalNum.Location = new Point(10, 340);
                lblTotalNum.ForeColor = Color.Red;
                lblTotalNum.Text = "please fill in all areas and try again.";
            }
            else if (princcheck == false)
            {
                if (txtPrinciple.Text == string.Empty)
                {
                    lblTotal.Location = new Point(60, 310);
                    lblTotal.ForeColor = Color.Red;
                    lblTotal.Text = "There is an error in Principle,";

                    lblTotalNum.Location = new Point(10, 340);
                    lblTotalNum.ForeColor = Color.Red;
                    lblTotalNum.Text = "please put the amount of intial cost.";
                }
                else
                {
                    lblTotal.Location = new Point(60, 310);
                    lblTotal.ForeColor = Color.Red;
                    lblTotal.Text = "There is an error in Principle,";

                    lblTotalNum.Location = new Point(10, 340);
                    lblTotalNum.ForeColor = Color.Red;
                    lblTotalNum.Text = "please input a number and try again.";
                }
            }
            else if (txtPrinciple.Text == string.Empty)
            {
                lblTotal.Location = new Point(60, 310);
                lblTotal.ForeColor = Color.Red;
                lblTotal.Text = "There is an error in Principle,";

                lblTotalNum.Location = new Point(10, 340);
                lblTotalNum.ForeColor = Color.Red;
                lblTotalNum.Text = "please put the amount of intial cost.";
            }
            else if (othercheck == false)
            {
                if (txtOther.Text == string.Empty)
                {
                    lblTotal.Location = new Point(50, 310);
                    lblTotal.ForeColor = Color.Red;
                    lblTotal.Text = "The years in Other are missing,";

                    lblTotalNum.Location = new Point(29, 340);
                    lblTotalNum.ForeColor = Color.Red;
                    lblTotalNum.Text = "please enter an amout of years.";
                }
                else
                {
                    lblTotal.Location = new Point(90, 310);
                    lblTotal.ForeColor = Color.Red;
                    lblTotal.Text = "Other's input is invalid,";

                    lblTotalNum.Location = new Point(7, 340);
                    lblTotalNum.ForeColor = Color.Red;
                    lblTotalNum.Text = "please enter an amount in numbers.";
                }               
            }
            else if (txtOther.Text == string.Empty)
            {
                
            }
            else if (cboInterest.SelectedIndex == -1)
            {
                lblTotal.Location = new Point(37, 310);
                lblTotal.ForeColor = Color.Red;
                lblTotal.Text = "You are missing and interest rate,";

                lblTotalNum.Location = new Point(43, 340);
                lblTotalNum.ForeColor = Color.Red;
                lblTotalNum.Text = "please enter an interest rate.";
            }
            else if (princcheck == true &&
                cboInterest.SelectedIndex != -1 ||
                txtcheck == true &&
                cboInterest.SelectedIndex != -1)
            {
                total = mtotal(princ(), rate(), year(), pow_mor(rate(), year()));

                lblTotal.Location = new Point(105, 310);
                lblTotal.ForeColor = Color.Black;
                lblTotal.Text = "Monthly Payment is:";

                lblTotalNum.Location = new Point(155, 340);
                lblTotalNum.ForeColor = Color.Green;
                lblTotalNum.Text = total.ToString("C2");

                btnClear.Enabled = true;
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
            decimal year = decimal.Parse(txtOther.Text);

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
                if (txtOther.Text == string.Empty)
                {
                    txtOther.Enabled = false;
                    return year = 1;
                }
                else if (year > 4 && year < 41)
                {
                    return year = 12 * year;
                }
                else if (year < 5 && year > 40)
                {
                   return year = 1;
                }
            }
            return year;
        }

        //Builds the interest rate variable, and converts it to percentage, or (R)
        public decimal rate()
        {
            /*rate = r*/
            decimal rate = decimal.Parse(cboInterest.Text);
            rate = rate / 100;
            rate = rate / 12;
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

        //Computes the math to the mortgage formula
        // broke it down to simple terms
        public decimal mtotal(decimal p, decimal r, decimal n, decimal u)
        {
            decimal neg = 0;
            decimal calc = 0;

            /*| calc = m | formula m = P[r(1+r)^n/((1+r)^n)-1)] |*/

            if (n == p)
            {
                txtOther.Enabled = false;
                calc = 0;
            }
            else
            {
                decimal top = r * u;
                decimal bott = u - 1;
                decimal rem = top / bott;
                calc = p * rem;
                return calc;
            }
            return calc;
        }


    }
}
