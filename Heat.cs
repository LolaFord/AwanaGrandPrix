using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwanaGrandPrix
{
    class Heat
    {
        private ICollection<int> race;

        public bool AddEntrant(int carNo)
        {
            if (race.Count < 4)
                race.Add(carNo);
            else
                return false;
               
            return true;
        }
    }
}
