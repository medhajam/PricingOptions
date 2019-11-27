using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Distributions;
using Accord.Statistics.Distributions.Univariate;

namespace OptionsPricing
{
    class Program
    {
        static void Main(double[] args)
        {

            NormalDistribution normalDistribution = new NormalDistribution();
            double d1 = GetFirstIntermediaiteParameter(args[0], args[1], args[2], args[3], args[4]);
            double test = normalDistribution.DistributionFunction(d1);
        }

        private static double GetFirstIntermediaiteParameter(double S, double K, double t, double O, double r)
        {
            double nominateur = Math.Log(S / K) + (r + ((Math.Pow(O, 2) / 2))) * t;
            double denominateur = Math.Sqrt(t) * O;
            return nominateur / denominateur;
        }

        private double GetSecondIntermediaiteParameter(double d1, double O, double t)
        {
            return d1 - (Math.Sqrt(t)) * O;
        }
    }
}
