using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwanaGrandPrix
{
    class Championship
    {
        Entrant oChampion = new Entrant();
        System.Collections.ArrayList collDivisionChampions;
        List<Entrant> listEntrants;
        Division oCFDivision = new Division();
        Division oSparksDivision = new Division();
        Division oTnTDivision = new Division();

        public Championship()
        {
            collDivisionChampions = new System.Collections.ArrayList(); // ICollection<Entrant>;
            listEntrants = new List<Entrant>();
        }

        public void AddEntrant(Entrant oEntrant)
        {
            // for now just add entrants to various arrays/collections for testint

            collDivisionChampions.Add(oEntrant);
            listEntrants.Add(oEntrant);

            //add the entrant to the correct division
            switch (oEntrant.GroupKey)
            {
                case 1:
                     oCFDivision.AddEntrant(oEntrant);
                     break;
            //
            //    case 2:
            //        oSparksDivision.AddEntrant(oEntrant);
            //        break;
            //
            //    case 3:
            //        oTnTDivision.AddEntrant(oEntrant);
            //        break;
            }

        }
    }
}
