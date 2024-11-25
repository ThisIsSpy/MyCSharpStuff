using System.Numerics;
using System.Drawing;
using UltimatePatternKT.Task1;
using System.Threading.Channels;
using UltimatePatternKT.Task2;
using UltimatePatternKT.Task3;
using UltimatePatternKT.Task4;
using UltimatePatternKT.Task5;

namespace UltimatePatternKT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            Sphere sphere1 = new(Vector3.Zero, new Vector3(1, 1, 1), Color.Black, 1);
            Sphere sphere2 = (Sphere)sphere1.Clone();
            Sphere sphere3 = (Sphere)sphere1.Clone();
            sphere2.Id = 2;
            sphere3.Id = 3;
            Console.WriteLine($"{sphere1.Id}, {sphere2.Id}, {sphere3.Id}");
            Console.WriteLine();
            //task2
            CoffeeMachineStateMachine machine = new CoffeeMachineStateMachine();
            Console.WriteLine("Type 1 to start the machine, Type anything else to start a malfunctioning machine");
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                machine.InsertCoin();
                machine.SelectDrink();
                machine.DispenseDrink();
                machine.Done();
            }
            else
            {
                machine.Done();
                machine.DispenseDrink();
                machine.SelectDrink();
                machine.InsertCoin();
            }
            Console.WriteLine();
            //task3
            BigBrother bigBrother = new();
            Me me = new(bigBrother);
            Myself myself = new(bigBrother);
            I i = new(bigBrother);
            bigBrother.RegisterMember(me);
            bigBrother.RegisterMember(myself);
            bigBrother.RegisterMember(i);
            me.Send("whatsup");
            myself.Send("telegram");
            i.Send("shut up idiots");
            //task4
            BaseOrder order = new();
            FastDeliveryOrder fastOrder = new(order);
            PackagingOrder packagingOrder = new(fastOrder);
            ExtraDrinkOrder extraDrinkOrder = new(packagingOrder);
            Console.WriteLine(extraDrinkOrder.GetPrice());
            Console.WriteLine(extraDrinkOrder.GetDescription());
            //task5
            RealService realService = new();
            ProxyService proxyService = new();
            realService.Construct(proxyService);
            proxyService.Construct(realService);
            Console.WriteLine(realService.GetData());
            Console.WriteLine(realService.GetData());

        }
    }
}
