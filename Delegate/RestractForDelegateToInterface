using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
     class Program
     {
          static void Main(string[] args)
          {
               IProductFactory pizzaFactory = new PizzaFactory();
               IProductFactory toyCarFactory = new ToyCarFactory();
               IProductFactory breadFactory = new BreadFactory();
               WrapFactory wrapFactory = new WrapFactory();

   
               Box box1 = wrapFactory.WarpPorduct(pizzaFactory);//用盒子装一个(生产pizza)
               Box box2 = wrapFactory.WarpPorduct(toyCarFactory);//用盒子装一个(生产toycar)
               Box box3 = wrapFactory.WarpPorduct(breadFactory);//用盒子装一个(生产toycar)

               Console.WriteLine(box1.Product.Name);
               Console.WriteLine(box2.Product.Name);
               Console.WriteLine(box3.Product.Name);
          }

          interface IProductFactory
          {
               Product Make();
          }

          class PizzaFactory : IProductFactory
          {
               public Product Make()
               {
                    Product product = new Product();
                    product.Name = "Pizza";
                    product.Price = 24;
                    return product;
               }
          }
          class ToyCarFactory : IProductFactory
          {
               public Product Make()
               {
                    Product product = new Product();
                    product.Name = "ToyCar";
                    product.Price = 30;
                    return product;
               }
          }
          class BreadFactory : IProductFactory
          {
               public Product Make()
               {
                    Product product = new Product();
                    product.Name = "Bread";
                    product.Price = 6;
                    return product;
               }
          }

          class Product
          {
               public string Name { get; set; }
               public double Price { get; set; }
          }
          class Box
          {
               public Product Product { get; set; }
          }
          class WrapFactory
          {
               //委托作为方法参数实现模板方法，(函数指针作为函数参数)
               public Box WarpPorduct(IProductFactory productFactory)
               {
                    Box box = new Box();
                    Product product = productFactory.Make();
                    box.Product = product;
                    return box;
               }
          }
     }
}