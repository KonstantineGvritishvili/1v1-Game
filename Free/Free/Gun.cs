using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free
{
    public class Gun : Weapon
    {
        public Gun()
        {
            Name = "Gun";
        }

        public override int GetRandomDamage()
        {
            Random rand = new Random();
            return rand.Next(20, 41);
        }
    }
}
