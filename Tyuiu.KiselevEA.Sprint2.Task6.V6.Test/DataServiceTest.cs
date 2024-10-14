using Tyuiu.KiselevEA.Sprint2.Task6.V6.Lib;
namespace Tyuiu.KiselevEA.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Дама пики", ds.FindCardNameAndValue(12, 1));
        }
    }
}