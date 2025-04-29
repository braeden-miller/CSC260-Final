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
    public partial class frmEnterScore : Form
    {
        private Golfer _golfer;
        private Course _course;
        private Tournament _tournament;
        private Round currentRound;
        private int _roundNum;
        private bool editMode = false;

        public frmEnterScore(Golfer golfer, Course course, Tournament tournament)
        {
            InitializeComponent();
            _golfer = golfer;
            _course = course;
            _tournament = tournament;
            currentRound = new Round();
            currentRound.HoleScores = new List<int>(new int[18]);
            for (int i = 0; i < 18; i++)
            {
                currentRound.HoleScores[i] = _course.Holes[i].Par;
            }
            InitializeForm();
        }

        public frmEnterScore(Golfer golfer, Course course, Tournament tournament, int roundNum)
        {
            InitializeComponent();
            _golfer = golfer;
            _course = course;
            _tournament = tournament;
            _roundNum = roundNum;
            currentRound = _golfer.Rounds[_roundNum];
            editMode = true;
            InitializeForm();
        }

        private void InitializeForm()
        {
            txtGolferName.Text = _golfer.FirstName + " " + _golfer.LastName;
            if (_golfer.HandicapIndex < 0)
                txtHandicapIndex.Text = "+" + (_golfer.HandicapIndex * -1).ToString("0.0");
            else if (_golfer.HandicapIndex > 0)
                txtHandicapIndex.Text = (_golfer.HandicapIndex * -1).ToString("0.0");
            else
                txtHandicapIndex.Text = "0.0";
            tblHoleScores.Rows.Clear();
            for (int i = 0; i < 18; i++)
            {
                tblHoleScores.Rows.Add(i + 1, _course.Holes[i].Par, currentRound.HoleScores[i]);
            }
            tblHoleScores.Rows[0].Selected = true;
            tblHoleScores.CurrentCell = tblHoleScores.Rows[0].Cells["HoleScore"];
            numHoleScore.Value = Convert.ToInt32(tblHoleScores.Rows[0].Cells["HoleScore"].Value);

            UpdateForm();
        }

        private void UpdateForm()
        {
            int front = 0;
            int back = 0;

            for (int i = 0; i < 18; i++)
            {
                int score = Convert.ToInt32(tblHoleScores.Rows[i].Cells["HoleScore"].Value);
                if (i < 9)
                    front += score;
                else
                    back += score;
            }

            int gross = front + back;

            txtFrontNine.Text = front.ToString();
            txtBackNine.Text = back.ToString();
            txtGrossTotal.Text = gross.ToString();

            if (_tournament.Handicapped)
            {
                txtNetTotal.Visible = true;
                lblNetTotal.Visible = true;
                txtCourseHandicap.Visible = true;
                lblCourseHandicap.Visible = true;
            }
            else
            {
                txtNetTotal.Visible = false;
                lblNetTotal.Visible = false;
                txtCourseHandicap.Visible = false;
                lblCourseHandicap.Visible = false;
            }

            int courseHandicap = (int)Math.Round(_golfer.HandicapIndex * (_course.SlopeRating / 113.0) + (_course.CourseRating - _course.TotalPar));
            txtCourseHandicap.Text = courseHandicap.ToString();
            int net = gross - courseHandicap;
            txtNetTotal.Text = net.ToString();
        }

        public Round GetRound()
        {
            Round round = new Round();
            int gross = 0;

            round.HoleScores.Clear();

            for (int i = 0; i < 18; i++)
            {
                int score = Convert.ToInt32(tblHoleScores.Rows[i].Cells["HoleScore"].Value);
                round.HoleScores.Add(score);
                gross += score;
            }

            round.GrossScore = gross;
            round.GrossToPar = gross - _course.TotalPar;

            if (_tournament.Handicapped)
            {
                int courseHandicap = (int)Math.Round(_golfer.HandicapIndex * (_course.SlopeRating / 113.0) + (_course.CourseRating - _course.TotalPar));
                round.NetScore = gross - courseHandicap;
                round.NetToPar = (gross - courseHandicap) - _course.TotalPar;
            }
            else
            {
                round.NetScore = gross;
                round.NetToPar = gross - _course.TotalPar;
            }

            return round;
        }

        private void frmEnterScore_Load(object sender, EventArgs e)
        {

        }

        private void numHoleScore_ValueChanged(object sender, EventArgs e)
        {
            tblHoleScores.CurrentRow.Cells["HoleScore"].Value = numHoleScore.Value;
            UpdateForm();
        }

        private void tblHoleScores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int score = Convert.ToInt32(tblHoleScores.CurrentRow.Cells["HoleScore"].Value);
            numHoleScore.Value = score;
            UpdateForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            
            if (!editMode)
                _golfer.Rounds.Add(GetRound());
            else
                _golfer.Rounds[_roundNum] = GetRound();
            this.Close();
        }
    }
}
