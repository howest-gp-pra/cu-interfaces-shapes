
namespace Pra.Interfaces.Shapes.Core
{
    public class Rectangle : IShape
    {
        public float Length { get; }
        public float Width { get; }

        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }

        public float CalculateArea()
        {
            return Length * Width;
        }
    }

}
