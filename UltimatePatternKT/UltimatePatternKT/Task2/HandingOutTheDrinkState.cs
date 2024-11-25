using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task2
{
    public class HandingOutTheDrinkState : ICoffeeMachineState
    {
        public void InsertCoin()
        {
            Console.WriteLine("The coin has already been inserted");
        }
        public void SelectDrink()
        {
            Console.WriteLine("The drink has already been selected");
        }
        public void DispenseDrink()
        {
            Console.WriteLine("The drink has been dispensed");
        }
        public void Done()
        {
            Console.WriteLine("The machine cannot complete its job as the drink has not been dispensed yet");
        }
    }
}
