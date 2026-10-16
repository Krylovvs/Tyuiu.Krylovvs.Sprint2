using Tyuiu.Krylovvs.Sprint2.Task0.V8.Lib;

namespace Tyuiu.Krylovvs.Sprint2.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations_ReturnsExpectedResults()
        {
            DataService ds = new DataService();

            int x = 185, y = 251;
            bool[] Exected = { true, false, true, false, true, false };

            Assert.AreEqual(
                Exected,
                ds.GetCompareOperations(x, y));
        }
    }
}
