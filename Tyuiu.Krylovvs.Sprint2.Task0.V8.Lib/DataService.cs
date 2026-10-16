using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.Krylovvs.Sprint2.Task0.V8.Lib
{
    public class DataService : ISprint2Task0V8
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] Result =
            {
                x == y - 66,
                x != y - 66,
                x < y,
                x > y,
                x <= y,
                x >= y
            };

            return Result;
        }
    }
}
namespace tyuiu.cources.programming.interfaces.Sprint2
{
    // Token: 0x020003EE RID: 1006
    //[NullableContext(1)]
    public interface ISprint2Task0V8
    {
        // Token: 0x060003ED RID: 1005
        bool[] GetCompareOperations(int x, int y);
    }
}