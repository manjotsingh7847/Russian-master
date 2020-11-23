using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russianroulletegun
{
    public class Roullete
    {
        public int load; // Variable to hold the position of the bullet at the time of loading bullet in chamber
        public int spin_Bullet; // variable to hold position of the bullet after spinning the chamber
        public int Total_Fire = 6;//sets the total number of fire
        public int Point_Away = 2;//set the number of chances to shoot away bullet
        Random Rand = new Random();
        public void Load()
        {
            load = 1;
        }

        public void spin()
        {
            spin_Bullet = Rand.Next(1, 7); // assign random position between 1 to 6
        }

        public int Bulleteloop(int skip)
        {
            if (skip == 6)
            {
                skip = 1;
            }
            else
            {
                skip++;
            }
            return skip;
        }
    }
}
