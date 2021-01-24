using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurroundedRegions130
{
     class Program
     {
          static void Main(string[] args)
          {
               char[,] board = {
                    { 'X', 'O', 'X', 'O', 'X', 'O' },
                    { 'O', 'X', 'O', 'X', 'O', 'X' },
                    { 'X', 'O', 'X', 'O', 'X', 'O' }
               };
               for (int r = 0; r < board.GetLength(0); r++)
               {
                    for (int c = 0; c < board.GetLength(1); c++)
                    {
                         Console.Write("{0} ", board[r, c]);
                    }
                    Console.WriteLine('\n');
               }
               Console.WriteLine("==========");
               new Solution().Solve(board);
               for (int r = 0; r < board.GetLength(0); r++)
               {
                    for (int c = 0; c < board.GetLength(1); c++)
                    {
                         Console.Write("{0} ", board[r, c]);
                    }
                    Console.WriteLine('\n');
               }
          }
     }

     public class Solution
     {
          public void Solve(char[,] board)
          {
               if (board.GetLength(0) == 0)
               {
                    return;
               }
               int rowNum = board.GetLength(0);
               int colNum = board.GetLength(1);
               for (int r = 0; r < rowNum; r++)
               {
                    if (r == 0 || r == rowNum - 1)
                    {
                         for (int c = 0; c < colNum; c++)
                         {
                              if (board[r, c] == 'O')
                              {
                                   DFSSearch(r, c, board);
                              }
                         }
                    }
                    else
                    {
                         if (board[r, 0] == 'O')
                         {
                              DFSSearch(r, 0, board);
                         }
                         if (board[r, colNum - 1] == 'O')
                         {
                              DFSSearch(r, colNum - 1, board);
                         }
                    }
               }
               endingWork(board);
          }

          ///<summary>
          ///寻找未被包围的'O',并将其刷成'I'
          ///</summary>
          private void DFSSearch(int r, int c, char[,] board)
          {
               board[r, c] = 'I';
               if (r - 1 >= 0 && board[r - 1, c] == 'O') DFSSearch(r - 1, c, board);
               if (r + 1 < board.GetLength(0) && board[r + 1, c] == 'O') DFSSearch(r + 1, c, board);
               if (c - 1 >= 0 && board[r, c - 1] == 'O') DFSSearch(r, c - 1, board);
               if (c + 1 < board.GetLength(1) && board[r, c + 1] == 'O') DFSSearch(r, c + 1, board);
          }

          ///<summary>
          ///收尾工作，现将表中剩余的'O'刷成'X'，再将表中'I'刷为'O'
          ///</summary>
          private void endingWork(char[,] board)
          {
               for (int r = 0; r < board.GetLength(0); r++)
               {
                    for (int c = 0; c < board.GetLength(1); c++)
                    {
                         if (board[r, c] == 'O')
                         {
                              board[r, c] = 'X';
                         }
                         if (board[r, c] == 'I')
                         {
                              board[r, c] = 'O';
                         }
                    }
               }
          }
     }
}
