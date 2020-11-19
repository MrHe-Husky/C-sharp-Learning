using System;
using System.Threading;

namespace EventAnnounce
{
     class Program
     {
          static void Main(string[] args)
          {
               Customer customer = new Customer("Husky");
               Waiter waiter = new Waiter();
               customer.Order += waiter.Action;
               customer.Action();
               customer.PayBill();
          }
     }

     public class Customer
     {
          public double Bill { get; set; }
          private string customerName;

          public Customer(string CustomerName)
          {
               this.customerName = CustomerName;
          }
          //事件处理器
          private OrderEventHandler orderEventHandler;//委托类型字段用于引用事件处理器

          public event OrderEventHandler Order//声明事件,OrderEventHandler为处理器的类型(委托类型)
          {
               add//事件处理器添加器(多播委托挂接)
               {
                    this.orderEventHandler += value;
               }
               remove//
               {
                    this.orderEventHandler -= value;
               }
          }

          public void PayBill()
          {
               Console.WriteLine("Customer has paid the bill ${0}", Bill);
          }
          public void WalkIn()
          {
               Console.WriteLine("{0} walk in the restaurent",customerName);
          }
          public void SitDown()
          {
               Console.WriteLine("{0} sit down",customerName);
          }
          public void Think()
          {
               for (int i = 0; i < 5; i++)
               {
                    Console.WriteLine("{0} is thinking... ",customerName);
                    Thread.Sleep(1000);
               }

               if (this.orderEventHandler != null)
               {
                    OrderEventArgs e = new OrderEventArgs();
                    e.DishName = "Kongpao Chicken";
                    e.Size = "Large";
                    //事件触发
                    this.orderEventHandler.Invoke(this, e);
               }
          }
          public void Action()
          {
               Console.ReadLine();
               this.WalkIn();
               this.SitDown();
               this.Think();
          }
     }
     
     public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);//声明委托类型，返回值viod,参数customer，orderEventArgs
     public class OrderEventArgs : EventArgs//传递事件消息的类(EventArgs结尾)
     {
          
          public string DishName { get; set; }//菜名
          public string Size { get; set; }//大小
     }

     public class Waiter//事件响应者
     {
          public void Action(Customer customer, OrderEventArgs e)
          {
               Console.WriteLine("I'll serve your dish.{0}",e.DishName);
               double prise = 10;
               switch (e.Size)
               {
                    case "small":
                         prise = prise * 0.5;
                         break;
                    case "large":
                         prise = prise * 1.5;
                         break;
                    defalut:
                         break;
               }

               customer.Bill += prise;
          }
     }
}
