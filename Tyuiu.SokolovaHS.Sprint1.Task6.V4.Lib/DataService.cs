using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.SokolovaHS.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return ""; 
            }

            string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            IEnumerable<string> result = words.Where(word => word.Contains("нн"));

            return string.Join(", ", result);
        }
 }
}
