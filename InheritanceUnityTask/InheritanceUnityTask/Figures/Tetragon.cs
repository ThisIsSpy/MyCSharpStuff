using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUnityTask.Figures
{
    public abstract class Tetragon
    {
        protected readonly float a;
        protected readonly float b;
        protected readonly float c;
        protected readonly float d;
        protected readonly float angle1;
        protected readonly float angle2;

        public Tetragon(float a, float b, float c, float d, float angle1, float angle2)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.angle1 = angle1;
            this.angle2 = angle2;
        }

        public virtual void CountPerimeter()
        {
            float perimeter = a + b + c + d;
            Console.WriteLine($"The perimeter is {perimeter}");
        }
        public virtual void CountArea()
        {
            float perimeter = a + b + c + d;
            float s = perimeter / 2;
            double K = (s - a) * (s - b) * (s - c) * (s - d) - a * b * c * d * Math.Pow(Math.Cos((angle1 + angle2) / 2), 2);
            Console.WriteLine($"The area is {K}");
        }
    }
}
