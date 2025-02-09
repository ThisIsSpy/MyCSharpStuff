using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUnityTask.FiguresButInterface
{
    public class Square : ITetragon
    {
        private readonly float a;

        public Square(float a)
        {
            this.a = a;
        }

        public void CountArea()
        {
            float area = a * a;
            Console.WriteLine($"This is the area: {area}");
        }

        public void CountPerimeter()
        {
            float perimeter = a * 4;
            Console.WriteLine($"This is the perimeter: {perimeter}");
        }
    }
}
