using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free
{
    public class Player
    {
        public string Name { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Health { get; set; }
        public bool IsDefeated { get; set; }
        public int Ammo { get; set; }

        public void ChooseWeapon()
        {
            Console.WriteLine("Choose your weapon:");
            Console.WriteLine("1. Bow");
            Console.WriteLine("2. Gun");
            Console.WriteLine("3. Dagger");

            int weaponChoice = Convert.ToInt32(Console.ReadLine());

            switch (weaponChoice)
            {
                case 1:
                    EquippedWeapon = new Bow();
                    Ammo = 10;
                    break;
                case 2:
                    EquippedWeapon = new Gun();
                    Ammo = 5;
                    break;
                case 3:
                    EquippedWeapon = new Dagger();
                    Ammo = 12;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Equipping default weapon: Dagger.");
                    EquippedWeapon = new Dagger();
                    Ammo = 12;
                    break;
            }

            Console.WriteLine($"{Name} equipped {EquippedWeapon.Name} with {Ammo} rounds.");
        }

        public void Attack(Player target)
        {
            if (EquippedWeapon == null)
            {
                Console.WriteLine($"{Name} needs to equip a weapon first!");
                return;
            }

            if (Ammo <= 0)
            {
                Console.WriteLine($"{Name} is out of ammo! Reload or choose another action.");
                return;
            }

            Random rand = new Random();
            int hitChance = rand.Next(1, 50);

            if (hitChance < 10)
            {
                Console.WriteLine($"{Name} missed the shot!");
            }
            else
            {
                int damage = EquippedWeapon.GetRandomDamage();
                target.TakeDamage(damage);
                Ammo--;
            }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} took {damage} damage. Health remaining: {Health}");

            if (Health <= 0)
            {
                IsDefeated = true;
                Console.WriteLine($"{Name} has been defeated!");
            }
        }
    }
}
