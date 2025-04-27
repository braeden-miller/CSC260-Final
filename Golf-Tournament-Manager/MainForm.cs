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
        private Course course = new Course();
        private List<Golfer> golfers = new List<Golfer>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void LeaderboardRefresh()
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

            tblLeaderboard.Sort(tblLeaderboard.Columns["Score"], ListSortDirection.Ascending);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LeaderboardRefresh();
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
                LeaderboardRefresh();
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
                txtCourseRating.Text = $"{course.CourseRating.ToString("0.0")}/{course.SlopeRating.ToString()}";
                txtCoursePar.Text = course.TotalPar.ToString();
                LeaderboardRefresh();
            }
        }

        private void btnAddGolfer_Click(object sender, EventArgs e)
        {
            var addGolferForm = new frmAddGolfer();
            if (addGolferForm.ShowDialog() == DialogResult.OK)
            {
                golfers.Add(addGolferForm.NewGolfer);
                LeaderboardRefresh();
            }
        }
    }
}
