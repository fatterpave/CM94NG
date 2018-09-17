using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM94NG.Models
{
    public class Player
    {
        public DateTime BirthDate { get; set; }
        public PlayerPersonality Personality { get; set; }
        public PlayerPosition Position { get; set; }
        public PlayerContract Contract { get; set; }
        public PlayerInjury Injury { get; set; }
        public decimal Average { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public List<PlayerHistory> PlayerHistory { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Passing { get; set; }
        public int Tackling { get; set; }
        public int Pace { get; set; }
        public int Heading { get; set; }
        public int Flair { get; set; }
        public int Creativity { get; set; }
        public int Stamina { get; set; }
        public int Influence { get; set; }
        public int Agility { get; set; }
        public int Strength { get; set; }
        public int Fitness { get; set; }
        public int WeeksNA { get; set; }
        public int Illness { get; set; }
        public int Morale { get; set; }
        public int CurrentSkill { get; set; }
        public int PotentialSkill { get; set; }
        public int GoalScoring { get; set; }
    }
}
