using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_Tournament_Manager
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Rounds { get; set; }
        public Course Course { get; set; }
        public bool Handicapped { get; set; }
    }
}
