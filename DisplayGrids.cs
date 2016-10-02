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
    public partial class DisplayGrids : Form
    {
        Division oDisplayDivision;

        public DisplayGrids()
        {
            InitializeComponent();
        }
        public DisplayGrids(Division oDiv)
        {
            InitializeComponent();
            oDisplayDivision = oDiv;
        }

        private void OnClick(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1)
                {
                    frm.Visible = true;
                    return;
                }
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.Visible = true;
            SetupHeatsDataGridView();
            PopulateHeatsDataGridView();
        }

        private void SetupHeatsDataGridView()
        {
            dgvHeats.ColumnCount = 4;
            dgvHeats.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvHeats.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHeats.ColumnHeadersDefaultCellStyle.Font = new Font(dgvHeats.Font, FontStyle.Bold);

            dgvHeats.Columns[0].Name = "Red";
            dgvHeats.Columns[1].Name = "Yellow";
            dgvHeats.Columns[2].Name = "Blue";
            dgvHeats.Columns[3].Name = "Green";
            dgvHeats.Columns[3].DefaultCellStyle.Font = new Font(dgvHeats.DefaultCellStyle.Font, FontStyle.Italic);
        }

        private void PopulateHeatsDataGridView()
        {
            string[] row = new string[4];
            
            //assume 5 races for now
            row = oDisplayDivision.GetSingleRaceList(1, 0);
            dgvHeats.Rows.Add(row);
            row = oDisplayDivision.GetSingleRaceList(1, 1);
            dgvHeats.Rows.Add(row);
            row = oDisplayDivision.GetSingleRaceList(1, 2);
            dgvHeats.Rows.Add(row);
            row = oDisplayDivision.GetSingleRaceList(1, 3);
            dgvHeats.Rows.Add(row);
            row = oDisplayDivision.GetSingleRaceList(1, 4);
            dgvHeats.Rows.Add(row);

            //dgvHeats.Columns[0].DisplayIndex = 3;
            //dgvHeats.Columns[1].DisplayIndex = 4;
            //dgvHeats.Columns[2].DisplayIndex = 0;
            //dgvHeats.Columns[3].DisplayIndex = 1;
            //dgvHeats.Columns[4].DisplayIndex = 2;
        }
    }
}
