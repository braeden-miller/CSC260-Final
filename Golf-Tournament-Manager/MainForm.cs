using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf_Tournament_Manager
{
    public partial class frmMain : Form
    {
        private Tournament tournament = new Tournament();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnEditTournament_Click(object sender, EventArgs e)
        {
            var tournamentForm = new frmEditTournament(tournament);
            if (tournamentForm.ShowDialog() == DialogResult.OK)
            {
                txtEventName.Text = tournament.Name;
                txtEventDate.Text = $"{tournament.StartDate.ToString("d")} - {tournament.EndDate.ToString("d")}";
                txtEventRounds.Text = tournament.Rounds.ToString();
            }
        }
    }
}
