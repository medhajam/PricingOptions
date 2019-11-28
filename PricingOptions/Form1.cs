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
            double nominateur = Math.Log(S / K) + (r + (Math.Pow(O, 2) / 2)) * t;
            double denominateur = Math.Sqrt(t) * O;
            return nominateur / denominateur;
        }

        private  double GetSecondIntermediaiteParameter(double d1, double O, double t)
        {
            return d1 - (Math.Sqrt(t)) * O;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateAllParameters() && ValidateParameter(txtStrkP.Text) && ValidateParameter(txtTTM.Text) && ValidateParameter(txtStdrD.Text))
            {
                NormalDistribution normalDistribution = new NormalDistribution();
                StringBuilder result = new StringBuilder();

                double S = double.Parse(txtStkP.Text);
                double K = double.Parse(txtStrkP.Text);
                double t = double.Parse(txtTTM.Text);
                double O = double.Parse(txtStdrD.Text);
                double r = double.Parse(txtRiskRate.Text);

                double d1 = GetFirstIntermediaiteParameter(S,K , t, O, r);
                result.AppendLine($"d1 : {d1.ToString("#,##0.0000")}");
                double d2 = GetSecondIntermediaiteParameter(d1, O, t);
                result.AppendLine($"d2 : {d2.ToString("#,##0.0000")}");
                double call = GetCall(d1, d2, S, K, t, r,normalDistribution);
                result.AppendLine($"Call : {call.ToString("#,##0.0000")}");
                double put = GetPut(d1, d2, S, K, t, r, normalDistribution);
                result.AppendLine($"Put : {put.ToString("#,##0.0000")}");

                lblResult.Text = result.ToString();
                lblResult.Font  = new Font("Arial", 15, FontStyle.Bold);

            }
            else
            {
                MessageBox.Show("Please Verify your input values");
            }
            
        }

        private double GetCall(double d1, double d2, double S, double K, double t, double r, NormalDistribution distrib) {

            double cumulativeDistrib1 = distrib.DistributionFunction(d1); 
            double cumulativeDistrib2 = distrib.DistributionFunction(d2);
            double exp = Math.Exp(-r * t);
            return (S * cumulativeDistrib1) - (K*exp*cumulativeDistrib2);
        }

        private double GetPut(double d1, double d2, double S, double K, double t, double r, NormalDistribution distrib)
        {
            double cumulativeDistrib1 = distrib.DistributionFunction(-d1);
            double cumulativeDistrib2 = distrib.DistributionFunction(-d2);
            double exp = Math.Exp(-r * t);
            return (K * exp * cumulativeDistrib2) - (S * cumulativeDistrib1);
        }


        private bool ValidateAllParameters()
        {
            foreach(Control c in this.Controls)
            {
                double test;
                if (c.GetType() == typeof(TextBox))
                {
                    if (!double.TryParse(c.Text, out test))
                        return false;
                }
            }
            return true;
        }

        private void txtStrkP_Validating(object sender, CancelEventArgs e)
        {
            TextBox tx = sender as TextBox;
            //Accept un nombre avec '.'
            tx.Text = tx.Text.Replace('.', ',');

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
            //Accept un nombre avec '.'
            tx.Text = tx.Text.Replace('.', ',');

            double test = 0;
            if (tx.Text.Contains("/"))
            { 
                test = CalcDivision(tx.Text);
                tx.Text = test.ToString("#,##0.00");
                return;
            }
                           
            bool isdouble = Double.TryParse(tx.Text, out test);
            if (!isdouble || test == 0)
            {
           
                MessageBox.Show("La valeur du Time To Maturity doit etre un double superieur strictement à 0");
                tx.Text = "";
            }
            else
                tx.Text = test.ToString("#,##0.00");
        }

        private double CalcDivision (string formula)
        {
            double val1;
            double val2;
            double result = 0;
            string[] tab = formula.Split('/');
            if (double.TryParse(tab[0], out val1) && double.TryParse(tab[1], out val2))
            {
                if (val2 == 0)
                    MessageBox.Show("Division par zéro impossible");
                else
                    result = val1 / val2;
            }
            return result;
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

        private void txtStkP_Validating(object sender, CancelEventArgs e)
        {
            TextBox tx = sender as TextBox;
            //Accept un nombre avec '.'
            tx.Text = tx.Text.Replace('.', ',');
        }

        private void txtStdrD_Validating(object sender, CancelEventArgs e)
        {
            TextBox tx = sender as TextBox;
            //Accept un nombre avec '.'
            tx.Text = tx.Text.Replace('.', ',');
        }

        private void txtRiskRate_Validating(object sender, CancelEventArgs e)
        {
            TextBox tx = sender as TextBox;
            //Accept un nombre avec '.'
            tx.Text = tx.Text.Replace('.', ',');
        }
    }
}
