using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.SokolovaHS.Sprint1.Task2.V1.Lib
{
    public class DataService : ISprint1Task2V1
    {
        public double ConvertKmToM(int km)
        {
            double result = km / 1.609;
            return Math.Round(result, 3);
        }
    }
}
