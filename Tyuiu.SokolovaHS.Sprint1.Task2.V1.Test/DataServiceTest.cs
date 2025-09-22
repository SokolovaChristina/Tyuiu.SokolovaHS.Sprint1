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
            int km = 2000;
            var res = ds.ConvertKmToM(km);
            Assert.AreEqual(1243.008, res);
        }
    }
}