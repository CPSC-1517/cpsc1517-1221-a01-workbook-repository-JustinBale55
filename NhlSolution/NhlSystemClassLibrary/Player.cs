using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystemClassLibrary
{
    internal class Player
    {
        private int _playerNo;
        private string _name;
        private int _gamesPlayed;
        private int _goals;
        private int _Assists;
        private int _points;

        public Position Position { get; set; }

        public int PlayerNo
        {
            get
            {
                return _playerNo;
            }
            set
            {
                if (value < 0 || value > 98)
                {
                    throw new ArgumentException("Player Number must be between 1-98");
                }
                _playerNo = value;
            }
        }
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
                _name = value.Trim();
            }
        }
        public int GamesPlayed
        {
            get
            {
                return _gamesPlayed;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Games played must be greater than or equal to 0");
                }
                _gamesPlayed = value;
            }
        }
        public int Goals
        {
            get
            {
                return _goals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals must be greater than or equal to 0");
                }
                _goals = value;
            }
        }
        public int Assists
        {
            get
            {
                return _Assists;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Assists must be greater than or equal to 0");
                }
                _Assists = value;
            }
        }
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                //Not sure
                _points = value;
            }
        }







    }
}
