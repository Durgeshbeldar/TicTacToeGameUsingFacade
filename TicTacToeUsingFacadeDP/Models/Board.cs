using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeUsingFacadeDP.Types;

namespace TicTacToeUsingFacadeDP.Models
{
    internal class Board
    {
        
        public Cell[] Grid = new Cell[9];

        public Board() 
        {
            for(int i = 0; i<Grid.Length; i++)
            {
                Grid[i] = new Cell();   
            }
        }
        public bool IsBoardFull()
        {
            foreach (Cell cell in Grid) 
            {
                if (cell.IsEmpty())
                    return false;
            }
            return true;
        }

        public void PlaceMark(int cellPosition,MarkType playerMark)
        {
            --cellPosition;
            Grid[cellPosition].Mark = playerMark;
        }
        public void ResetBoard()
        {
            for(int i = 0; i < Grid.Length; i++)
                Grid[i].Mark = MarkType.EMPTY; 
        }
        public Cell[] GetGrid()
        {
            return Grid;
        }
    }
}
