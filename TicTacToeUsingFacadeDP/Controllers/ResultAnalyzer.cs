using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeUsingFacadeDP.Models;
using TicTacToeUsingFacadeDP.Types;

namespace TicTacToeUsingFacadeDP.Controllers
{
    internal class ResultAnalyzer
    {
        // Check Winner is Method Where I have Applied Facade Design Pattern...
        public static bool CheckWinner(Board board, MarkType playerMark)
        {
            Cell[] Grid = board.GetGrid(); 
            if(CheckRowsForWinner(Grid,playerMark) || 
               CheckColumnForWinner(Grid,playerMark) || 
               CheckDiagonalsForWinner(Grid, playerMark))
            return true;
            return false;
        }

        static bool CheckRowsForWinner(Cell[] Grid, MarkType playerMark)
        {
            return Grid[0].Mark == playerMark && Grid[1].Mark == playerMark && Grid[2].Mark == playerMark ||
                Grid[3].Mark == playerMark && Grid[4].Mark == playerMark && Grid[5].Mark == playerMark ||
                Grid[6].Mark == playerMark && Grid[7].Mark == playerMark && Grid[8].Mark == playerMark;
        }
        static bool CheckColumnForWinner(Cell[] Grid, MarkType playerMark)
        {
            return Grid[0].Mark == playerMark && Grid[3].Mark == playerMark && Grid[6].Mark == playerMark ||
                Grid[1].Mark == playerMark && Grid[4].Mark == playerMark && Grid[7].Mark == playerMark ||
                Grid[2].Mark == playerMark && Grid[5].Mark == playerMark && Grid[8].Mark == playerMark;
        }
        static bool CheckDiagonalsForWinner(Cell[] Grid, MarkType playerMark)
        {
            return Grid[0].Mark == playerMark && Grid[4].Mark == playerMark && Grid[8].Mark == playerMark ||
                Grid[2].Mark == playerMark && Grid[4].Mark == playerMark && Grid[6].Mark == playerMark;
        }
    }
}
