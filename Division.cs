using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwanaGrandPrix
{
    public class Division
    {
        System.Collections.ArrayList collFinalists = new System.Collections.ArrayList();
        System.Collections.ArrayList collSemiFinals = new System.Collections.ArrayList();

        //ICollection<Heat> oHeats;
        Entrant[,] arrRound1 = new Entrant[10, 4];
        Entrant[,] arrRound2 = new Entrant[10, 4];
        Entrant[,] arrRound3 = new Entrant[10, 4];
        int iRace = 0;
        int iLane = 0;
        int iEntrantCount = 0;

        public void AddEntrant(Entrant oEntrant)
        {
            arrRound1[iRace, iLane] = oEntrant;
            iLane++;

            if (iLane >= 4)
            {
                iRace++;
                iLane = 0;
            }

            iEntrantCount++;
        }

        public void CreateTestSeries()
        {
            int iEntrants = 18;

            for (int i = 1; i <= iEntrants; i++)
            {
                Entrant oEntrant = new Entrant();
                GetTestEntrant(i, oEntrant);
                AddEntrant(oEntrant);
            }

        }

        public void DisperseEntrants()
        {
            int iRemainder = 0;

            //If the number of entrants more than 8, adjust the races
            if (iEntrantCount > 4)
            {

                iRemainder = iEntrantCount % 4;

                switch (iRemainder)
                {
                    //This case adds 2 to the final race, and has 3 races of 3
                    case 1:
                        arrRound1[iRace, 1] = arrRound1[iRace - 1, 3];
                        arrRound1[iRace - 1, 3] = null;
                        if (iEntrantCount > 5)
                        { 
                            arrRound1[iRace, 2] = arrRound1[iRace - 2, 3];
                            arrRound1[iRace - 2, 3] = null;
                        }
                        break;

                    case 2:
                        arrRound1[iRace, 2] = arrRound1[iRace - 1, 3];
                        arrRound1[iRace - 1, 3] = null;
                        break;

                    //if there is no remainder, or 3, there is nothing to do.
                    default:
                        break;
                }
            }
        }

        public void MakeNewRound()
        {
            int iNewLane = 0;
            int iNewRace = 0;
             
            //do each race
            for (int j = 0; j <= 4; j++)
            { 
                //move by lanes down races...watch the bottom
                for (int i = 0; i < 4; i++)
                {
                    //lane 1 moves down 1, 2 down 2, 3, down 3, 4 roll
                    //everybody shifts to the right
                    if (i == 3)
                        iNewLane = 0;
                    else
                        iNewLane = i + 1;

                    iNewRace = j + i + 1;

                    if (iNewRace > 4)
                        iNewRace = iNewRace - (iRace + 1);
                     
                    arrRound2[iNewRace, iNewLane] = arrRound1[j, i];

                }
            }
        }

        public void MakeTestRound(Entrant[,] arrBase, Entrant[,] arrNew)
        {
            int iNewLane = 0;
            int iNewRace = 0;

            //do each race
            for (int j = 0; j <= 4; j++)
            {
                //move by lanes down races...watch the bottom
                for (int i = 0; i < 4; i++)
                {
                    //lane 1 moves down 1, 2 down 2, 3, down 3, 4 roll
                    //everybody shifts to the right
                    if (i == 3)
                        iNewLane = 0;
                    else
                        iNewLane = i + 1;

                    iNewRace = j + i + 1;

                    if (iNewRace > 4)
                        iNewRace = iNewRace - 5;

                    arrNew[iNewRace, iNewLane] = arrBase[j, i];

                }
            }
        }

        public string[] GetSingleRaceList(int iRound, int iRace)
        {
            string[] arrList = new string[4];
            
            for (int i = 0; i < 4; i++)
            {
                if (arrRound1[iRace, i] != null)
                    arrList[i] = arrRound1[iRace, i].CarNumber.ToString();
                else
                    arrList[i] = " ";
            }

            return arrList;
        }

        public void DoSemiFinal()
        {
        }

        private void GetTestEntrant(int iEntrantNumber, Entrant oEntrant)
        {
            switch (iEntrantNumber)
            {
                case 1:
                    oEntrant.CarNumber = 1;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Alex";
                    oEntrant.CarWeight = 4.01M;
                    break;

                case 2:
                    oEntrant.CarNumber = 2;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Brian";
                    oEntrant.CarWeight = 4.02M;
                    break;

                case 3:
                    oEntrant.CarNumber = 3;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Chris";
                    oEntrant.CarWeight = 4.03M;
                    break;

                case 4:
                    oEntrant.CarNumber = 4;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Dilbert";
                    oEntrant.CarWeight = 4.04M;
                    break;

                case 5:
                    oEntrant.CarNumber = 5;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Edward";
                    oEntrant.CarWeight = 4.05M;
                    break;

                case 6:
                    oEntrant.CarNumber = 6;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Frank";
                    oEntrant.CarWeight = 4.06M;
                    break;

                case 7:
                    oEntrant.CarNumber = 7;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "George";
                    oEntrant.CarWeight = 4.07M;
                    break;

                case 8:
                    oEntrant.CarNumber = 8;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Henry";
                    oEntrant.CarWeight = 4.08M;
                    break;

                case 9:
                    oEntrant.CarNumber = 9;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Isabella";
                    oEntrant.CarWeight = 4.09M;
                    break;

                case 10:
                    oEntrant.CarNumber = 10;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Jeremiah";
                    oEntrant.CarWeight = 4.10M;
                    break;

                case 11:
                    oEntrant.CarNumber = 11;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Katherine";
                    oEntrant.CarWeight = 4.11M;
                    break;

                case 12:
                    oEntrant.CarNumber = 12;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Leonard";
                    oEntrant.CarWeight = 4.12M;
                    break;

                case 13:
                    oEntrant.CarNumber = 13;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Michael";
                    oEntrant.CarWeight = 4.13M;
                    break;

                case 14:
                    oEntrant.CarNumber = 14;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Nancy";
                    oEntrant.CarWeight = 4.14M;
                    break;

                case 15:
                    oEntrant.CarNumber = 15;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Ophelia";
                    oEntrant.CarWeight = 4.15M;
                    break;

                case 16:
                    oEntrant.CarNumber = 16;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Paul";
                    oEntrant.CarWeight = 4.16M;
                    break;

                case 17:
                    oEntrant.CarNumber = 17;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Quentin";
                    oEntrant.CarWeight = 4.17M;
                    break;

                case 18:
                    oEntrant.CarNumber = 18;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Richard";
                    oEntrant.CarWeight = 4.18M;
                    break;

                case 19:
                    oEntrant.CarNumber = 19;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Sharon";
                    oEntrant.CarWeight = 4.19M;
                    break;

                case 20:
                    oEntrant.CarNumber = 20;
                    oEntrant.GroupKey = 1;
                    oEntrant.DriverName = "Thomas";
                    oEntrant.CarWeight = 4.20M;
                    break;

                default:

                    break;

            }

            return;
        }
    }
}
