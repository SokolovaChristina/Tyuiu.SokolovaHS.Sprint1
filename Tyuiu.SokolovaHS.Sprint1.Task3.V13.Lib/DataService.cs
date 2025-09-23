using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SokolovaHS.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int num = (int)number;
            int a = num / 100;          
            int b = (num % 100) / 10;   
            int c = num % 10;
            double product = (double)a * b * c;
            return Math.Round(product, 3);
        }
    }
}
