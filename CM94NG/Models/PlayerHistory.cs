using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM94NG.Models
{
    public class PlayerHistory
    {
        public int Year { get; set; }
        public int ClubId { get; set; }
        public int Apps { get; set; }
        public int Goals { get; set; }
        public double Avg { get; set; }
    }
}
