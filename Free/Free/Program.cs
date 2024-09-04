using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player firstPlayer = new Player();
            Console.WriteLine("Enter Player 1's name:");
            firstPlayer.Name = Console.ReadLine();
            firstPlayer.Health = 100;
            firstPlayer.IsDefeated = false;

            firstPlayer.ChooseWeapon();

            Player secondPlayer = new Player();
            Console.WriteLine("Enter Player 2's name:");
            secondPlayer.Name = Console.ReadLine();
            secondPlayer.Health = 100;
            secondPlayer.IsDefeated = false;

            secondPlayer.ChooseWeapon();

            while (!firstPlayer.IsDefeated && !secondPlayer.IsDefeated && (firstPlayer.Ammo > 0 || secondPlayer.Ammo > 0))
            {
                Console.WriteLine($"Choose the battle mode:");
                Console.WriteLine($"1. {firstPlayer.Name} attacks {secondPlayer.Name}");
                Console.WriteLine($"2. {secondPlayer.Name} attacks {firstPlayer.Name}");

                int battleChoice = Convert.ToInt32(Console.ReadLine());

                switch (battleChoice)
                {
                    case 1:
                        firstPlayer.Attack(secondPlayer);
                        break;
                    case 2:
                        secondPlayer.Attack(firstPlayer);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Battle canceled.");
                        break;
                }
            }

            if (firstPlayer.Ammo <= 0 && secondPlayer.Ammo <= 0)
            {
                Console.WriteLine("Both players are out of ammo. Game over!");
            }

        }
    }
}
