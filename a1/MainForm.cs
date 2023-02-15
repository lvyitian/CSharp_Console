/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2023/2/14 星期二
 * 时间: 上午 10:29
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace a1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Form1 form;
		public volatile bool useTrustedInstaller;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.useTrustedInstaller=MessageBox.Show("是否使用TrustedInstaller","询问",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes;
			new Thread(()=>Application.Run(form=new Form1(this))){ApartmentState=ApartmentState.STA}.Start();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void attaClick(object sender, EventArgs e)
		{
			form.sendCommand("nmap -v -A "+textBox1.Text);
		}
		void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
		{
			
		}
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			if(form!=null)
				form.Form1FormClosed(form,null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			form.terminate();
		}
		void Button3Click(object sender, EventArgs e)
		{
			form.sendCommand("net use \\"+textBox3.Text+" "+maskedTextBox1.Text+" /u:"+textBox4.Text);
		}
		void Button6Click(object sender, EventArgs e)
		{
			form.sendCommand("arp -a");
		}
		void Button10Click(object sender, EventArgs e)
		{
			form.sendCommand(textBox2.Text);
			textBox2.Text="";
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar=='\r')
				Button10Click(button10,null);
		}
		void Label5Click(object sender, EventArgs e)
		{
			form.sendCommand("tracert "+textBox1.Text);
		}
		void Button2Click(object sender, EventArgs e)
		{
			form.sendCommand("netstat -n -o");
		}
		void Button8Click(object sender, EventArgs e)
		{
			form.sendCommand("wmic");
			form.sendCommand("process get");
			form.sendCommand("quit");
		}
		void Button7Click(object sender, EventArgs e)
		{
	
		}
		void Button5Click(object sender, EventArgs e)
		{
			form.sendCommand("route print");
		}
		void Button11Click(object sender, EventArgs e)
		{
			form.sendCommand("tree /f .");
		}
	}
}
