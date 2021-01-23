using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberofIslands200
{
     class Program
     {
          static void Main(string[] args)
          {
               char[,] grid = {
                    {'1','1','1'},
                    {'1','1','0'},
                    {'1','1','1'},
               };
               /*
               var solution1 = new Solution1();
               Console.WriteLine("islandNum:{0}", solution1.NumIslands(grid));
               Console.WriteLine("=====================");
               */
               var solution2 = new Solution2();
               Console.WriteLine("islandNum:{0}",solution2.NumIslands(grid));
          }
     }

     //DFS (栈)
     public class Solution1
     {
          private struct RowColumPair
          {
               public int row { get;}
               public int col { get;}
               public RowColumPair(int row,int col)
               {
                    this.row = row;
                    this.col = col;
               }
          }

          public int NumIslands(char[,] grid)
          {
               int row=grid.GetLength(0);
               int col =grid.GetLength(1);
               int islandCount = 0;
               Console.WriteLine("row:{0} col:{1}",row,col);

               Stack<RowColumPair> landStack = new Stack<RowColumPair>();

               for (int r = 0; r < row; r++)
               {
                    for (int c = 0; c < col; c++)
                    {
                         if (grid[r,c]=='1')
                         {
                              islandCount++;
                              grid[r, c] = '0';
                              landStack.Push(new RowColumPair(r, c));
                              while (landStack.Count != 0)
                              {
                                   var landRC = landStack.Pop();
                                   var landR = landRC.row;
                                   var landC = landRC.col;
                                   if (landR - 1 >= 0 && grid[landR - 1, landC] == '1')
                                   {
                                        grid[landR - 1, landC] = '0';
                                        landStack.Push(new RowColumPair(landR - 1, landC));
                                   }
                                   if (landR + 1 < row && grid[landR + 1, landC] == '1')
                                   {
                                        grid[landR + 1, landC] = '0';
                                        landStack.Push(new RowColumPair(landR + 1, landC));
                                   }
                                   if (landC - 1 >= 0 && grid[landR, landC - 1] == '1')
                                   {
                                        grid[landR, landC - 1] = '0';
                                        landStack.Push(new RowColumPair(landR, landC - 1));
                                   }
                                   if (landC + 1 < col && grid[landR, landC + 1] == '1')
                                   {
                                        grid[landR, landC + 1] = '0';
                                        landStack.Push(new RowColumPair(landR, landC + 1));
                                   }
                              }
                         }
                    }
               }
               return islandCount;
          }
     }

     //BFS (队列)
     public class Solution2
     {
          private struct RowColumPair
          {
               public int row { get; }
               public int col { get; }
               public RowColumPair(int row, int col)
               {
                    this.row = row;
                    this.col = col;
               }
          }

          public int NumIslands(char[,] grid)
          {
               int row = grid.GetLength(0);
               int col = grid.GetLength(1);
               int islandCount = 0;
               Console.WriteLine("row:{0} col:{1}", row, col);

               Queue<RowColumPair> landQueue = new Queue<RowColumPair>();

               for (int r = 0; r < row; r++)
               {
                    for (int c = 0; c < col; c++)
                    {
                         if (grid[r, c] == '1')
                         {
                              islandCount++;
                              grid[r, c] = '0';
                              landQueue.Enqueue(new RowColumPair(r, c));
                              while (landQueue.Count != 0)
                              {
                                   var landRC = landQueue.Dequeue();
                                   var landR = landRC.row;
                                   var landC = landRC.col;
                                   if (landR - 1 >= 0 && grid[landR - 1, landC] == '1')
                                   {
                                        grid[landR - 1, landC] = '0';
                                        landQueue.Enqueue(new RowColumPair(landR - 1, landC));
                                   }
                                   if (landR + 1 < row && grid[landR + 1, landC] == '1')
                                   {
                                        grid[landR + 1, landC] = '0';
                                        landQueue.Enqueue(new RowColumPair(landR + 1, landC));
                                   }
                                   if (landC - 1 >= 0 && grid[landR, landC - 1] == '1')
                                   {
                                        grid[landR, landC - 1] = '0';
                                        landQueue.Enqueue(new RowColumPair(landR, landC - 1));
                                   }
                                   if (landC + 1 < col && grid[landR, landC + 1] == '1')
                                   {
                                        grid[landR, landC + 1] = '0';
                                        landQueue.Enqueue(new RowColumPair(landR, landC + 1));
                                   }
                              }
                         }
                    }
               }
               return islandCount;
          }
     }
}
