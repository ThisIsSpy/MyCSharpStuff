using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LevelCreator
{
    public class DifficultyLevel
    {
        public List<Bee> Bees;
        public List<Wolf> Wolves;
        public List<Bear> Bears;

        public DifficultyLevel(int difficulty)
        {
            Random rnd = new Random();
            switch (difficulty)
            {
                case 1:
                    Bees = new List<Bee>();
                    for (int i = 0; i < rnd.Next(1,10); i++)
                    {
                        Bees[i] = new();
                    }
                    break;
                case 2:
                    Bees = new List<Bee>();
                    Wolves = new List<Wolf>();
                    for (int i = 0; i < rnd.Next(5, 20); i++)
                    {
                        Bees[i] = new();
                    }
                    for (int i = 0; i < rnd.Next(5, 20); i++)
                    {
                        Wolves[i] = new();
                    }
                    break;
                case 3:
                    Bees = new List<Bee>();
                    Wolves = new List<Wolf>();
                    Bears = new List<Bear>();
                    for (int i = 0; i < rnd.Next(10, 45); i++)
                    {
                        Bees[i] = new();
                    }
                    for (int i = 0; i < rnd.Next(10, 45); i++)
                    {
                        Wolves[i] = new();
                    }
                    for (int i = 0; i < rnd.Next(10, 45); i++)
                    {
                        Bears[i] = new();
                    }
                    break;
                default:
                    return;
            }
        }
    }
}
