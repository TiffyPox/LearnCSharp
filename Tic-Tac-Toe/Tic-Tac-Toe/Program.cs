using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main()
        {
            Gameplay newGame = new Gameplay();
            newGame.SayHello();

            var playerOne = new Player
            {
                PlayerName = newGame.GetName(),
                PlayerToken = newGame.GetToken()
            };

            var playerTwo = new Player
            {
                PlayerName = newGame.GetName(),
                PlayerToken = playerOne.PlayerToken == 'X' ? 'O' : 'X'
            };

            Console.WriteLine($"{playerTwo.PlayerName} you will be {playerTwo.PlayerToken}!");

            PlayGame(playerOne, playerTwo);

            Console.WriteLine("The game has ended");
        }

        static void PlayGame(Player player1, Player player2)
        {
            var currentPlayer = player1;

            Console.WriteLine("\nLet's Play! Player one goes first.");

            Board board = new Board();
            board.GetBoard();

            while (true)
            {
                Console.WriteLine($"Current player: {currentPlayer.PlayerName}");
                board.DisplayBoard();
                Console.WriteLine("Please select a position (1-9): ");
                var pos = int.Parse(Console.ReadLine());
                var placed = board.SetPosition(pos, currentPlayer.PlayerToken);

                if (!placed)
                {
                    Console.WriteLine("Invalid position, please choose again.");
                    continue;
                }

                if (board.CheckForWin())
                {
                    Console.WriteLine($"The winner is {currentPlayer.PlayerName}");
                    break;
                }
                if (board.CheckForDraw())
                {
                    Console.WriteLine("This game is a draw, there have been no winners.");
                    break;
                }

                currentPlayer = currentPlayer == player1 ? player2 : player1;
            }

            Console.WriteLine("Do you wanna play again? (Y/N)");

            if (Console.ReadLine().ToUpper() == "Y")
            {
                PlayGame(player1, player2);
            }
        }
    }
}
