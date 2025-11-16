
namespace MethodOverriding
{
    public class Traditional
    {
        public virtual int CheckOddEven(int Number) 
        {
            return (Number % 2 == 0)? 0 : 1;
        }
    }
}
