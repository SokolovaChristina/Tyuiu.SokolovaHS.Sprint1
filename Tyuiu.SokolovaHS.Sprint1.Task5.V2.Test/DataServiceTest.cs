using Tyuiu.SokolovaHS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.SokolovaHS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 16;
            var res = ds.FahrenheitToСelsius(temp);
            Assert.AreEqual(-9, res);
        }
    }
}