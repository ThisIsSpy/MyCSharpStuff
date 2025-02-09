using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUnityTask.Figures
{
    public class Square : Rectangle
    {

        public Square(float a) : base(a,a)
        {

        }

        public override void CountArea()
        {
            float area = a * a;
            Console.WriteLine($"This is the area: {area}");
        }
        public override void CountPerimeter()
        {
            float perimeter = a * 4;
            Console.WriteLine($"This is the perimeter: {perimeter}");
        }
    }
}
