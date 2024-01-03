using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Tic-Tac-Toe board
namespace TicTacToe.Model {
    public class TTTboard {
        private bool?[,] board;
        private bool turn;
        private short winningMove=-1; //0=row, 1=column, 2=diagonal, 3=other diagonal

        public TTTboard() {
            turn = true;
            board = new bool?[3, 3];
        }

        //Returns X or O
        public string GetTurn() {
            return turn == true ? "X" : "O";
        }
        //Return short for winning move
        public short GetWinningMove() {
            return winningMove;
        }

        //When a button is clicked, add move to board
        public void PlayTurn(int x, int y) {
            board[x, y] = turn;
        }

        //Check if move just played is a winning move(return true if yes, false if no)
        public bool CheckTurn(int x, int y) {
            //Check row, column and both diagonal to see if they win
            //(for each i in CheckLine's for loop, look at board position)
            if (CheckLine(i => board[x, i], 0) || //Row
                CheckLine(i => board[i, y], 1) || //Column
                CheckLine(i => board[i, i], 2)  || //Diagonal
                CheckLine(i => board[i, 2 - i], 3) //Other diagonal
                ) {
                //Won
                return true;
            } else {
                //Has not won
                //Flip players turn, continue
                turn = !turn;
                return false;
            }
        }

        //Called by CheckTurn to check line
        private bool CheckLine(Func<int, bool?> getValue, short currentMove) {
            for (int i = 0; i < 3; i++) {
                if (getValue(i) != turn)
                    return false;
            }
            //Else, it is a winning move (return true)
            winningMove = currentMove;
            return true;
        }
    }
}
