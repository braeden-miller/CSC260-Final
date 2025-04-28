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
        public int GrossScore { get; set; }
        public int NetScore { get; set; }
        public int NetToPar { get; set; }
        public int GrossToPar { get; set; }
    }
}
