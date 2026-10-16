using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.Krylovvs.Sprint2.Task3.V3.Lib
{
    public class DataService : ISprint2Task3V3
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round(x * Math.Pow((x + 1) / (x - 1), x),3);
            }
            else if (x == 0)
            {
                return Math.Round((Math.Pow(x, 4) - Math.Cos(Math.Pow(x, 5)) + 3)
                     / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12),3);
            }
            else if (x > -7 && x < 0)
            {
                return Math.Round(
                    Math.Pow(1 + Math.Sqrt(x + 3) / Math.Pow(x, 2), x)
                    ,3);
            }
            else if (x < -7)
            {
                return Math.Round(
                    Math.Pow(x, 2) + 10 * x - 1.0 / x,
                    3);
            }
            else
            {
                return x;
            }
        }
    }
}
namespace tyuiu.cources.programming.interfaces.Sprint2
{
    // Token: 0x02000446 RID: 1094
    public interface ISprint2Task3V3
    {
        // Token: 0x06000445 RID: 1093
        double Calculate(double x);
    }
}