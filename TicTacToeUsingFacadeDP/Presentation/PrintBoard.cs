using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeUsingFacadeDP.Controllers;
using TicTacToeUsingFacadeDP.Models;
using TicTacToeUsingFacadeDP.Types;

namespace TicTacToeUsingFacadeDP.Presentation
{
    internal class PrintBoard
    {
        public static void Print(GameController gameController)
        {
            Cell[] Grid = gameController.Board.Grid;

            // Printing the Tic Tac Toe Game Board 
            string[] displayGrid =  GenerateDisplayGrid(Grid);

            Console.WriteLine($"\n*******************\n|  {displayGrid[0]}  |  {displayGrid[1]}  |  {displayGrid[2]} " +
                $" |\n|*****************|\n| " +
                $" {displayGrid[3]}  |  {displayGrid[4]}  |  {displayGrid[5]} " +
                $" |\n|*****************|\n|  " +
                $"{displayGrid[6]}  |  {displayGrid[7]}  |  {displayGrid[8]}  " +
                $"|\n*******************\n");
        }

        static string[] GenerateDisplayGrid(Cell[] Grid) 
        {
            string[] displayGrid = new string [Grid.Length];
            for (int i = 0; i < Grid.Length; i++) 
            {
               if (Grid[i].Mark == MarkType.EMPTY)
                displayGrid[i] = " ";
               else
                displayGrid[i] = Grid[i].Mark.ToString();
            }
            return displayGrid;
        }
    }
}
