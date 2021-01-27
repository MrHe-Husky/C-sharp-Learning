using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFindDisJointSetClassical
{
     class Program
     {
          static void Main(string[] args)
          {
               //测试用例1:如果有回路则输出"";无回路输出"";
               int[,] paths = new int[6, 2] { { 1, 2 }, { 3, 6 }, { 2, 3 }, { 2, 4 }, { 4, 5 }, { 3, 4 } };     ////此例存在回路
               //int[,] paths = new int[5, 2] { { 1, 2 }, { 3, 6 }, { 2, 3 }, { 2, 4 }, { 4, 5 } };               ////此例不存在回路
               var disjointset = new UnionFindDisjoinSets();
               bool existFlag = false;
               for (int i = 0; i < paths.GetLength(0); i++)
               {
                    if (!disjointset.UnionElement(paths[i, 0], paths[i, 1]))
                    {
                         existFlag = true;
                         break;
                    }
               }
               if (existFlag)
               {
                    Console.WriteLine("存在回路");
               }
               else
               {
                    Console.WriteLine("不存在回路");
               }
          }
     }


     /// <summary>
     /// Version1:
     /// 使用数组来做存储树的结构;输入格式为两个点{x,y};
     /// 作用:在一个无向图中检查是否出现了环
     /// Version2目标改进方面:路径压缩、能够保存所有集合的根节点。
     /// </summary>
     class UnionFindDisjoinSets_v1
     {
          Dictionary<int,int> disjointSets = new Dictionary<int,int>();

          //查找根节点函数,查
          public int FindRoot(int point)
          {
               if (!disjointSets.ContainsKey(point))//找不到它的上一节点(此节点即为根节点)
               {
                    return point;
               }
               while (disjointSets.ContainsKey(point))//存在上级节点(此点非根节点)，循环寻找直到根节点
               {
                    point = disjointSets[point];
               }
               return point;
          }

          //将连线AB加入，并
          public bool UnionElement(int pointA,int pointB)
          {
               int pointARoot = FindRoot(pointA);
               int pointBRoot = FindRoot(pointB);
               if (pointARoot==pointBRoot)
               {
                    return false;
               }
               disjointSets[pointB] = pointARoot;
               return true;
          }
     }

     /// <summary>
     /// Version2:
     /// 使用数组来做存储树的结构;输入格式为两个点{x,y};
     /// 作用:在一个无向图中检查是否出现了环
     /// Version2改进方面:路径压缩、能够保存所有集合的根节点。
     /// Version3目标:能够根据根节点找到所有同集合的点。
     /// </summary>
     class UnionFindDisjoinSets
     {
          Dictionary<int, int> disjointSets = new Dictionary<int, int>();
          HashSet<int> rootPointsSet = new HashSet<int>();

          //查找根节点函数,查
          public int FindRoot(int point)
          {
               if (!disjointSets.ContainsKey(point))//找不到它的上一节点(此节点即为根节点)
               {
                    rootPointsSet.Add(point);
                    return point;
               }
               int rootPoint = point;
               while (disjointSets.ContainsKey(rootPoint))//存在上级节点(此点非根节点)，循环寻找直到根节点
               {
                    rootPoint = disjointSets[rootPoint];
               }
               disjointSets[point] = rootPoint;//指向根节点，降低秩，加快找到根的速度。
               return rootPoint;
          }

          //将连线AB加入，并
          public bool UnionElement(int pointA, int pointB)
          {
               int pointARoot = FindRoot(pointA);
               int pointBRoot = FindRoot(pointB);
               if (pointARoot == pointBRoot)
               {
                    return false;
               }
               disjointSets[pointB] = pointARoot;
               return true;
          }
     }
}
