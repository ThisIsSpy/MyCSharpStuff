using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task2
{
    public class CoffeeMachineStateMachine : ICoffeeMachineState
    {
        public ICoffeeMachineState coffeeMachineState;

        public CoffeeMachineStateMachine()
        {
            coffeeMachineState = new AwaitingCoinState();
        }

        public void InsertCoin()
        {
            coffeeMachineState.InsertCoin();
            if (coffeeMachineState is AwaitingCoinState)
            {
                coffeeMachineState = new ChoosingTheDrinkState();
            }
        }
        public void SelectDrink()
        {
            coffeeMachineState.SelectDrink();
            if (coffeeMachineState is ChoosingTheDrinkState)
            {
                coffeeMachineState = new HandingOutTheDrinkState();
            }
        }
        public void DispenseDrink()
        {
            coffeeMachineState.DispenseDrink();
            if (coffeeMachineState is HandingOutTheDrinkState)
            {
                coffeeMachineState = new DoneState();
            }
        }
        public void Done()
        {
            coffeeMachineState.Done();
            if (coffeeMachineState is DoneState)
            {
                coffeeMachineState = new AwaitingCoinState();
            }
        }
    }
}
