using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUnityTask.Figures
{
    public class Rhombus : Parallelogram
    {
        public Rhombus(float a, float angle1) : base(a,a,angle1)
        {
            
        }

        public override void CountArea()
        {
            double area = a * a * Math.Sin(angle1);
            Console.WriteLine($"This is the area: {area}");
        }
        public override void CountPerimeter()
        {
            float perimeter = a * 4;
            Console.WriteLine($"This is the perimeter: {perimeter}");
        }
    }
}
