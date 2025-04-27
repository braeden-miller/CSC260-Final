using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_Tournament_Manager
{
    public class Golfer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double HandicapIndex { get; set; }
        public List<Round> Rounds { get; set; } = new List<Round>();

        public int NetScoreToPar => Rounds.Sum(r => r.NetToPar);

        public int GrossScoreToPar => Rounds.Sum(r => r.GrossToPar);
    }
}
