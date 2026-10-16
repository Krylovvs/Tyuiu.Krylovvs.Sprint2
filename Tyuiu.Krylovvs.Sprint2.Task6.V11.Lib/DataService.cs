using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.Krylovvs.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int ThreeGreenDay = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                _ => throw new ArgumentOutOfRangeException(
                    nameof(m), "Wonder of you")
            };

            if (n < ThreeGreenDay)
            {
                n++;
            }
            else
            {
                n = 1;

                if (m == 12)
                {
                    m = 1;
                    g++;
                }
                else
                {
                    m++;
                }
            }

            return $"{g} {m} {n}";
        }
    }
}
namespace tyuiu.cources.programming.interfaces.Sprint2
{
    // Token: 0x0200049C RID: 1180
    //[NullableContext(1)]
    public interface ISprint2Task6V11
    {
        // Token: 0x0600049B RID: 1179
        string FindDateOfNextDay(int g, int m, int n);
    }
}

