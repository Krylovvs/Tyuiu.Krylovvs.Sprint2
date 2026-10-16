using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.Krylovvs.Sprint2.Task2.V19.Lib
{
    public class DataService : ISprint2Task2V19
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            /*
            bool Res = false;   
            if ((x >= 3 && x <= 13) && y != 15)
            {
                switch(Res)
                {
                    case bool z = y == x:
                        ; return true 
                            ;break;
                }
            } // thinking
            */

            bool BrutForse= (y == 3 && (x >= 3 && x <= 5 || x >= 9 && x <= 12))
           || (y == 4 && (x >= 3 && x <= 5 || x >= 9 && x <= 10))
           || (y == 5 && x >= 3 && x <= 10)
           || ((y == 6 || y == 7) && x >= 3 && x <= 13)
           || (y == 8 && (x == 6 || x >= 11 && x <= 13))
           || ((y == 9 || y == 10) && (x == 6 || x >= 11 && x <= 12))
           || (y == 11 && (x >= 3 && x <= 6 || x >= 11 && x <= 12))
           || (y == 12 && x >= 9 && x <= 11)
           || (y == 13 && x >= 7 && x <= 11)
           || (y == 14 && x >= 9 && x <= 13);

            return BrutForse;

        }
    }
}
namespace tyuiu.cources.programming.interfaces.Sprint2
{
    // Token: 0x02000437 RID: 1079
    public interface ISprint2Task2V19
    {
        // Token: 0x06000436 RID: 1078
        bool CheckDotInShadedArea(int x, int y);
    }
}