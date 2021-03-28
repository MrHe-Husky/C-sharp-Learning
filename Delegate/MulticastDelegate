using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MulticastDelegate
{
     class Program
     {
          static void Main(string[] args)
          {
               Student student1 = new Student() { Name = "犬山たまき", ID = 1, PenColor = ConsoleColor.Blue };
               Student student2 = new Student() { Name = "ゆゆうた", ID = 2, PenColor = ConsoleColor.DarkYellow };
               Student student3 = new Student() { Name = "野獸先輩", ID = 810, PenColor = ConsoleColor.DarkGray };

               Action action1 = new Action(student1.DoHomework);
               Action action2 = new Action(student2.DoHomework);
               Action action3 = new Action(student3.DoHomework);
               {
                    {
                         /*
                         student1.DoHomework();
                         student2.DoHomework();
                         student3.DoHomework();
                         */
                    }//直接同步调用
                    {
                         /*
                         action1.Invoke();
                         action2.Invoke();
                         action3.Invoke();
                         */
                    }//单播委托形式(间接同步调用)
                    {
                         /*
                         action1 += action2;
                         action1 += action3;
                         action1.Invoke();
                         */
                    }//多播委托形式，用一个委托封装多个方法(也是同步的)
                    {
                         /*
                         action1.BeginInvoke(null, null);
                         action2.BeginInvoke(null, null);
                         action3.BeginInvoke(null, null);
                         */
                    }//委托隐式异步调用(BeginInvoke方法)
                    {
                         /*
                         Thread thread1 = new Thread(new ThreadStart(student1.DoHomework));
                         Thread thread2 = new Thread(new ThreadStart(student2.DoHomework));
                         Thread thread3 = new Thread(new ThreadStart(student3.DoHomework));

                         thread1.Start();
                         thread2.Start();
                         thread3.Start();
                         */
                    }//显式异步调用，方法一(Thread)[古老方法]
                    {
                         Task task1 = new Task(action1);
                         Task task2 = new Task(action2);
                         Task task3 = new Task(action3);

                         task1.Start();
                         task2.Start();
                         task3.Start();
                    }////显式异步调用，方法二(Task)[新方法]

                    for (int i = 0; i < 10; i++)
                    {
                         Console.ForegroundColor = ConsoleColor.Magenta;
                         Console.WriteLine("Main thread in its {0} step(s).",i);
                         Thread.Sleep(1000);
                    }
               }//同步与异步

          }

          class Student
          {
               public string Name { get; set; }
               public int ID { get; set; }
               public ConsoleColor PenColor { get; set; }

               public void DoHomework()
               {
                    for (int i = 0; i < 5; i++)
                    {
                         Console.ForegroundColor = this.PenColor;
                         Console.WriteLine("Student({0}) {1} doing Homework {2} hour(s).",ID,Name,i);
                         Thread.Sleep(1000);
                    }
               }
          }

     }
}
