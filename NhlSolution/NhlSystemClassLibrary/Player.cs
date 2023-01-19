using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystemClassLibrary
{
    public class Player
    {
        const int MinPlayerMo = 1;
        const int MaxPlayerMo = 98;


        private int _playerNo;
        private string _playerName;
        private int _gamesPlayed;
        private int _goals;
        private int _assists;
        private int _points;

        public Position Position { get; private set; }

        public int PlayerNo
        {
            get => _playerNo;
            private set
            {
                if (value < MinPlayerMo || value > MaxPlayerMo)
                {
                    throw new ArgumentException($"Player Number must be between {MinPlayerMo} and {MaxPlayerMo}");
                }
                _playerNo = value;
            }
        }
        public string Name
        {
            get => _playerName;
            private set
            {
                //Validate new value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(Name), "Name cannot be blank");
                }
                _playerName = value.Trim();
            }
        }
        public int GamesPlayed
        {
            get => _gamesPlayed;
            protected set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException("Games played must be greater than or equal to 0");
                }
                _gamesPlayed = value;
            }
        }
        public int Goals
        {
            get => _goals;
            private set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException("Goals must be greater than or equal to 0");
                }
                _goals = value;
            }
        }
        public int Assists
        {
            get => _assists;
            private set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException("Assists must be greater than or equal to 0");
                }
                _assists = value;
            }
        }
        //public int Points => Goals + Assists; //Same as below code
        public int Points
        {
            get
            {
                return Goals + Points;
            }
        }

        public Player(int playerNo, string name, Position position)
        {
            _playerNo = playerNo;
            Name = name;
            Position = position;
        }
        public Player(int playerNo, string name, Position position, int gamesPlayed, int goals, int assists)
        {
            _playerNo = playerNo;
            Name = name;
            Position = position;
            GamesPlayed = gamesPlayed;
            Goals = goals;
            Assists = assists;
        }

        public void AddGamesPlayed()
        {
            GamesPlayed += 1;
        }
        public void AddGoals()
        {
            Goals += 1;
        }
        public void AddAssists()
        {
            Assists++;
        }







    }
}
