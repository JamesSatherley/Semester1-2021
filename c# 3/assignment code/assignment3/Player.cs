using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Player
    {
        public int Id { get; set; }    // class used to define player to stream given data structure 
        public int Height { get; set; }
        public int Weight { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Team { get; set; }
        public DateTime BirthDate { get; set; }
        public Player(int id, int height, int weight, string fname, string lname, string placeOfBirth, string team, DateTime birthDate)
        {
            Id = id;
            Height = height;
            Weight = weight;
            FName = fname;
            LName = lname;
            PlaceOfBirth = placeOfBirth;
            Team = team;
            BirthDate = birthDate;
        }

        public Player(int id, int height, int weight, string fname, string lname, string placeOfBirth, DateTime birthDate)
        {
            Id = id;
            Height = height;
            Weight = weight;
            FName = fname;
            LName = lname;
            PlaceOfBirth = placeOfBirth;
            BirthDate = birthDate;
        }
        public Player()
        {
        }
    }
}