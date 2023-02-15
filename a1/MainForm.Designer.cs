/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2023/2/14 星期二
 * 时间: 上午 10:29
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace a1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button atta;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.atta = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 163);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 38);
			this.button2.TabIndex = 1;
			this.button2.Text = "查看所有套接字";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 119);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(116, 38);
			this.button3.TabIndex = 2;
			this.button3.Text = "检索连接列表";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// atta
			// 
			this.atta.Location = new System.Drawing.Point(12, 75);
			this.atta.Name = "atta";
			this.atta.Size = new System.Drawing.Size(116, 38);
			this.atta.TabIndex = 3;
			this.atta.Text = "进攻性扫描";
			this.atta.UseVisualStyleBackColor = true;
			this.atta.Click += new System.EventHandler(this.attaClick);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 339);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(116, 38);
			this.button5.TabIndex = 4;
			this.button5.Text = "查看本地IP路由";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(12, 295);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(116, 38);
			this.button6.TabIndex = 5;
			this.button6.Text = "显示ARP缓存条目";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(12, 251);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(116, 38);
			this.button7.TabIndex = 6;
			this.button7.Text = "路由追踪";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(12, 207);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(116, 38);
			this.button8.TabIndex = 7;
			this.button8.Text = "获取进程列表";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(726, 42);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(99, 38);
			this.button10.TabIndex = 9;
			this.button10.Text = "Send";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(12, 383);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(116, 38);
			this.button11.TabIndex = 10;
			this.button11.Text = "显示目录结构";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Nmap";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(61, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 12;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(29, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 10);
			this.label2.TabIndex = 13;
			this.label2.Text = "HOST:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 427);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 38);
			this.button1.TabIndex = 15;
			this.button1.Text = "终止";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(29, 52);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(691, 21);
			this.textBox2.TabIndex = 16;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2KeyPress);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(169, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 18);
			this.label3.TabIndex = 17;
			this.label3.Text = "TargetIP:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(229, 2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(128, 21);
			this.textBox3.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(363, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 18);
			this.label4.TabIndex = 19;
			this.label4.Text = "PASSWORD:";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(432, 2);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(128, 21);
			this.maskedTextBox1.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(566, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 15);
			this.label5.TabIndex = 21;
			this.label5.Text = "UserName:";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(624, 2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(128, 21);
			this.textBox4.TabIndex = 22;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 562);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.atta);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "工具集";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
