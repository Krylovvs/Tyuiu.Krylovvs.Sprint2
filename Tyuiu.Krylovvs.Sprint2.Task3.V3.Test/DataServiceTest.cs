using Tyuiu.Krylovvs.Sprint2.Task3.V3.Lib;

namespace Tyuiu.Krylovvs.Sprint2.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations_ReturnsExpectedResults()
        {
            DataService ds = new DataService();

            double x = 2;
            double Exected = 18.0d;

            Assert.AreEqual(ds.Calculate(x), Exected);
        }
    }
}
