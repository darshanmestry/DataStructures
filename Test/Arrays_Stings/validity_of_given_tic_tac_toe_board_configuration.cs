using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class validity_of_given_tic_tac_toe_board_configuration
    {
        /*
         Input is given as a 1D array of size 9.
            Examples:

            Input: board[] =  {'X', 'X', 'O', 
                               'O', 'O', 'X',
                               'X', 'O', 'X'};
            Output: Valid

            Input: board[] =  {'O', 'X', 'X', 
                               'O', 'X', 'X',
                               'O', 'O', 'X'};
            Output: Invalid
            (Both X and O cannot win)

            Input: board[] =  {'O', 'X', ' ', 
                               ' ', ' ', ' ',
                               ' ', ' ', ' '};


          Approach
        1)  countX == countO or countX == countO + 1

        2)  If O is in win condition then check 
             a)     If X also wins, not valid
             b)     If xbox != obox , not valid

        3)  If X is in win condition then check if xCount is
             one more than oCount or not  
         */
        public validity_of_given_tic_tac_toe_board_configuration()
        {
            char[] board= {'X', 'X', 'O',
                          'O', 'O', 'X',
                          'X', 'O', 'X'};

            bool res = isValidTiTacBoard(board);
        }

        bool isValidTiTacBoard(char[] board)
        {
            char x = 'X';
            char o = 'O';
            //1st condtion:As x starts first. its count shud be equal to o or greater than o.
            int xCount = count(board, x);
            int oCount = count(board, o);

            if(xCount==oCount || xCount==oCount+1)
            {
                // 2nd condition: if o wins, then x shud not win. and xCount shud be equal to ocount
                if(isWin(board,o))
                {
                    if (isWin(board, x))
                        return false;

                    return xCount == oCount;
                }

                //3rd condition: if X wins  then xCount will be just one more than oCount
                if(isWin(board,x) && xCount==oCount+1)
                    return true;


                //this is for condtion when niether x nor o wins 
                return true;
            }
            return false;
        }


        //get the count of X and O
        int count(char[] board,char c)
        {
            int cnt = 0;
            for(int i=0;i<board.Length;i++)
            {
                if (board[i] == c)
                    cnt++;
            }
            return cnt;
        }

        bool isWin(char[] board,char c)
        {
            // matrix of of size 8x3
            //this matix stores the indexes of the board configuration
            int[,] winningConditions ={
                                        {0,1,2}, //first row
                                        {3,4,5}, //second row
                                        {6,7,8}, // thriw row
                                        {0,3,6}, //First col
                                        {1,4,7}, //second col
                                        {2,5,8}, //third col
                                        {0,4,8}, //First Diagonal
                                        {2,4,6}  //second diagonal
                                      };

            //Access the winningConditions matix row by row and check if all the index of the row has char c
            for(int i=0;i<8;i++)
            {
                int firstMove = winningConditions[i, 0];
                int secondMove = winningConditions[i, 1];
                int thirdMove = winningConditions[i, 2];

                if (board[firstMove] == c && board[secondMove] == c && board[thirdMove] == c)
                    return true;

            }
            return false;
        }
    }
}
