using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeUsingFacadeDP.Models;

namespace TicTacToeUsingFacadeDP.Controllers
{
    internal class GameController
    {
        public Board Board { get; set;}
        public bool IsGameOver { get; set; }

        public GameController() 
        {
            Board = new Board();
            IsGameOver = false;
        }

        public string PlayTurn(Player player, int selectedCell)
        {
            if (selectedCell == 1998)
            {
                ResetBoard();
                return $"\nThe Game Board Has Been Reset! Please Start Playing Again...\n";
            }

            Board.PlaceMark(selectedCell, player.GetMark());

            if (ResultAnalyzer.CheckWinner(Board, player.GetMark()))
            {
                IsGameOver = true;
                return $"\nCongratulations... {player.PlayerName}, You Won the Game...! :)\n";
            }
            else if (Board.IsBoardFull())
            {
                IsGameOver = true;
                return "\n The Game is Draw...! Try Again and Congrats to Both Players\n";
            }
            return $"\n{player.PlayerName} is Placed Mark {player.GetMark()} at Selected Cell Successfully\n";
        }

        public void ResetBoard() 
        {
            Board.ResetBoard();
        }
    }
}
