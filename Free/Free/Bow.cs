using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free
{
    public class Bow : Weapon
    {
        public Bow()
        {
            Name = "Bow";
        }

        public override int GetRandomDamage()
        {
            Random rand = new Random();
            return rand.Next(5, 40);
        }
    }
}
