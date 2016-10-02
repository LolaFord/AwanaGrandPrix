using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwanaGrandPrix
{
    public partial class Form1 : Form
    {
        Championship oChampionship;
        Division oDivision;
        Form oDisplayGrids;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oChampionship = new Championship();
            oDivision = new Division();
            oDisplayGrids = new DisplayGrids(oDivision);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iCarNo = Convert.ToInt32(tbxEntrantNumber.Text);

            //oEntrant.GroupKey = 1;

            Entrant oEntrant = new Entrant(iCarNo, 1);

            //if ok
            oEntrant.DriverName = tbxEntrantDriver.Text;
            oEntrant.CarWeight = Convert.ToDecimal(tbxCarWeight.Text);

            //write entrant to DB here, or call a service (use EF)

            //add the entrant to the championship
            oChampionship.AddEntrant(oEntrant);

        }

        private void btnTestSeries_Click(object sender, EventArgs e)
        {
            oDivision.CreateTestSeries();

            oDivision.DisperseEntrants();

        }

        private void btnNewSeries_Click(object sender, EventArgs e)
        {
            oDivision.MakeNewRound();
            //oDivision.MakeTestRound(arrRound1);
        }

        private void btnShowGrid_Click(object sender, EventArgs e)
        {
            this.Hide();
            oDisplayGrids.Visible = true;
            //oDisplayGrids.;
        }
    }
}
