using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_Tournament_Manager
{
    public class Course
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string TeesPlayed { get; set; }
        public double CourseRating { get; set; }
        public int SlopeRating { get; set; }
        public int TotalPar { get; set; }

        public List<Hole> Holes { get; set; } = Enumerable.Range(1, 18)
            .Select(i => new Hole { Number = i, Par = 4 })
            .ToList();
    }
}
