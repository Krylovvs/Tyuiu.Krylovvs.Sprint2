using tyuiu.cources.programming.interfaces.dll;


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