using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelCreator
{
    public class Wolf: Animal
    {
        private int _hp;
        private int _spd;
        private int _dmg;
        public override int HP { get { return _hp; } set { _hp = value; } }
        public override int SPD { get { return _spd; } set { _spd = value; } }
        public override int DMG { get { return _dmg; } set { _dmg = value; } }
        public override string MakeASound()
        {
            return "awooo";
        }
    }
}
