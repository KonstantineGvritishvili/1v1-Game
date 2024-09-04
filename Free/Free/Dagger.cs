using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free
{
    public class Dagger : Weapon
    {
        public Dagger()
        {
            Name = "Dagger";
        }

        public override int GetRandomDamage()
        {
            Random rand = new Random();
            return rand.Next(10, 41);
        }
    }
}
