
namespace MethodOverriding
{
    public class Modern:Traditional
    {
        public override int CheckOddEven(int Number)
        {
            return Number & 1;
        }
    }
}
