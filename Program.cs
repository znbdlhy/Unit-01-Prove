using System;
using System.Collections.Generic;
namespace TicTacToe
{
    class Program
    {
        static void DiaplayTable(List<string>value)
        {
            Console.WriteLine($"{value[0]}|{value[1]}|{value[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{value[3]}|{value[4]}|{value[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{value[6]}|{value[7]}|{value[8]}");
        }

        static string DefinePlayer(int round, string player1, string player2)
        {
            string player = "";
            if (round % 2 == 1)
            {
                player = player1;
            }
            else
            {
                player = player2;
            }
            return player;
        }
        static List<string> ValueCollection()
        {
            List<string> value = new List<string>();
            for (int square = 1; square <= 10; square++)
            {
                value.Add(square.ToString());
            }
            return value;
        }

    
        static void ChangeSquare(int round, int square, List<string>value)
        {
            if (round % 2 == 1)
            {   
                value[square - 1] = "X";
            }
            else
            {
                value[square - 1] = "O";
            }
        }

        static void FindWinner(int round, string player1, string player2, List<string>value)
        {
            string player = DefinePlayer(round + 1, player1, player2);
            if ((value[0] == value[1] && value[1] == value[2]) 
                || (value[0] == value[1] && value[1] == value[2])
                || (value[3] == value[4] && value[4] == value[5])
                || (value[6] == value[7] && value[7] == value[8])
                || (value[0] == value[3] && value[3] == value[6])
                || (value[1] == value[4] && value[4] == value[7])
                || (value[0] == value[4] && value[4] == value[8])
                || (value[2] == value[4] && value[4] == value[6])
                ) 
            {
                Console.WriteLine($"{player} wins! Congratulation!");
                Environment.Exit(0);
            }

            else if (round == 10)
            {
                Console.WriteLine("It's drew");
                Environment.Exit(0);
            }
        }
        
        static void Main(string[] argu)
        {
        int round = 1;
        List<string> value = ValueCollection();
        Console.WriteLine("Welcome to play the Tic-Tac-Toe!");
        Console.Write("What is player1's name: ");
        string player1 = Console.ReadLine();
        Console.Write("What is player2's name: ");
        string player2 = Console.ReadLine();
        while(true)
            {
            DiaplayTable(value);
            FindWinner(round, player1, player2, value);
            string player = DefinePlayer(round, player1, player2);
            Console.Write($"it is {player}'s turn. Please choose a square (1-9): ");
            int square = int.Parse(Console.ReadLine());
            ChangeSquare(round, square, value);
            round += 1;
            }


        }

    }   
} 