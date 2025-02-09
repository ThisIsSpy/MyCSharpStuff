using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUnityTask.Figures
{
    public class Rectangle : Rhombus
    {
        public Rectangle(float a, float b) : base(a,b)
        {

        }

        public override void CountArea()
        {
            float area = a * b;
            Console.WriteLine($"This is the area: {area}");
        }
        public override void CountPerimeter()
        {
            float perimeter = (a+b)*2;
            Console.WriteLine($"This is the perimeter: {perimeter}");
        }
    }
}
