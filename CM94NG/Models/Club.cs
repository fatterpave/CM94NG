using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using CM94NG.Utils;

namespace CM94NG.Models
{
    public class Club : ObservableObject
    {
        public Club()
        {
            CurrentSeason = new ClubSeason();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string StadiumName { get; set; }
        public int StadiumCapacity { get; set; }
        public string PrimaryColorHome { get; set; }
        public string SecondaryColorHome { get; set; }
        public string PrimaryColorAway { get; set; }
        public string SecondaryColorAway { get; set; }
        public Manager Manager { get; set; }
        public string City { get; set; }
        public long Funds { get; set; }
        public List<Player> Players { get; set; }
        public List<ClubSeason> PreviousSeasons { get; set; }
        public ClubSeason CurrentSeason { get; set; }
    }
}
