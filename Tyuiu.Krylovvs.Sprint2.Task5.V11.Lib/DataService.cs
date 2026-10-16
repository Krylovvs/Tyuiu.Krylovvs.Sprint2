using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.Krylovvs.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int ThreeGreenDay = 31;

            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    ThreeGreenDay = 30;
                    break;
                case 2:
                    ThreeGreenDay = 28;
                    break;          
            }

            if (n < ThreeGreenDay)
            {
                n++;
            }
            else
            {
                n = 1;

                if (m < 12)
                    m++;
                else
                {
                    m = 1;
                    g++;
                }
            }

            return $"{g} {m} {n}";
        }
    }
}
namespace tyuiu.cources.programming.interfaces.Sprint2
{
    // Token: 0x0200048C RID: 1164
    //[NullableContext(1)]
    public interface ISprint2Task5V11
    {
        // Token: 0x0600048B RID: 1163
        string FindDateOfNextDay(int g, int m, int n);
    }
}