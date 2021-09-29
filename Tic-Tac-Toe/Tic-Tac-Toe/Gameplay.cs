using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Gameplay
    {
        public void SayHello()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!\nTwo human players are required to play this game.");
        }
        public string GetName()
        {
            Console.WriteLine("\nPlease enter a player name: ");
            string userInput = Console.ReadLine();

            if (userInput.Length <= 1)
            {
                Console.WriteLine("\nThat's not a valid name!");
                return GetName();
            }

            userInput = char.ToUpper(userInput[0]) + userInput[1..];

            return userInput;
        }
        public char GetToken()
        {
            Console.WriteLine("Would you like to be 'X' or 'O'? ");
            char userToken = char.ToUpper(Convert.ToChar(Console.ReadLine()));

            if (userToken == 'X' || userToken == 'O')
            {
                Console.WriteLine($"Great! You selected {userToken}!");
                return userToken;
            }

            Console.WriteLine("Please enter a valid token. Choose either 'X' or 'O'");
            return GetToken();
        }
    }
}
