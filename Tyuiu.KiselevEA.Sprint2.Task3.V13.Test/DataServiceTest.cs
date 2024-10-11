using Tyuiu.KiselevEA.Sprint2.Task3.V13.Lib;
namespace Tyuiu.KiselevEA.Sprint2.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConditiont1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = ds.Calculate(x);
            double wait = -7;
            Assert.AreEqual(wait, y);
        }

        [TestMethod]
        public void ValidConditiont2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = ds.Calculate(x);
            double wait = 9;
            Assert.AreEqual(wait, y);
        }

        [TestMethod]
        public void ValidConditiont3()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = ds.Calculate(x);
            double wait = 0.091;
            Assert.AreEqual(wait, y);
        }

        [TestMethod]
        public void ValidConditiont4()
        {
            DataService ds = new DataService();
            double x = -22;
            double y = ds.Calculate(x);
            double wait = -241.955;
            Assert.AreEqual(wait, y);
        }
    }
}