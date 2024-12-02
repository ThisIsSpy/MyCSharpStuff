using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.MobSystem
{
    public class Monster : IMob
    {
        private int maxHp;
        private int hp;
        private int atk;
        private int critChance;
        private int dodgeChance;

        public int MaxHP
        {
            get { return maxHp; }
            set
            {
                if (value <= 0)
                {
                    maxHp = 1;
                }
                else
                {
                    maxHp = value;
                }
            }
        }
        public int HP
        {
            get { return hp; }
            set
            {
                if (value <= 0)
                {
                    hp = 0;
                }
                else if (value > maxHp)
                {
                    hp = maxHp;
                }
                else
                {
                    hp = value;
                }
            }
        }
        public int ATK
        {
            get { return atk; }
            set
            {
                if (value <= 0)
                {
                    atk = 1;
                }
                else
                {
                    atk = value;
                }
            }
        }
        public int CritChance
        {
            get { return critChance; }
            set
            {
                if (value <= 0)
                {
                    critChance = 1;
                }
                else
                {
                    critChance = value;
                }
            }
        }
        public int DodgeChance
        {
            get { return dodgeChance; }
            set
            {
                if (value < 0)
                {
                    dodgeChance = 1;
                }
                else if (value > 99)
                {
                    dodgeChance = 99;
                }
                else
                {
                    dodgeChance = value;
                }
            }
        }

        public Monster(int difficulty)
        {
            RandomStats(difficulty);
        }
        private void RandomStats(int difficulty)
        {
            Random rnd = new();
            switch (difficulty)
            {
                case 1:
                    MaxHP = rnd.Next(1, 75);
                    HP = MaxHP;
                    ATK = rnd.Next(1, 20);
                    CritChance = rnd.Next(1, 15);
                    DodgeChance = rnd.Next(0, 15);
                    break;
                case 2:
                    MaxHP = rnd.Next(1, 150);
                    HP = MaxHP;
                    ATK = rnd.Next(1, 50);
                    CritChance = rnd.Next(1, 33);
                    DodgeChance = rnd.Next(0, 33);
                    break;
                case 3:
                    MaxHP = rnd.Next(1, 250);
                    HP = MaxHP;
                    ATK = rnd.Next(1, 100);
                    CritChance = rnd.Next(1, 75);
                    DodgeChance = rnd.Next(0, 75);
                    break;
            }
        }
    }
}
