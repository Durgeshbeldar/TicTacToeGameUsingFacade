using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeUsingFacadeDP.Types;

namespace TicTacToeUsingFacadeDP.Models
{
    internal class Player
    {
        public string PlayerName { get; set; }
        private MarkType _playerMark;

        public Player(string playerName, MarkType playerMark)
        {
            PlayerName = playerName;
            _playerMark = playerMark;
        }

        public MarkType GetMark()
        {
            return _playerMark;
        }
        public override string ToString()
        {
            return $"PLAYER NAME : {PlayerName} \n" +
                $"   PLAYER MARK : {_playerMark}\n";                
        }
    }
}
