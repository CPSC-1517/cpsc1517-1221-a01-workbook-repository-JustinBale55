using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NhlSystemClassLibrary
{
    public class Team
    {
        //Define fully implemented properties with a backing field for: Name, City, Arena
        private string _name;
        private string _city;
        private string _arena;

        public string Name
        {
            get
            {
                return _name;
            } 
            set
            {
                //Validate new value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Name), "Name cannot be blank");
                }
                //Validate new value contains only letters a-z
                if (!value.Trim().All(i => char.IsLetter(i) || char.IsWhiteSpace(i)))
                {
                    throw new ArgumentException("Name can only contain letters");
                }
                //string lettersOnlyPattern = @"^[a-zA-Z]{1,}$";
                //if (!Regex.IsMatch(value, lettersOnlyPattern))
                //{
                //    throw new ArgumentException("Name can only contain letters.");
                //}
                _name = value.Trim(); //This removes leading "   hello" and trailing "hello   " white spaces
            }
        }
        public string City
        {
            get 
            { 
                return _city; 
            }
            set
            {
                //Verity that new value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(City), "City cannot be blank.");
                }
                //Verify that new value contains 3 or more characters
                if(value.Trim().Length < 3)
                {
                    throw new ArgumentException("City must contain 3 or more characters");
                }
                _city = value.Trim();
            }
        }  
        public string Arena
        {
            get
            {
                return _arena;
            }
            set
            {
                //Validate that new value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Arena), "Arena cannot be blank");
                }
                _arena = value.Trim();
            }
        }

        //Define auto-implemented properties for: Conference, Division
        public Conference Conference { get; set; }
        public Division Division { get; set; }

        public List<Player> players { get; private set; } = new List<Player>();


        //TODO: Add method to add a new Player
        //1) Validate newPlayer is not null
        //2) Validate newPlayer PlayerNo is not alredy on the players list
        public void AddPlayer(Player newPlayer)
        {
            if (newPlayer == null)
            {
                throw new ArgumentNullException(nameof(AddPlayer),"Player cannot be null");
            }
            foreach(var existingplayer in players)
            {
                if (newPlayer.PlayerNo == existingplayer.PlayerNo)
                {
                    throw new ArgumentException($"PlayerNo {newPlayer.PlayerNo} is already in the team");
                }
            }
            if (players.Count == 23)
            {
                throw new ArgumentException("Team is full. Cannot add anymore players");
            }
            players.Add(newPlayer);
        }

        //Greedy constructor
        public Team(string Name, string city, string arena, Conference conference, Division division)
        {
            this.Name = Name;
            City = city;
            Arena = arena;
            Conference = conference;
            Division = division;
            players = new List<Player>();

            //     OR
            //_name = Name;
        }
        public override string ToString()
        {
            return $"Name: {Name}, City: {City}, Arena: {Arena}, Conference: {Conference}, Division: {Division}";
        }

    }
}
