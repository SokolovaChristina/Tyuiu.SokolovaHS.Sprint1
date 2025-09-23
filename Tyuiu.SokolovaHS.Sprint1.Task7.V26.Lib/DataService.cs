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
          double part1 = Math.Pow(Math.Sin(x), 2) + (y / (y + 1));
          double part2 = (x * y) - (12.0 / (34 + Math.Pow(x, 2)));
          double z = part1 - part2;
          return Math.Round(z, 3);

        }
    }
}