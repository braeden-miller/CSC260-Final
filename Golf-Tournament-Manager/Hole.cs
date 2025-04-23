using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_Tournament_Manager
{
    public class Hole
    {
        public int Number {  get; set; }
        public int Par { get; set; }
        public int TotalScore { get; set; }
        public int TimesPlayed { get; set; }
    }
}
