using Tyuiu.Krylovvs.Sprint2.Task6.V11.Lib;

namespace Tyuiu.Krylovvs.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [DataTestMethod]
        [DataRow(2021, 3, 28, "2021 3 29")]  // Бахрейн
        [DataRow(2021, 7, 18, "2021 7 19")]  // Великобритания
        [DataRow(2021, 9, 11, "2021 9 12")] // Италия
        [DataRow(2021, 12, 12, "2021 12 13")] // Абу-Даби
        public void DataFinderTestMethod(
            int g, int m, int n, string Expected)
        {
            var service = new DataService();

            string Actual = service.FindDateOfNextDay(g, m, n);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
