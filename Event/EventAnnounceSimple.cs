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

          /*
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
          }*/

          //field-like
          public event EventHandler Order;

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
          }

          protected void OnOrder()
          {
               if (this.Order != null)
               {
                    OrderEventArgs e = new OrderEventArgs();
                    e.DishName = "Kongpao Chicken";
                    e.Size = "Large";
                    this.Order.Invoke(this, e);
               }
          }

          public void Action()
          {
               Console.ReadLine();
               this.WalkIn();
               this.SitDown();
               this.Think();
               this.OnOrder();
          }
     }
     
     public class OrderEventArgs : EventArgs//传递事件消息的类(EventArgs结尾)
     {
          
          public string DishName { get; set; }//菜名
          public string Size { get; set; }//大小
     }

     public class Waiter//事件响应者
     {
          public void Action(object sender, EventArgs e)
          {
               //拆包
               Customer customter = sender as Customer;
               OrderEventArgs orderArgs = e as OrderEventArgs;

               Console.WriteLine("I'll serve your dish.{0}", orderArgs.DishName);
               double prise = 10;
               switch (orderArgs.Size)
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

               customter.Bill += prise;
          }
     }
}
