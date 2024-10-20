using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeUsingFacadeDP.Controllers;
using TicTacToeUsingFacadeDP.Exceptions;
using TicTacToeUsingFacadeDP.Models;
using TicTacToeUsingFacadeDP.Types;

namespace TicTacToeUsingFacadeDP.Presentation
{
    internal class GameUI
    {
        public static void PlayGame()
        {
            /* *************** WELCOME TO TIC-TAC-TOE GAME *************** */

            Console.WriteLine($"\n*************** WELCOME TO TIC-TAC-TOE GAME USING FACADE DP ***************\n\n" +
                $"\nEnter The Players Details For Player1 and Player2\n");

            //Getting 2 Players ...& Taking UserInputs ...

            Player player1, player2; // Declaration of Players ...

            player1 = new Player(GetPlayerName(), MarkType.X);
            player2 = new Player(GetPlayerName(), MarkType.O);

            Console.WriteLine("\n********** PLAYER DETAILS **********\n");
            Console.WriteLine($"1. {player1}\n" +
                $"2. {player2}");

            StartGame(player1, player2);
        }

        // Starting Game with this StartGame() Method...
        static void StartGame(Player player1, Player player2)
        {
            Console.WriteLine("\n***** Game is Started.... *****\n");

            GameController gameController = new GameController();
            bool isActive = true;
            int choice = SelectPlayer(player1.PlayerName, player2.PlayerName);

            // Selecting The Player Based on User Choice...

            Player activePlayer = (choice == 1) ? player1 : player2;

            // Important Game State...! All the Turns Play Here in Loop 

            while (isActive) 
            {
                PlayerTurnInfo(activePlayer);
                PrintBoard.Print(gameController);
                int selectedCell = GetValidCellPosition(gameController.Board);
                Console.WriteLine(gameController.PlayTurn(activePlayer, selectedCell));
                if (gameController.IsGameOver)
                {
                    PrintBoard.Print(gameController);
                    gameController.ResetBoard();
                    isActive = false;
                }

                // Altering the Turns of Players...

                activePlayer = activePlayer == player1 ? player2 : player1;
            }

            CheckPlayAgainORNot();
        }

        static int SelectPlayer(string player1, string player2)
        {
            Console.WriteLine(
                $"Who Will Play The First Turn : 1.{player1} "
                    + $"2.{player2} (Enter 1 OR 2)\n"
            );

            return ChooseValidPlayer();
        }

        // For Print Turns Information ....
        static void PlayerTurnInfo(Player player)
        {
            Console.WriteLine(
                 $"{player.PlayerName}'s Turn | Mark of Player is : {player.GetMark()}\n" +
                 $"Enter 1 to 9 Number only To Choose Cell\n"
                     + $"NOTE : Enter Reset Code '1998' To Reset the Board (if you want)"
              );
        }

        static void CheckPlayAgainORNot()
        {
            Console.WriteLine("Do You Want To Play Again (Yes/No) ?");
            string userDecision = GetUserDecisionOnPlayAgain();
            if (userDecision == "yes")
                PlayGame();

            Console.WriteLine("\nSuccessfully Exited ... Thank You!\n\n");
        }

        //******* User Inputs ********
        //Following The DRY Principle :)
        static string GetPlayerName()
        {
            Console.WriteLine("Enter Player Name : ");
            return Console.ReadLine();
        }

        public static int ChooseValidPlayer()
        {
            try
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput != 1 && userInput != 2)
                    throw new InvalidInputException("Please Enter the Correct Input 1 Or 2.");
                return userInput;
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
                return ChooseValidPlayer();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ChooseValidPlayer();
            }
        }

        static int GetValidCellPosition(Board board)
        {
            try
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1998)
                    return userInput;
                else if (userInput < 1 || userInput > 9)
                    throw new InvalidInputException("Please Enter the Correct Input 1 to 9 Only.");
                else if (!board.Grid[userInput - 1].IsEmpty())
                    throw new CellNotEmptyException("\nThe Selected Cell is already Occupied Please Choose Another Cell");
                return userInput;
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
                return GetValidCellPosition(board);
            }
            catch (CellNotEmptyException ex)
            {
                Console.WriteLine(ex.Message);
                return GetValidCellPosition(board);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetValidCellPosition(board);
            }
        }

        public static string GetUserDecisionOnPlayAgain()
        {
            try
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "yes" || userInput == "no")
                    return userInput;
                throw new InvalidInputException("Invalid Input, Please Enter Yes or No only");
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
                return GetUserDecisionOnPlayAgain();
            }
        }
    }
}
