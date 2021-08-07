using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Team
    {
        public string Name { get; set; }    // class used to define team to stream given data structure 
        public string Ground { get; set; }
        public string Coach { get; set; }
        public int Year { get; set; }
        public string Region { get; set; }
        public List<Player> Players { get; set; }
        
        public Team(string name, string ground, string coach, int year, string region, List<Player> players)
        {
            Name = name;
            Ground = ground;
            Coach = coach;
            Year = year;
            Region = region;
            Players = players;
        }
        public Team()
        {
        }
    }
}
