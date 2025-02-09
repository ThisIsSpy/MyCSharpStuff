using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUnityTask.FiguresButInterface
{
    public class Parallelogram : ITetragon
    {
        private readonly float a;
        private readonly float b;
        private readonly float angle1;

        public Parallelogram(float a, float b, float angle1)
        {
            this.a = a;
            this.b = b;
            this.angle1 = angle1;
        }

        public void CountArea()
        {
            double area = a * b * Math.Sin(angle1);
            Console.WriteLine($"The area is {area}");
        }

        public void CountPerimeter()
        {
            float perimeter = (a + b) * 2;
            Console.WriteLine($"This is the perimeter: {perimeter}");
        }
    }
}
