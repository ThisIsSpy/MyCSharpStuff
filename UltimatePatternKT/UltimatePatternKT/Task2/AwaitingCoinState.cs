using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task2
{
    public class AwaitingCoinState : ICoffeeMachineState
    {
        public void InsertCoin()
        {
            Console.WriteLine("The coin has been inserted");
        }
        public void SelectDrink()
        {
            Console.WriteLine("Cannot select drink as the coin has not been inserted");
        }
        public void DispenseDrink()
        {
            Console.WriteLine("Cannot dispense drink as the coin has not been inserted and the drink has not been selected");
        }
        public void Done()
        {
            Console.WriteLine("The machine cannot complete its job as the coin has not been inserted and the drink has not been selected and dispensed");
        }
    }
}
