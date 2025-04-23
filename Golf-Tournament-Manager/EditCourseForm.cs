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
    public partial class frmEditCourse : Form
    {
        private Course _course;
        public frmEditCourse(Course course)
        {
            InitializeComponent();
            _course = course;

            SetupForm();
        }

        private void SetupForm()
        {
            txtCourseName.Text = _course.Name;
            txtCourseLocation.Text = _course.Location;
            if (_course.CourseRating == 0)
                txtCourseRating.Text = "72.0";
            else
                txtCourseRating.Text = _course.CourseRating.ToString("0.0");
            if (_course.CourseRating == 0)
                numSlopeRating.Value = 120;
            else
                numSlopeRating.Value = _course.SlopeRating;

            foreach (var hole in _course.Holes)
            {
                dataHolePars.Rows.Add(hole.Number, hole.Par);
            }

            dataHolePars.CellClick += dataHolePars_CellClick;
        }

        private void dataHolePars_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            var selectedHole = _course.Holes[e.RowIndex];
            numHolePar.Value = selectedHole.Par;

            numHolePar.ValueChanged += numHolePar_ValueChanged;
        }

        private void numHolePar_ValueChanged(object sender, EventArgs e)
        {
            if (dataHolePars.SelectedRows.Count == 1)
            {
                int index = dataHolePars.SelectedRows[0].Index;
                dataHolePars.Rows[index].Cells[1].Value = numHolePar.Value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _course.Name = txtCourseName.Text;
            _course.Location = txtCourseLocation.Text;
            _course.TeesPlayed = txtTees.Text;

            if (double.TryParse(txtCourseRating.Text, out double courseRating))
                _course.CourseRating = courseRating;

            _course.SlopeRating = (int)numSlopeRating.Value;

            int holePar;
            int totalPar = 0;
            for (int i = 0; i < _course.Holes.Count; i++)
            {
                holePar = Convert.ToInt32(dataHolePars.Rows[i].Cells[1].Value);
                totalPar += holePar;
                _course.Holes[i].Par = holePar;
            }

            _course.TotalPar = totalPar;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
