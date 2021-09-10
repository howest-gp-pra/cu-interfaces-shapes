using System;

namespace Pra.Interfaces.Shapes.Core
{
    public class Circle : IShape
    {
        public float Radius { get; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float CalculateArea()
        {
            return (float)(Radius * Radius * Math.PI);
        }
    }

}
