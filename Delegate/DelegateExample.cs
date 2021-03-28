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
               ProductFactoty productFactoty = new ProductFactoty();
               WrapFactory wrapFactory = new WrapFactory();
               Logger logger = new Logger();

               Func<Product> func1 = new Func<Product>(productFactoty.MakePizza);
               Func<Product> func2 = new Func<Product>(productFactoty.MakeToyCar);
               Action<Product> log = new Action<Product>(logger.Log);

               Box box1 = wrapFactory.WarpPorduct(func1,log);//用盒子装一个(生产pizza)
               Box box2 = wrapFactory.WarpPorduct(func2,log);//用盒子装一个(生产toycar)

               Console.WriteLine(box1.Product.Name);
               Console.WriteLine(box2.Product.Name);
          }

          class Logger
          {
               public void Log(Product product)
               {
                    Console.WriteLine("Product {0} is created at {1}. Price is {2}",product.Name,DateTime.Now,product.Price);
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
               public Box WarpPorduct(Func<Product> getProduct,Action<Product> logCallBack)
               {
                    Box box = new Box();
                    Product product = getProduct.Invoke(); 
                    box.Product = product;
                    logCallBack(product);
                    return box;
               }
          }
          class ProductFactoty
          {
               //由于上面使用委托，因此在需要添加新产品时只需要在此方法内增加新方法即可
               public Product MakePizza()
               {
                    Product product = new Product();
                    product.Name = "Pizza";
                    product.Price = 24;
                    return product;
               }
               public Product MakeToyCar()
               {
                    Product product = new Product();
                    product.Name = "ToyCar";
                    product.Price = 30;
                    return product;
               }
               public Product MakeBread()
               {
                    Product product = new Product();
                    product.Name = "Bread";
                    product.Price = 6;
                    return product;
               }
          }
     }
}