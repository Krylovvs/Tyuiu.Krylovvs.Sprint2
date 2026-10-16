using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.Krylovvs.Sprint2.Task4.V15.Lib
{
    public class DataService : ISprint2Task4V15
    {
        public double Calculate(double x, double y)
        {
            bool What = Math.Sqrt(x) + 2 > Math.Sqrt(y) - 20;

            double z = What
                ? Math.Pow(3 + 2.0 / y, x)
                : Math.Cos(y) + 12.0 / (x * x);

            return Math.Round(z, 3);
        }
    }
}
namespace tyuiu.cources.programming.interfaces.Sprint2
{
    // Token: 0x02000471 RID: 1137
    public interface ISprint2Task4V15
    {
        // Token: 0x06000470 RID: 1136
        double Calculate(double x, double y);
    }
}
