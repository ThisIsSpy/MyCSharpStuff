using System.Security.Cryptography.X509Certificates;

namespace KT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Property[] propertyArr =
            [
                new Apartment(100000,50),
                new Apartment(2500000, 200),
                new Apartment(500000, 125),
                new Car(2340000, 2500),
                new Car(9990000, 5555),
                new Car(6906906, 4200),
                new Boat(5500000, 6500),
                new Boat(1234567, 7000),
                new CountryHouse(25500000, 300),
                new CountryHouse(40000000, 450),
            ];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(propertyArr[i].ToString());
            }
        }
    }
}
