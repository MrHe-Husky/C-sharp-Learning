using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExampleW4_WindowsForms
{
     public partial class myForm : Form
     {
          private bool buttonClickTimes;

          public myForm()
          {
               InitializeComponent();
               buttonClickTimes = false;
               this.myButton.Click += MyButtonClicked;
          }

          private void MyButtonClicked(object sender, EventArgs e)
          {
               buttonClickTimes = !buttonClickTimes;
               if (buttonClickTimes)
               {
                    this.myTextBox.Text = "花Q";
                    this.myButton.Text = "back to the previous step";
               }
               else
               {
                    this.myTextBox.Text = "";
                    this.myButton.Text = "say something to this world";
               }
               
          }
     }
}
