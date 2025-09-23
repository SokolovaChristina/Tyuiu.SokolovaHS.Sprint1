using Tyuiu.SokolovaHS.Sprint1.Task3.V13.Lib;

namespace Tyuiu.SokolovaHS.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int number = 232;
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(12, res);
        }
    }
}