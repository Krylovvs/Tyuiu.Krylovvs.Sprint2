using Microsoft.VisualStudio.TestPlatform.TestHost;
using Tyuiu.Krylovvs.Sprint2.Task4.V15.Lib;

namespace Tyuiu.Krylovvs.Sprint2.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations_ReturnsExpectedResults()
        {
            DataService ds = new DataService();

            double Actual = ds.Calculate(4, 9);
            double Expected = Math.Round(Math.Pow(3 + 2.0 / 9, 4),3);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
