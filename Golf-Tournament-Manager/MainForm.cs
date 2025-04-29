using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf_Tournament_Manager
{
    public partial class frmMain : Form
    {
        private Tournament tournament = new Tournament();
        private Course course = new Course();
        private List<Golfer> golfers = new List<Golfer>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void MainFormRefresh()
        {
            tblLeaderboard.Rows.Clear();
            tblLeaderboard.Columns.Clear();
            tblLeaderboard.Columns.Add("Place", "Place");
            tblLeaderboard.Columns.Add("Name", "Name");
            tblLeaderboard.Columns[1].FillWeight = 200;

            if (tournament.Handicapped)
            {
                tblLeaderboard.Columns.Add("Score", "Net Score");
                var sortedGolfers = golfers.OrderBy(g => g.NetScoreToPar).ToList();

                for (int i = 0; i < sortedGolfers.Count; i++)
                {
                    string formattedName = $"{sortedGolfers[i].FirstName[0]}. {sortedGolfers[i].LastName}";
                    if (i != 0 && sortedGolfers[i].NetScoreToPar == sortedGolfers[i - 1].NetScoreToPar)
                        tblLeaderboard.Rows.Add(" ", formattedName, sortedGolfers[i].NetScoreToPar);
                    else if (i != sortedGolfers.Count - 1 && sortedGolfers[i].NetScoreToPar == sortedGolfers[i + 1].NetScoreToPar)
                        tblLeaderboard.Rows.Add($"T{i + 1}", formattedName, sortedGolfers[i].NetScoreToPar);
                    else
                        tblLeaderboard.Rows.Add(i + 1, formattedName, sortedGolfers[i].NetScoreToPar);
                }
            }
            else
            {
                tblLeaderboard.Columns.Add("Score", "Gross Score");
                var sortedGolfers = golfers.OrderBy(g => g.GrossScoreToPar).ToList();

                for (int i = 0; i < sortedGolfers.Count; i++)
                {
                    string formattedName = $"{sortedGolfers[i].FirstName[0]}. {sortedGolfers[i].LastName}";
                    if (i != 0 && sortedGolfers[i].GrossScoreToPar == sortedGolfers[i - 1].GrossScoreToPar)
                        tblLeaderboard.Rows.Add(" ", formattedName, sortedGolfers[i].GrossScoreToPar);
                    else if (i != sortedGolfers.Count - 1 && sortedGolfers[i].GrossScoreToPar == sortedGolfers[i + 1].GrossScoreToPar)
                        tblLeaderboard.Rows.Add($"T{i + 1}", formattedName, sortedGolfers[i].GrossScoreToPar);
                    else
                        tblLeaderboard.Rows.Add(i + 1, formattedName, sortedGolfers[i].GrossScoreToPar);
                }
            }
            foreach (DataGridViewRow row in tblLeaderboard.Rows)
            {
                var score = row.Cells["Score"];
                if ((int)score.Value == 0)
                    score.Value = "E";
                else if ((int)score.Value > 0)
                    score.Value = "+" + score.Value;
            }

            tblLeaderboard.Columns["Place"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tblLeaderboard.Columns["Place"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tblLeaderboard.Columns["Place"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tblLeaderboard.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tblLeaderboard.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tblLeaderboard.Columns["Score"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tblLeaderboard.Columns["Score"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tblLeaderboard.Columns["Score"].SortMode = DataGridViewColumnSortMode.NotSortable;

            cmbGolferList.Items.Clear();
            foreach (var golfer in golfers)
                cmbGolferList.Items.Add(golfer.LastName + ", " + golfer.FirstName);
            if (cmbGolferList.Items.Count == 0)
            {
                btnEditGolfer.Enabled = false;
                btnDeleteGolfer.Enabled = false;
                cmbGolferList.Enabled = false;
                btnCreateScorecard.Enabled = false;
                cmbRoundList.Enabled = false;
                btnEditScorecard.Enabled = false;
                btnDeleteScorecard.Enabled = false;
            }
            else
            {
                btnEditGolfer.Enabled = true;
                btnDeleteGolfer.Enabled = true;
                cmbGolferList.Enabled = true;
                btnCreateScorecard.Enabled = true;
                cmbGolferList.SelectedIndex = 0;
            }
        }

        private Golfer GetGolfer()
        {
            string selected = cmbGolferList.SelectedItem.ToString();
            string last = selected.Substring(0, selected.IndexOf(','));
            string first = selected.Substring(selected.IndexOf(",") + 2, selected.Length - (last.Length + 2));
            foreach (var golfer in golfers)
            {
                if (first == golfer.FirstName.ToString() && last == golfer.LastName.ToString())
                {
                    return golfer;
                }
            }
            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MainFormRefresh();
        }

        private void btnEditTournament_Click(object sender, EventArgs e)
        {
            var tournamentForm = new frmEditTournament(tournament);
            if (tournamentForm.ShowDialog() == DialogResult.OK)
            {
                txtEventName.Text = tournament.Name;
                if (tournament.StartDate != tournament.EndDate)
                    txtEventDate.Text = $"{tournament.StartDate.ToString("d")} - {tournament.EndDate.ToString("d")}";
                else
                    txtEventDate.Text = tournament.StartDate.ToString("d");
                    txtEventRounds.Text = tournament.Rounds.ToString();
                MainFormRefresh();
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            var courseForm = new frmEditCourse(course);
            if (courseForm.ShowDialog() == DialogResult.OK)
            {
                txtCourseName.Text = course.Name;
                txtCourseLocation.Text = course.Location;
                txtTeesPlayed.Text = course.TeesPlayed;
                txtCourseRating.Text = $"{course.CourseRating.ToString("0.0")} / {course.SlopeRating.ToString()}";
                txtCoursePar.Text = course.TotalPar.ToString();
                MainFormRefresh();
            }
        }

        private void btnAddGolfer_Click(object sender, EventArgs e)
        {
            var addGolferForm = new frmAddGolfer();
            addGolferForm.Text = "Add Golfer";
            addGolferForm.btnAdd.Text = "Add";
            if (addGolferForm.ShowDialog() == DialogResult.OK)
            {
                golfers.Add(addGolferForm.NewGolfer);
                MainFormRefresh();
                cmbGolferList.SelectedItem = addGolferForm.NewGolfer.LastName + ", " + addGolferForm.NewGolfer.FirstName;
            }
        }

        private void btnEditGolfer_Click(object sender, EventArgs e)
        {
            Golfer selectedGolfer = GetGolfer();
            var editForm = new frmAddGolfer();

            editForm.txtFirstName.Text = selectedGolfer.FirstName;
            editForm.txtLastName.Text = selectedGolfer.LastName;
            editForm.numHandicap.Text = selectedGolfer.HandicapIndex.ToString();
            editForm.Text = "Edit Golfer";
            editForm.btnAdd.Text = "Edit";

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                selectedGolfer.FirstName = editForm.NewGolfer.FirstName;
                selectedGolfer.LastName = editForm.NewGolfer.LastName;
                selectedGolfer.HandicapIndex = editForm.NewGolfer.HandicapIndex;

                MainFormRefresh();
                cmbGolferList.SelectedItem = selectedGolfer.LastName + ", " + selectedGolfer.FirstName;
            }
        }

        private void btnDeleteGolfer_Click(object sender, EventArgs e)
        {

            Golfer golfer = GetGolfer();
            var confirmationForm = new frmConfirm();
            if (confirmationForm.ShowDialog() == DialogResult.OK)
            {
                golfers.Remove(golfer);
                MainFormRefresh();
            }
            if (cmbGolferList.Items.Count > 0)
                cmbGolferList.SelectedIndex = 0;
        }

        private void btnCreateScorecard_Click(object sender, EventArgs e)
        {
            Golfer selectedGolfer = GetGolfer();
            frmEnterScore enterScoreForm = new frmEnterScore(selectedGolfer, course, tournament);
            enterScoreForm.ShowDialog();
            MainFormRefresh();
        }

        private void cmbGolferList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set up round selection combo box and enable/disable controls as needed
            cmbRoundList.Items.Clear();
            Golfer selectedGolfer = GetGolfer();
            for (int i = 0; i < selectedGolfer.Rounds.Count; i++)
            {
                if (tournament.Handicapped)
                    cmbRoundList.Items.Add($"Round {i+1} ({selectedGolfer.Rounds[i].NetScore})");
                else
                    cmbRoundList.Items.Add($"Round {i + 1} ({selectedGolfer.Rounds[i].GrossScore})");
            }
            if (selectedGolfer.Rounds.Count > 0)
            {
                if (selectedGolfer.Rounds.Count < tournament.Rounds)
                    btnCreateScorecard.Enabled = true;
                else
                    btnCreateScorecard.Enabled = false;
                cmbRoundList.SelectedIndex = 0;
                cmbRoundList.Enabled = true;
                btnEditScorecard.Enabled = true;
                btnDeleteScorecard.Enabled = true;
            }
            else
            {
                cmbRoundList.Enabled = false;
                btnEditScorecard.Enabled = false;
                btnDeleteScorecard.Enabled = false;
            }

            
        }

        private void btnEditScorecard_Click(object sender, EventArgs e)
        {
            int roundNumber = cmbRoundList.SelectedIndex;
            Golfer selectedGolfer = GetGolfer();
            frmEnterScore enterScoreForm = new frmEnterScore(selectedGolfer, course, tournament, roundNumber);
            enterScoreForm.ShowDialog();
            MainFormRefresh();
        }

        private void btnDeleteScorecard_Click(object sender, EventArgs e)
        {
            Golfer selectedGolfer = GetGolfer();
            Round round = selectedGolfer.Rounds[cmbRoundList.SelectedIndex];
            frmConfirm confirmScorecardDelete = new frmConfirm();
            if (confirmScorecardDelete.ShowDialog() == DialogResult.OK)
            {
                selectedGolfer.Rounds.Remove(round);
                cmbGolferList_SelectedIndexChanged(sender, e);
                MainFormRefresh();
            }
        }
    }
}
