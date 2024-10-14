using System.Numerics;

namespace BoxingUnboxingObjectingStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            List<object> objectList = new List<object>();
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                if(i%2 == 0)
                {
                    objectList.Add(rnd.Next(100));
                }
                else
                {
                    objectList.Add((float)rnd.NextDouble());
                }
            }
            Console.WriteLine(SumReturn(objectList));

            //task2
            Book<string> stringBook1 = new Book<string>("C# for dummies", 1, "Me", "001");
            Book<string> stringBook2 = new Book<string>("C# for elites", 10, "Not me", "002");
            Book<int> intBook1 = new Book<int>("ABC", 26, "Jesus Christ", 103);
            Book<int> intBook2 = new Book<int>("Bible", 1000, "Megatron", 104);
            Book<Guid> guidBook1 = new Book<Guid>("Guido Book about Tires", 69, "Guido", new Guid(1,2,3,4,5,6,7,8,9,0,10));
            Console.WriteLine(stringBook1.ToString());
            Console.WriteLine(stringBook2.ToString());
            Console.WriteLine(intBook1.ToString());
            Console.WriteLine(intBook2.ToString());
            Console.WriteLine(guidBook1.ToString());

            //task3
            ValueClass<int> intValueClass = new ValueClass<int>(10);
            ValueClass<Book<int>> bookValueClass = new ValueClass<Book<int>>(intBook1);
            Console.WriteLine(intValueClass.Value);
            Console.WriteLine(bookValueClass.Value);
            intValueClass.Reset();
            bookValueClass.Reset();
            Console.WriteLine(intValueClass.Value);
            Console.WriteLine(bookValueClass.Value);

            //task4
            Circle<int,int> circle1 = new Circle<int,int>(new Vector2(0,0),5);
            Circle<string, string> circle2 = new Circle<string, string>(new Vector2(0, 0), "7");
            Circle<double, double> circle3 = new Circle<double, double>(new Vector2(0, 0), 3.2);
            Circle<float, float> circle4 = new Circle<float, float>(new Vector2(0,0), 2.4f);
            circle1.SetRadius(6);
            circle2.SetRadius("8");
            circle3.SetRadius(2.3);
            circle4.SetRadius(4.2f);
            Console.WriteLine(circle1.Radius);
            Console.WriteLine(circle2.Radius);
            Console.WriteLine(circle3.Radius);
            Console.WriteLine(circle4.Radius);
            Console.WriteLine(circle1.Area);
            Console.WriteLine(circle2.Area);
            Console.WriteLine(circle3.Area);
            Console.WriteLine(circle4.Area);

            //task5
            Rectangle<string, int> rect1 = new Rectangle<string, int>(new Vector2(0, 0), "4", 2);
            Rectangle<float, double> rect2 = new Rectangle<float, double>(new Vector2(1.5f, 2.5f), 2.5f, 3.3);
            Rectangle<string, float> rect3 = new Rectangle<string, float>(new Vector2(-2,3),"3",4.2f);
            Console.WriteLine(rect1.MaxPoint);
            Console.WriteLine(rect1.MinPoint);
            Console.WriteLine(rect2.MaxPoint);
            Console.WriteLine(rect2.MinPoint);
            Console.WriteLine(rect3.MaxPoint);
            Console.WriteLine(rect3.MinPoint);
        }
        public static float SumReturn(List<object> list)
        {
            float sum = 0;
            float forObj = 0;
            foreach (object obj in list)
            {
                forObj = Convert.ToSingle(obj);
                sum += forObj;
            }
            return sum;
        }
    }
    public class Book<T>
    {
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public string Author { get; set; }
        public T Id { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name}, {Author}, {PagesCount} pages";
        }
        public Book(string name, int pagesCount, string author, T id)
        {
            Name = name;
            PagesCount = pagesCount;
            Author = author;
            Id = id;
        }
    }
    public class ValueClass<T>
    {
        private T _value;
        public T Value { get { return _value; } set { _value = value; } }
        public void Reset()
        {
            Value = default;
        }
        public ValueClass(T value)
        {
            Value = value;
        }
    }
    public class Figure
    {
        public Vector2 Center { get; set; }
        public virtual Vector2 MaxPoint { get; }
        public virtual Vector2 MinPoint { get; }
        public Figure(Vector2 center)
        {
            Center = center;
        }
    }
    public class Circle<T,K> : Figure
    {
        public T? Radius { get; set; }
        public double Area { get { return Math.PI*Math.Pow(Convert.ToDouble(Radius),2); } }
        public override Vector2 MaxPoint { get { return new(Center.X + Convert.ToSingle(Radius), Center.Y + Convert.ToSingle(Radius)); } }
        public override Vector2 MinPoint { get { return new(Center.X - Convert.ToSingle(Radius), Center.Y - Convert.ToSingle(Radius)); } }
        public void SetRadius(K? newRadius)
        {
            object obj = newRadius;
            Radius = (T?)obj;
        }

        public Circle(Vector2 center, T? radius) : base (center)
        {
            Center = center;
            Radius = radius;
        }
    }
    public class Rectangle<T,K> : Figure
    {
        public T? Width;
        public K? Height;
        public override Vector2 MaxPoint { get { return new(Center.X + Convert.ToSingle(Width), Center.Y + Convert.ToSingle(Height)); } }
        public override Vector2 MinPoint { get { return new(Center.X - Convert.ToSingle(Width), Center.Y - Convert.ToSingle(Height)); } }
        public Rectangle(Vector2 center, T? width, K? height): base(center)
        {
            Center = center;
            Width = width;
            Height = height;
        }
    }
    public class Square<T,K> : Rectangle<T,K>
    {
        public Square(Vector2 center, T? width, K? height) : base(center, width, height)
        {
            Width = width;
            object obj = width;
            Height = (K?)obj;
            Center = center;
        }
    }
}
