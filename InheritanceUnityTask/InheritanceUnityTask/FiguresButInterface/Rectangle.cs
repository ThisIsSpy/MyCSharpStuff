using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUnityTask.FiguresButInterface
{
    public class Rectangle : ITetragon
    {
        private readonly float a;
        private readonly float b;

        public Rectangle(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public void CountArea()
        {
            float area = a * b;
            Console.WriteLine($"This is the area: {area}");
        }

        public void CountPerimeter()
        {
            float perimeter = (a + b) * 2;
            Console.WriteLine($"This is the perimeter: {perimeter}");
        }
    }
}
