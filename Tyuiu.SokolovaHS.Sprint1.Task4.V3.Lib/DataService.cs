using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SokolovaHS.Sprint1.Task4.V3.Lib
{
    public class DataService : ISprint1Task4V3
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Sqrt(3 * x) / Math.Pow(x - y, 2), 3);
        }
    }
}
