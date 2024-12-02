using RPGConsoleGame.MobSystem;
using System.Threading.Channels;

namespace RPGConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(1000,150);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Hero's Adventure RPG!");
            Console.WriteLine("Let's create your character.");
            Console.WriteLine("Type 1 for the Warrior class, type 2 for the Magician class or type 3 for the Archer class");
            int specialty = 0;
            bool isDoneWithCharacter = false;
            while (!isDoneWithCharacter)
            {
                specialty = int.Parse(Console.ReadLine()!);
                if(specialty < 1 || specialty > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect number entered, try again");
                }
                else
                {
                    isDoneWithCharacter = true;
                }
            }
            Hero mc = new(specialty);
            Console.WriteLine("\nYour Hero's stats:");
            Console.WriteLine($"Max HP: {mc.MaxHP}");
            Console.WriteLine($"Attack: {mc.ATK}");
            Console.WriteLine($"Critical Chance: {mc.CritChance}");
            Console.WriteLine($"Dodge Chance: {mc.DodgeChance}\n");
            Console.WriteLine("Select your preferred difficulty");
            Console.WriteLine("Type 1 for Easy, type 2 for Medium or type 3 for Hard");
            int difficulty = 0;
            bool isDoneWithDifficulty = false;
            while(!isDoneWithDifficulty)
            {
                difficulty = int.Parse(Console.ReadLine()!);
                if (difficulty < 1 || difficulty > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect number entered, try again");
                }
                else
                {
                    isDoneWithDifficulty = true;
                }
            }
            Console.WriteLine("\nTo complete your adventure you must kill 15 monsters. With every kill you get XP to level up your Hero");
            int hpRegenLeft = 3;
            for(int i = 0; i <= 14; i++)
            {
                bool isMonsterDead = false;
                bool gotCrit = false;
                Monster monster = new(difficulty);
                Random rnd = new();
                string placeholder;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nMonster number {i+1}");
                Console.WriteLine($"Monster's stats:\n Monster's HP: {monster.HP}\n Monster's Attack: {monster.ATK}\n Monster's Critical Chance: {monster.CritChance}\n Monster's Dodge Chance: {monster.DodgeChance}");
                while (!isMonsterDead)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hero's turn! Press Enter to attack");
                    placeholder = Console.ReadLine();
                    do
                    {
                        if(rnd.Next(1,101) >= monster.DodgeChance)
                        {
                            if (rnd.Next(1, 101) <= mc.CritChance)
                            {
                                monster.HP -= mc.ATK * 3;
                                Console.WriteLine("Awesome! You got a critical hit! You get another turn!");
                                gotCrit = true;
                            }
                            else
                            {
                                monster.HP -= mc.ATK;
                                gotCrit = false;
                            }
                            Console.WriteLine("You hit the monster!");
                            if (monster.HP > 0)
                            {
                                Console.WriteLine($"Monster HP left: {monster.HP}");
                            }
                            else
                            {
                                int xp = 0;
                                switch (difficulty)
                                {
                                    case 1:
                                        xp = rnd.Next(100, 1001);
                                        break;
                                    case 2:
                                        xp = rnd.Next(50,333);
                                        break;
                                    case 3:
                                        xp = rnd.Next(25,100);
                                        break;
                                }
                                Console.WriteLine($"You killed the monster! You earned {xp} XP!");
                                mc.XP += xp;
                                if (mc.HP < mc.MaxHP && hpRegenLeft > 0)
                                {
                                    Console.WriteLine($"Your hero was hurt in battle. You have {hpRegenLeft} potions left. Do you want to regen 25% of your max HP? Type 1 if yes");
                                    placeholder = Console.ReadLine();
                                    if (placeholder == "1")
                                    {
                                        mc.HP += (int)(mc.MaxHP * 0.25f);
                                        hpRegenLeft--;
                                        Console.WriteLine($"HP regened successfully! Hero's HP: {mc.HP}");
                                    }
                                }
                                isMonsterDead = true;
                                gotCrit = false;
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Oh no! Your attack missed!");
                        }
                    }
                    while (gotCrit);
                    if (isMonsterDead)
                        continue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    gotCrit = false;
                    Console.WriteLine("Monster's turn now! Press Enter to continue.");
                    placeholder= Console.ReadLine();
                    do
                    {
                        if (rnd.Next(1, 101) <= monster.CritChance)
                        {
                            mc.HP -= monster.ATK * 3;
                            Console.WriteLine("Oh no! The monster got a critical hit! It has another turn!");
                            gotCrit = true;
                        }
                        else
                        {
                            mc.HP -= monster.ATK;
                            gotCrit = false;
                        }
                        Console.WriteLine("The monster hit you!");
                        if (mc.HP > 0)
                        {
                            Console.WriteLine($"Hero's HP left: {mc.HP}");
                        }
                        else
                        {
                            Console.WriteLine("You have died. Game Over. Press Enter to exit.");
                            Console.ForegroundColor = ConsoleColor.White;
                            placeholder = Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                    while(gotCrit);
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Congratulations! You have beat the game!");
            Console.WriteLine("Your final stats:");
            Console.WriteLine($"Hero's Max HP and current HP: {mc.MaxHP}, {mc.HP}");
            Console.WriteLine($"Hero's Attack: {mc.ATK}");
            Console.WriteLine($"Hero's Critical Chance: {mc.CritChance}");
            Console.WriteLine($"Hero's HP Regen potions: {hpRegenLeft}");
            Console.WriteLine($"Hero's Level and XP: LVL{mc.LVL}, {mc.XP}/1000");
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Press Enter to quit the game");
            string placeholder2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }
    }
}
