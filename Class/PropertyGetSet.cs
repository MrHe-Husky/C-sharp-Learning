using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGetSet
{
     class Program
     {
          static void Main(string[] args)
          {
               Student stu1 = new Student();
               stu1.Age = 10;
               Student stu2 = new Student();
               stu2.Age = 50;
               Console.WriteLine(stu1.Age);
               Console.WriteLine(stu1.CanWork);
               Console.WriteLine("=============");
               Console.WriteLine(stu2.Age);
               Console.WriteLine(stu2.CanWork);
               Console.WriteLine("=============");
               Console.WriteLine(Student.GetAmount());
          }

          class Student
          {
               private int age;
               public int Age//Age属性方法声明(相当于对private值以及其get和set方法进行封装)
               {
                    get
                    {
                         return this.age;
                    }
                    set
                    {
                         if (value >= 0 && value <= 150)
                         {
                              this.age = value;
                         }
                         else
                         {
                              throw new Exception("Age value is error");
                         }
                    }
               }

               public bool CanWork//动态返回属性值(是否可以工作)
               {
                    get
                    {
                         if (this.Age >= 16)
                         {
                              return true;
                         }
                         else
                         {
                              return false;
                         }
                    }

               }

               private static int Amount;
               static Student()
               {
                    Amount = 0;
               }
               public Student()
               {
                    Amount++;
               }
               public static int GetAmount()
               {
                    return Amount;
               }
          }
     }
}
