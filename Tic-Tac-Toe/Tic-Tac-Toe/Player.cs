using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Player
    {
        private string _playerName;
        private char _playerToken;

        public string PlayerName
        {
            get
            {
                return _playerName;
            }
            set
            {
                _playerName = value;
            }
        }
        public char PlayerToken
        {
            get
            {
                return _playerToken;
            }
            set
            {
                _playerToken = value;
            }
        }
    }
}
