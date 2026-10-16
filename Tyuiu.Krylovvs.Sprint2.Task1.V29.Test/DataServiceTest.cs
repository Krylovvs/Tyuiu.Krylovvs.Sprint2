using Tyuiu.Krylovvs.Sprint2.Task1.V29.Lib;

namespace Tyuiu.Krylovvs.Sprint2.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations_ReturnsExpectedResults()
        {
            DataService ds = new DataService();

            int a = 657, b = 654, c = 657, d = 657;
            bool[] Exected = { true, true, true, false, true, true };

            CollectionAssert.AreEqual(
                Exected,
                ds.GetLogicOperations(a, b, c, d));
        }
    }
}
