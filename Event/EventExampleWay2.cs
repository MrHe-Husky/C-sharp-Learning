using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExampleWay2
{
     class Program
     {
          static void Main(string[] args)
          {
               //form是事件源(event sourse)其拥有事件(event)formClicked(被点击)
               Form form = new Form();
               //controller是与form平级的事件订阅者(event subscriber)其有事件响应方法(event handler)ClickedAction
               Controller controller = new Controller(form);
               form.ShowDialog();
          }
          
          class Controller
          {
               private Form form;

               public Controller(Form formClicked)
               {
                    if (formClicked != null)
                    {
                         this.form = formClicked;
                         //事件响应器订阅事件(subscribe)
                         form.Click += this.ClickAction;
                    }
               }

               private void ClickAction(object sender, EventArgs e)
               {
                    this.form.Text = DateTime.Now.ToString();
               }
          }
     }
}
