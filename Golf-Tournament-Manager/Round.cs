using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_Tournament_Manager
{
    public class Round
    {
        public Course Course { get; set; }
        public Golfer Golfer { get; set; }

        public List<int> HoleScores { get; set; } = new List<int>(new int[18]);
        public int GrossScore => HoleScores.Sum();
        public int CourseHandicap => (int)Math.Round(Golfer.HandicapIndex * Course.SlopeRating / 113.0);
        public int NetScore => GrossScore - CourseHandicap;
        public int NetToPar => NetScore - Course.Holes.Sum(h => h.Par);
        public int GrossToPar => GrossScore - Course.Holes.Sum(h => h.Par);
    }
}
