namespace EventExampleW4_WindowsForms
{
     partial class myForm
     {
          /// <summary>
          /// 必需的设计器变量。
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// 清理所有正在使用的资源。
          /// </summary>
          /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows 窗体设计器生成的代码

          /// <summary>
          /// 设计器支持所需的方法 - 不要修改
          /// 使用代码编辑器修改此方法的内容。
          /// </summary>
          private void InitializeComponent()
          {
               this.myButton = new System.Windows.Forms.Button();
               this.myTextBox = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // myButton
               // 
               this.myButton.Location = new System.Drawing.Point(93, 189);
               this.myButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.myButton.Name = "myButton";
               this.myButton.Size = new System.Drawing.Size(556, 24);
               this.myButton.TabIndex = 0;
               this.myButton.Text = "say something to this world";
               this.myButton.UseVisualStyleBackColor = true;
               // 
               // myTextBox
               // 
               this.myTextBox.Location = new System.Drawing.Point(93, 113);
               this.myTextBox.Name = "myTextBox";
               this.myTextBox.Size = new System.Drawing.Size(556, 23);
               this.myTextBox.TabIndex = 1;
               // 
               // myForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(755, 324);
               this.Controls.Add(this.myTextBox);
               this.Controls.Add(this.myButton);
               this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
               this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.Name = "myForm";
               this.Text = "Hellow World!";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button myButton;
          private System.Windows.Forms.TextBox myTextBox;
     }
}

