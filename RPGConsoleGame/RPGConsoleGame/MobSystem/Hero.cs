using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.MobSystem
{
    public class Hero : IMob
    {
        private int specialty;
        private int maxHp;
        private int hp;
        private int atk;
        private int critChance;
        private int dodgeChance;
        private int xp;
        private int lvl;

        public int MaxHP { get { return maxHp; } 
            set 
            { 
                if(value <= 0)
                {
                    maxHp = 1;
                }
                else
                {
                    maxHp = value;
                }
            } 
        }
        public int HP { get { return hp; } 
            set 
            {
                if(value <= 0)
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
        public int ATK { get { return atk; } 
            set 
            {  
                if(value <= 0)
                {
                    atk = 1;
                }
                else
                {
                    atk = value;
                }
            } 
        }
        public int CritChance { get { return critChance; } 
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
        public int DodgeChance { get { return dodgeChance; }
            set
            {
                if(value < 0)
                {
                    dodgeChance = 1;
                }
                else if(value > 99)
                {
                    dodgeChance = 99;
                }
                else
                {
                    dodgeChance = value;
                }
            }
        }
        public int XP { get { return xp; }
            set 
            {
                if (value < 0)
                {
                    xp = 0;
                }
                else if(value >= 1000)
                {
                    LVL++;
                    Console.WriteLine($"Level Up! Your level is {LVL}");
                    xp = value-1000;
                    Random rnd = new();
                    switch (rnd.Next(1, 4))
                    {
                        case 1:
                            MaxHP += 10;
                            Console.WriteLine("The Hero's max HP was increased by 10!");
                            break;
                        case 2:
                            ATK += 3;
                            Console.WriteLine("The Hero's attack was increased by 3!");
                            break;
                        case 3:
                            CritChance += 1;
                            Console.WriteLine("The Hero's critical chance was increased by 1!");
                            break;
                    }
                }
                else
                {
                    xp = value;
                }
                Console.WriteLine($"XP left to level up: {1000-XP}");
            }
        }
        public int LVL { get { return lvl; }
            set
            {
                if(value < 1)
                { 
                    lvl = 1; 
                }
                else
                {
                    lvl = value;
                }
            }
        }

        public Hero(int specialty)
        {
            switch (specialty)
            {
                case 1:
                    MaxHP = 150;
                    HP = 150;
                    ATK = 30;
                    CritChance = 10;
                    DodgeChance = 5;
                    break;
                case 2:
                    MaxHP = 100;
                    HP = 100;
                    ATK = 55;
                    CritChance = 3;
                    DodgeChance = 10;
                    break;
                case 3:
                    MaxHP = 50;
                    HP = 50;
                    ATK = 35;
                    CritChance = 33;
                    DodgeChance = 25;
                    break;
            }
            LVL = 1;
        }
    }
}
