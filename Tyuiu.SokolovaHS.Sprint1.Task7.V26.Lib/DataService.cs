using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SokolovaHS.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double sinXSquare = Math.Sin(x * x);
            double numerator1 = sinXSquare + y;
            double denominator1 = y + 1;

            double numerator2 = (x * y) - 12;
            double denominator2 = 34 + x * x;

            double z = (numerator1 / denominator1) - (numerator2 / denominator2);
            return Math.Round(z,3);
        }
    }
}