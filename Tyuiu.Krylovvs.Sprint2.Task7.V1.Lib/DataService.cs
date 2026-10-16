using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.Krylovvs.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return x * x + y * y <= 1 && y >= Math.Abs(x);
        }
    }
}
namespace tyuiu.cources.programming.interfaces.Sprint2
{
    // Token: 0x020004A2 RID: 1186
    public interface ISprint2Task7V1
    {
        // Token: 0x060004A1 RID: 1185
        bool CheckDotInShadedArea(double x, double y);
    }
}