using Tyuiu.SokolovaHS.Sprint1.Task2.V1.Lib;

namespace Tyuiu.SokolovaHS.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int m = 2000;
            var res = ds.ConvertKmToM(m);
            Assert.AreEqual(3218, res);
        }
    }
}