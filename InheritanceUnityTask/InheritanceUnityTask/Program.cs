using InheritanceUnityTask.Figures;

namespace InheritanceUnityTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvexQuadrilateral c = new(1, 2, 3, 4, 60, 30);
            c.CountPerimeter();
            c.CountArea();
        }
    }
}
