using Accord.Statistics.Distributions.Univariate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PricingOptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  double GetFirstIntermediaiteParameter(double S, double K, double t, double O, double r)
        {
            double nominateur = Math.Log(S / K) + (r + ((Math.Pow(O, 2) / 2))) * t;
            double denominateur = Math.Sqrt(t) * O;
            return nominateur / denominateur;
        }

        private  double GetSecondIntermediaiteParameter(double d1, double O, double t)
        {
            return d1 - (Math.Sqrt(t)) * O;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateParameter(txtStrkP.Text) && ValidateParameter(txtTTM.Text) && ValidateParameter(txtStdrD.Text))
            {
                NormalDistribution normalDistribution = new NormalDistribution();
                double d1 = GetFirstIntermediaiteParameter(0,0,0,0,0);
                double test = normalDistribution.DistributionFunction(d1);
            }
            else
            {
                MessageBox.Show("Please Verify your input values");
            }
            
        }

        private void txtStrkP_Validating(object sender, CancelEventArgs e)
        {
            TextBox tx = sender as TextBox;
            double test =0;
            bool isdouble = Double.TryParse(tx.Text, out test);
            if (!isdouble || test==0)
            {
                /* do Failure things */
                MessageBox.Show("La valeur du stock doit etre un double superieur strictement à 0");
                tx.Text = "";
            }
           
            else
                //this is the formatting line
                tx.Text = test.ToString("#,##0.00");
        }

        private void txtTTM_Validating(object sender, CancelEventArgs e)
        {
            TextBox tx = sender as TextBox;
            double test = 0;
            bool isdouble = Double.TryParse(tx.Text, out test);
            if (!isdouble || test == 0)
            {
           
                MessageBox.Show("La valeur du Time To Maturity doit etre un double superieur strictement à 0");
                tx.Text = "";
            }
            else
                tx.Text = test.ToString("#,##0.00");
        }

        private bool ValidateParameter(string parameter)
        {
            double test = 0;
            bool isdouble = Double.TryParse(parameter, out test);
            if (!isdouble || test == 0)
            {

                return false;
            }
            return true;
        }
    }
}
