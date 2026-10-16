using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.Krylovvs.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] Result =
            {
                a == c,                
                b != c,                
                b < a,                 
                a > c,                 
                b <= a,            
                !(a - d != 0) ^ (b > c)
            };


            return Result;
        }
    }
}
namespace tyuiu.cources.programming.interfaces.Sprint2
{
    // Token: 0x02000422 RID: 1058
    public interface ISprint2Task1V29
    {
        // Token: 0x06000421 RID: 1057
        bool[] GetLogicOperations(int a, int b, int c, int d);
    }
}