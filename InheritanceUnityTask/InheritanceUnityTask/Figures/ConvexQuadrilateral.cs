using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUnityTask.Figures
{
    public class ConvexQuadrilateral : Tetragon
    {
        public ConvexQuadrilateral(float a, float b, float c, float d, float angle1, float angle2) : base(a,b, c, d, angle1, angle2)
        {

        }

        public override void CountArea()
        {
            base.CountArea();
        }
        public override void CountPerimeter()
        {
            base.CountPerimeter();
        }
    }
}
