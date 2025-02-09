using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUnityTask.FiguresButInterface
{
    public class Rhombus : ITetragon
    {
        private readonly float a;
        private readonly float angle1;

        public Rhombus(float a, float angle1)
        {
            this.a = a;
            this.angle1 = angle1;
        }

        public void CountArea()
        {
            double area = a * a * Math.Sin(angle1);
            Console.WriteLine($"This is the area: {area}");
        }

        public void CountPerimeter()
        {
            float perimeter = a * 4;
            Console.WriteLine($"This is the perimeter: {perimeter}");
        }
    }
}
