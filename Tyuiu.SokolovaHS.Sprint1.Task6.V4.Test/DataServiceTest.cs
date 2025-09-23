
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaHS.Sprint1.Task6.V4.Lib;
namespace Tyuiu.SokolovaHS.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "неожиданно, ленный, кованый, званый";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(strTest);
            string wait = "неожиданно ленный";
            Assert.AreEqual(wait, res);
        }
    }
}