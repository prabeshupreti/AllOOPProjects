
namespace InterfaceExample
{
    public class Square : IShape
    {
        public double Length { get; set; }

        public Square(int Length)
        {
            this.Length = Length;
        }

        public double Area()
        {
            return Length * Length;
        }
        public double Perimeter() 
        {
            return 4 * Length;
        }
    }
}
