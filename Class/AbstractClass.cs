using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
     //抽象类，父类子类关系
     class Program
     {
          static void Main(string[] args)
          {
               Vehicle v = new Racecar();
               //Vehicle vehicle = new Vehicle();//抽象类无法实例化
               v.Fill();
               v.Run();//找到最新版本的迭代
               v.Stop();
               Console.WriteLine("======================");
               Vehicle v2 = new Bus();
               v2.Fill();
               v2.Run();
               v2.Stop();
          }

          interface IVehicle
          {
               void Run();
               void Stop();
               void Fill();
          }//接口内只有纯虚方法

          abstract class Vehicle
          {
               public void Fill()
               {
                    Console.WriteLine("I'm Filled");
               }
               abstract public void Run();//纯虚方法
               public virtual void Stop()
               {
                    Console.WriteLine("Vehicle stoped");
               }//虚方法
          }//抽象类

          class Car : Vehicle
          {
               public override void Run()
               {
                    Console.WriteLine("Car is Running");
               }

               public override void Stop()
               {
                    Console.WriteLine("Car stoped");
               }
          }//子类对抽象类的重写

          class Racecar : Car
          {
               public override void Run()
               {
                    Console.WriteLine("Turbo Accelerate Running, Very Fast!");
               }
          }

          class Bus : Vehicle
          {
               public override void Run()
               {
                    Console.WriteLine("Bus's slowly drive.");
               }

               public override void Stop()
               {
                    Console.WriteLine("Bus's slowly stop.");
               }
          }
     }
}
