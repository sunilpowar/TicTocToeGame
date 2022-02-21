using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class TicTacToe
    {

        public void CreateBoard()
        {
            char[] board = new char[10];
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
           
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
        public void Choice()
        {

            Console.WriteLine("Choose Either X or O");
            char playerOne = Convert.ToChar(Console.ReadLine());
            char computerLetter;
            if (playerOne == 'X' || playerOne == 'O')
            {
                if (playerOne == 'X')
                {
                    computerLetter = 'O';
                }
                else if (playerOne == 'O')
                {
                    computerLetter = 'X';
                }
            }
            else
            {
                Console.WriteLine("Please choose either X or O");
                Choice();
            }

        }
    }
}
