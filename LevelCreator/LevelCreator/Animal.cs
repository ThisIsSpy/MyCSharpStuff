using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelCreator
{
    public abstract class Animal
    {
        public abstract int HP { get; set; }
        public abstract int SPD { get; set; }
        public abstract int DMG { get; set; }
        public abstract string MakeASound();
    }
}
