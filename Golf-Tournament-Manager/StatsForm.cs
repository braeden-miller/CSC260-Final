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
    public partial class frmGolferStats : Form
    {
        private List<Golfer> _golfers;
        private Course _course;
        private bool _isHandicapped;
        private int _rounds;
        public frmGolferStats(List<Golfer> golfers, Course course, bool isHandicapped, int rounds)
        {
            InitializeComponent();
            _golfers = golfers;
            _course = course;
            _rounds = rounds;
            _isHandicapped = isHandicapped;
            if (!_isHandicapped)
            {
                lblCourseHandicap.Visible = false;
                lblHandicapIndex.Visible = false;
                txtCourseHandicap.Visible = false;
                txtHandicapIndex.Visible = false;
            }
            InitializeForm();
        }

        private Golfer GetGolfer()
        {
            string selected = cmbGolferList.SelectedItem.ToString();
            string last = selected.Substring(0, selected.IndexOf(','));
            string first = selected.Substring(selected.IndexOf(",") + 2, selected.Length - (last.Length + 2));
            foreach (var golfer in _golfers)
            {
                if (first == golfer.FirstName.ToString() && last == golfer.LastName.ToString())
                {
                    return golfer;
                }
            }
            return null;
        }

        private void InitializeForm()
        {
            foreach (Golfer golfer in _golfers)
            {
                cmbGolferList.Items.Add($"{golfer.LastName}, {golfer.FirstName}");
            }
            cmbGolferList.SelectedIndex = 0;
        }

        private void PrintPars()
        {
            txtStatsDisplay.AppendText("    Par   ");
            int parTotal = 0;
            for (int i = 0; i < 9; i++)
            {
                txtStatsDisplay.AppendText(_course.Holes[i].Par.ToString().PadLeft(4));
                parTotal += _course.Holes[i].Par;
            }
            txtStatsDisplay.AppendText(parTotal.ToString().PadLeft(5));
            parTotal = 0;
            for (int i = 9; i < 18; i++)
            {
                txtStatsDisplay.AppendText(_course.Holes[i].Par.ToString().PadLeft(4));
                parTotal += _course.Holes[i].Par;
            }
            txtStatsDisplay.AppendText(parTotal.ToString().PadLeft(5));
            txtStatsDisplay.AppendText(_course.TotalPar.ToString().PadLeft(7));
            txtStatsDisplay.AppendText("\n\n");
        }

        private void PrintRound(Golfer golfer, int round)
        {
            txtStatsDisplay.AppendText($"   Round {round+1}");
            int nineTotal = 0;
            for (int i = 0; i < 9; i++)
            {
                txtStatsDisplay.AppendText(golfer.Rounds[round].HoleScores[i].ToString().PadLeft(4));
                nineTotal += golfer.Rounds[round].HoleScores[i];
            }
            txtStatsDisplay.AppendText(nineTotal.ToString().PadLeft(5));
            nineTotal = 0;
            for (int i = 9; i < 18; i++)
            {
                txtStatsDisplay.AppendText(golfer.Rounds[round].HoleScores[i].ToString().PadLeft(4));
                nineTotal += golfer.Rounds[round].HoleScores[i];
            }
            txtStatsDisplay.AppendText(nineTotal.ToString().PadLeft(5));
            txtStatsDisplay.AppendText(golfer.Rounds[round].GrossScore.ToString().PadLeft(7));
            if (_isHandicapped)
            {
                int net = golfer.Rounds[round].NetScore;
                txtStatsDisplay.AppendText(net.ToString().PadLeft(7));
                if (net > _course.TotalPar)
                    txtStatsDisplay.AppendText($"+{net - _course.TotalPar}".PadLeft(7));
                else if ( net ==  _course.TotalPar)
                    txtStatsDisplay.AppendText(" E".PadLeft(7));
                else
                    txtStatsDisplay.AppendText($"{net - _course.TotalPar}".PadLeft(7));
            }
            else
            {
                int gross = golfer.Rounds[round].GrossScore;
                if (gross > _course.TotalPar)
                    txtStatsDisplay.AppendText($"+{gross - _course.TotalPar}".PadLeft(7));
                else if (gross == _course.TotalPar)
                    txtStatsDisplay.AppendText(" E".PadLeft(7));
                else
                    txtStatsDisplay.AppendText($"{gross - _course.TotalPar}".PadLeft(7));
            }
            txtStatsDisplay.AppendText("\n");
        }

        private void PrintHoleStats(Golfer golfer)
        {
            txtStatsDisplay.AppendText($"   To Par ");
            int outToPar = 0;
            for (int i = 0; i < 9; i++)
            {
                int toPar = 0;
                foreach (Round round in golfer.Rounds)
                    toPar += round.HoleScores[i] - _course.Holes[i].Par;
                outToPar += toPar;

                if (toPar > 0)
                    txtStatsDisplay.AppendText($"+{toPar}".PadLeft(4));
                else if (toPar == 0)
                    txtStatsDisplay.AppendText("E".PadLeft(4));
                else
                    txtStatsDisplay.AppendText($"{toPar}".PadLeft(4));
            }
            if (outToPar > 0)
                txtStatsDisplay.AppendText($"+{outToPar}".PadLeft(5));
            else if (outToPar == 0)
                txtStatsDisplay.AppendText("E".PadLeft(5));
            else
                txtStatsDisplay.AppendText($"{outToPar}".PadLeft(5));
            int inToPar = 0;
            for (int i = 9; i < 18; i++)
            {
                int toPar = 0;
                foreach (Round round in golfer.Rounds)
                    toPar += round.HoleScores[i] - _course.Holes[i].Par;
                inToPar += toPar;

                if (toPar > 0)
                    txtStatsDisplay.AppendText($"+{toPar}".PadLeft(4));
                else if (toPar == 0)
                    txtStatsDisplay.AppendText("E".PadLeft(4));
                else
                    txtStatsDisplay.AppendText($"{toPar}".PadLeft(4));
            }
            if (inToPar > 0)
                txtStatsDisplay.AppendText($"+{inToPar}".PadLeft(5));
            else if (inToPar == 0)
                txtStatsDisplay.AppendText("E".PadLeft(5));
            else
                txtStatsDisplay.AppendText($"{inToPar}".PadLeft(5));
            int totalToPar = outToPar + inToPar;
            if (totalToPar > 0)
                txtStatsDisplay.AppendText($"+{totalToPar}".PadLeft(7));
            else if (totalToPar == 0)
                txtStatsDisplay.AppendText("E".PadLeft(7));
            else
                txtStatsDisplay.AppendText($"{totalToPar}".PadLeft(7));

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbGolferList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int doubleWorse = 0;
            int bogeys = 0;
            int pars = 0;
            int birdies = 0;
            int eagleBetter = 0;
            int toPar;
            Golfer golfer = GetGolfer();
            if (golfer.HandicapIndex > 0)
                txtHandicapIndex.Text = (golfer.HandicapIndex * -1).ToString();
            else if (golfer.HandicapIndex < 0)
                txtHandicapIndex.Text = $"+{golfer.HandicapIndex * -1}";
            else
                txtHandicapIndex.Text = golfer.HandicapIndex.ToString();

            txtCourseHandicap.Text = ((int)Math.Round(golfer.HandicapIndex * (_course.SlopeRating / 113.0) + (_course.CourseRating - _course.TotalPar))).ToString();
            if (_isHandicapped)
            {
                txtStatsDisplay.Text = "    Hole     1   2   3   4   5   6   7   8   9  Out  10  11  12  13  14  15  16  17  18   In   Gross   Net   To Par\n";
                toPar = golfer.NetScoreToPar;
            }
            else
            {
                txtStatsDisplay.Text = "    Hole     1   2   3   4   5   6   7   8   9  Out  10  11  12  13  14  15  16  17  18   In   Gross  To Par\n";
                toPar = golfer.GrossScoreToPar;
            }
            if (toPar > 0)
                txtToPar.Text = $"+{toPar}";
            else if (toPar == 0)
                txtToPar.Text = "E";
            else
                txtToPar.Text = $"{toPar}";
            PrintPars();
            for (int i = 0; i < golfer.Rounds.Count; i++)
            {
                PrintRound(golfer, i);
                for (int k = 0; k < 18; k++)
                {
                    int holeToPar = golfer.Rounds[i].HoleScores[k] - _course.Holes[k].Par;
                    if (holeToPar >= 2)
                        doubleWorse++;
                    else if (holeToPar == 1)
                        bogeys++;
                    else if (holeToPar == 0)
                        pars++;
                    else if (holeToPar == -1)
                        birdies++;
                    else if (holeToPar <= -2)
                        eagleBetter++;
                }
            }
            txtStatsDisplay.AppendText("\n");
            PrintHoleStats(golfer);
            txtStatsDisplay.AppendText($"\n\n     Eagles or better: {eagleBetter}  Birdies: {birdies}  Pars: {pars}  Bogeys: {bogeys}  Doubles or worse: {doubleWorse}");
        }

        private void chkTournamentStats_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkTournamentStats.Checked)
            {
                cmbGolferList.Enabled = true;
                cmbGolferList_SelectedIndexChanged(sender, e);
            }
            else
            {
                cmbGolferList.Enabled = false;
                txtCourseHandicap.Clear();
                txtHandicapIndex.Clear();
                txtToPar.Clear();
                string[] lines = { "      Hole    ", "      Par     ", "     To Par   ", " Average Score" };
                int rounds = 0;
                foreach (Golfer golfer in _golfers)
                    rounds += golfer.Rounds.Count();
                if (rounds == 0)
                    rounds = 1;
;
                for (int i = 0; i < 18; i++)
                {
                    int holeScore = 0;
                    lines[0] += $"{i + 1}".PadLeft(5);
                    lines[1] += $"{_course.Holes[i].Par}".PadLeft(5);
                    foreach (Golfer golfer in _golfers)
                        foreach (Round round in golfer.Rounds)
                            holeScore += round.HoleScores[i];
                    int holeToPar = holeScore - (_course.Holes[i].Par * rounds);
                    if (holeToPar > 0)
                        lines[2] += $"+{holeToPar}".PadLeft(5);
                    else if (holeToPar == 0)
                        lines[2] += $"E".PadLeft(5);
                    else
                        lines[2] += $"{holeToPar}".PadLeft(5);
                    double holeAvg = holeScore / rounds;
                    lines[3] += $"{holeAvg:0.0}".PadLeft(5);
                }

                txtStatsDisplay.Text = $"{lines[0]}\n{lines[1]}\n{lines[2]}\n{lines[3]}\n";
            }
        }
    }
}
