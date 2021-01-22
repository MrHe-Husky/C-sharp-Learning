using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
     class Program
     {
          static void Main(string[] args)
          {
               double x = Math.Pow(114.514, 8.10);
               Console.WriteLine(x);

               /*用new由类建立实例
               (new Form()).ShowDialog();
               */
               Form myForm;
               myForm = new Form();
               myForm.Text = "My Form";//更改属性text的名字
               myForm.ShowDialog();
          }
     }
}
