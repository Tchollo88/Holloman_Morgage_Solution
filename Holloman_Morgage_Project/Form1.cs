using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holloman_Morgage_Project
{
    public partial class frmMain : Form
    {

        
        public frmMain()
        {
            InitializeComponent();
        }

        /**private access codes**/

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtPrinciple.Text = string.Empty;
            this.txtOther.Text = string.Empty;
            this.rad15Y.Checked = false;
            this.rad30Y.Checked = true;
            this.radOther.Checked = false;
            this.cboInterest.SelectedIndex = -1;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            total = mtotal(princ(),rate(), year(), pow_mor(rate(), year()));

            lblTotal.Text = "Monthly Payment is:";
            lblTotalNum.Text = total.ToString("C2");
        }

        /**Public access codes**/

        public decimal princ()
        {
            /*princ = p*/
            decimal amount = 0;
            amount = decimal.Parse(txtPrinciple.Text);
            return amount;
        }


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
                return year = 12 * decimal.Parse(radOther.Text);
            }
            return year;
        }


        public decimal rate()
        {
            /*rate = r*/
            decimal rate = decimal.Parse(cboInterest.Text);
            rate = rate / 100;
            rate = rate / 12;
            rate = truncP(rate);
            return rate;
        }


        public decimal pow_mor(decimal r, decimal n)
        {
            /*pow = u */
            r = r + 1;
            decimal pow = (decimal)Math.Pow((double)r, (double)n);
            return pow;
        }


        public decimal mtotal(decimal p, decimal r, decimal n, decimal u)
        {
            /*| calc = m | formula m = P[r(1+r)^n/((1+r)^n)-1)] |*/
            //calc = p * (r * (1 + r) * n) / ((1 + r) * n) - 1);
            decimal top = r * u;
            

            decimal bott = u - 1;
            

            decimal rem = top / bott;
            

            decimal calc = p * rem;
            calc = truncT(calc);
            
            return calc;
        }

        public decimal truncP(decimal r)
        {
            r = r * 10000;
            r = Math.Truncate(r);
            r = r / 10000;

            return r;
        }

        public decimal truncT(decimal r)
        {
            r = r * 100;
            r = Math.Truncate(r);
            r = r / 100;

            return r;
        }

        
    }
}
