using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwanaGrandPrix
{
    public class Entrant
    {
        public int GroupKey {get; set; }
        public int CarNumber {get; set; }
        public string DriverName { get; set; }
        public decimal CarWeight { get; set; }
        private decimal FastTime;
        private decimal LastTime;

        public Entrant()
        {
            CarNumber = 1;
            this.GroupKey = 0;
            this.DriverName = "";
            this.CarWeight = 0;
            this.FastTime = 0;
            this.LastTime = 0;

        }

        public Entrant(int i, int gk)
        {
            this.CarNumber = i;
            this.GroupKey = gk;
            this.DriverName = "";
            this.CarWeight = 0;
            this.FastTime = 0;
            this.LastTime = 0;
            
        }
    }
}
