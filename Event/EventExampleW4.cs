using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExampleW4
{
     class Program
     {
          static void Main(string[] args)
          {
               MyForm myForm = new MyForm();
               myForm.ShowDialog();
          }
     }

     class MyForm : Form
     {
          private TextBox textBox;
          private Button button;
          private bool clickTimesCounter;

          public MyForm()
          {
               this.textBox = new TextBox() { Width =250};
               this.button = new Button() { Top = 30, Width = 250, Text = "Say something to this world" };
               this.Controls.Add(this.textBox);
               this.Controls.Add(this.button);
               this.button.Click += ButtonClicked;
               this.clickTimesCounter = false;
          }

          private void ButtonClicked(object sender, EventArgs e)
          {
               this.clickTimesCounter = !this.clickTimesCounter;
               if (clickTimesCounter)
               {
                    this.textBox.Text = "花Q";
                    this.button.Text = "Back to the Previous Step";
               }
               else
               {
                    this.textBox.Text = "";
                    this.button.Text = "Say something to this world";
               }
          }
     }
}
