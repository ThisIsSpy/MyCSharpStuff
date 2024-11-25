using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task2
{
    public interface ICoffeeMachineState
    {
        public void InsertCoin();
        public void SelectDrink();
        public void DispenseDrink();
        public void Done();
    }
}
