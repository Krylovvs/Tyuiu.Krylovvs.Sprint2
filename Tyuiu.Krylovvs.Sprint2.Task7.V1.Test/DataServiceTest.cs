using tyuiu.cources.programming.interfaces.dll;

namespace Tyuiu.Krylovvs.Sprint2.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [DataTestMethod]
        [DataRow(0.0, 0.5, true)] 
        [DataRow(0.5, 0.5, true)] 
        [DataRow(-0.5, 0.5, true)]
        [DataRow(0.0, 1.0, true)] 
        [DataRow(0.0, 0.0, true)] 
        [DataRow(0.0, -0.5, false)]
        [DataRow(0.8, 0.5, false)]
        [DataRow(0.0, 1.1, false)]
        public void CheckDotInShadedArea_ReturnsExpectedResult(
            double x, double y, bool Expected)
        {
            var ds = new DataService();

            bool Actual = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
