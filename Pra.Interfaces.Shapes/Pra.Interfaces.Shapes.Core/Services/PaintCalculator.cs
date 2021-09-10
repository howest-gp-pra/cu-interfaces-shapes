using System.Collections.Generic;

namespace Pra.Interfaces.Shapes.Core
{
    public class PaintCalculator
    {
        public float CalculateAmountOfPaintNeeded(List<IShape> shapes, float squareMetersPerLiter)
        {
            // calculate total area to paint
            float totalArea = 0;
            foreach(IShape shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }

            // calculate paint needed (liter) for total area
            return totalArea / squareMetersPerLiter;
        }
    }
}
