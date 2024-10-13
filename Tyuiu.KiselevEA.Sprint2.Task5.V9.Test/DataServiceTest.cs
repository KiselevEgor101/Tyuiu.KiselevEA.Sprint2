using Tyuiu.KiselevEA.Sprint2.Task5.V9.Lib;
namespace Tyuiu.KiselevEA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void NextDayDateTest()
        {
            DataService ds = new DataService();

            Assert.AreEqual("02.01", ds.FindDateOfNextDay(1, 1));
            Assert.AreEqual("01.03", ds.FindDateOfNextDay(2, 28));
            Assert.AreEqual("01.04", ds.FindDateOfNextDay(3, 30));
            Assert.AreEqual("01.05", ds.FindDateOfNextDay(4, 31));
            Assert.AreEqual("10.05", ds.FindDateOfNextDay(5, 9));
            Assert.AreEqual("01.07", ds.FindDateOfNextDay(6, 31));
            Assert.AreEqual("02.07", ds.FindDateOfNextDay(7, 1));
            Assert.AreEqual("01.09", ds.FindDateOfNextDay(8, 31));
            Assert.AreEqual("01.10", ds.FindDateOfNextDay(9, 30));
            Assert.AreEqual("16.10", ds.FindDateOfNextDay(10, 15));
            Assert.AreEqual("08.11", ds.FindDateOfNextDay(11, 7));
            Assert.AreEqual("02.12", ds.FindDateOfNextDay(12, 1));


        }
    }
}