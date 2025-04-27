using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Golf_Tournament_Manager
{

    public partial class frmEditTournament : Form
    {
        private Tournament _tournament;
        public frmEditTournament(Tournament tournament)
        {
            InitializeComponent();
            _tournament = tournament;
            txtEventName.Text = _tournament.Name;
            if (_tournament.StartDate < dateStart.MinDate)
            {
                dateStart.Value = DateTime.Today;
                dateStart.Checked = false;
            }
            else
            {
                dateStart.Value = _tournament.StartDate;
                dateStart.Checked = true;
            }
            if (_tournament.EndDate < dateEnd.MinDate)
            {
                dateEnd.Value = DateTime.Today;
                dateEnd.Checked = false;
            }
            else
            {
                dateEnd.Value = _tournament.EndDate;
                dateEnd.Checked = true;
            }

            if (tournament.Handicapped)
                chkHandicapp.Checked = true;
            else
                chkHandicapp.Checked = false;

                numRounds.Text = _tournament.Rounds.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _tournament.Name = txtEventName.Text;
            _tournament.StartDate = dateStart.Value;
            _tournament.EndDate = dateEnd.Value;
            _tournament.Rounds = Convert.ToInt32(numRounds.Value);
            _tournament.Handicapped = chkHandicapp.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
