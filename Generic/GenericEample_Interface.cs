using System;

namespace GenericEample_Interface
{
     class Program
     {
          static void Main(string[] args)
          {
               //不特化实现泛型接口
               Student<int> studentInt = new Student<int>() { ID = 114514 };
               Console.WriteLine(studentInt.ID);
               //特化实现的泛型接口
               Student studentUlong = new Student() { ID = 1145141919810 };
               Console.WriteLine(studentUlong.ID);
          }

          interface IUnique<TID>
          {
               TID ID { get; set; }
          }

          class Student<TID> : IUnique<TID>//不特化实现泛型接口
          {
               public TID ID { get; set; }
          }

          class Student : IUnique<ulong>//直接把泛型特化
          {
               public ulong ID { get; set; }
          }
     }
}
