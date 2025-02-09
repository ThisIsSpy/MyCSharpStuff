using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUnityTask.Figures
{
    public class Parallelogram : ConvexQuadrilateral
    {
        public Parallelogram(float a, float b, float angle1) : base(a, b, a, b, angle1, angle1)
        {

        }

        public override void CountArea()
        {
            double area = a*b*Math.Sin(angle1);
            Console.WriteLine($"The area is {area}");
        }
        public override void CountPerimeter()
        {
            float perimeter = (a + b) * 2;
            Console.WriteLine($"This is the perimeter: {perimeter}");
        }
    }
}
