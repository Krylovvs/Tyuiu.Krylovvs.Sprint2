using Tyuiu.Krylovvs.Sprint2.Task2.V19.Lib;

namespace Tyuiu.Krylovvs.Sprint2.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations_ReturnsExpectedResults()
        {
            DataService ds = new DataService();

            int x = 15, y = 15;
            bool Exected = false;

            Assert.AreEqual(
                Exected,
                ds.CheckDotInShadedArea(x, y));
        }
    }
}
