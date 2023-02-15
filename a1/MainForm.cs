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
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
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
	}
}
