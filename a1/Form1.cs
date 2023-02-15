/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2023/2/14 星期二
 * 时间: 上午 10:55
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace a1
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		[DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern bool GenerateConsoleCtrlEvent(int ctrlEvent, int groupId);
		[DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern bool SetConsoleCtrlHandler(IntPtr handle, bool add);
		[DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern bool AttachConsole(int process);
		[DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern bool FreeConsole();
		
		[DllImport("user32.dll", SetLastError = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern IntPtr SetParent(IntPtr child, IntPtr parent);
		public IList q = System.Collections.ArrayList.Synchronized(new List<string>());
		public Process process = new Process();
		public volatile Task<string> currentTask;
		public Form1(Form parent)
		{			
			SetParent(this.Handle, parent.Handle);
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			process.StartInfo.UseShellExecute = false;
			if(parent is MainForm && (parent as MainForm).useTrustedInstaller)
			{
			  process.StartInfo.Arguments="-U:T -P:E -M:S -Priority:RealTime -ShowWindowMode:Hide -Wait -UseCurrentConsole \""+(Application.StartupPath + @"\pwsh\powershell.exe")+"\"";
			  process.StartInfo.FileName=Application.StartupPath+"\\pwsh\\Win32\\NSudoLC.exe";
			}else process.StartInfo.FileName = Application.StartupPath + @"\pwsh\powershell.exe";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.StandardErrorEncoding = System.Text.Encoding.Default;
			process.StartInfo.StandardOutputEncoding = System.Text.Encoding.Default;
			if (process.Start()) {
				process.StandardInput.AutoFlush = true;
				new System.Threading.Thread(() => {
					process.WaitForExit();
					Environment.Exit(process.ExitCode);
				}).Start();
				Action<Task<string>> outTask = null;
				outTask = r => {
					if (process.StandardOutput.EndOfStream && r.Result.Trim().Length == 0)
						return;
					lock (process) {
						q.Add(r.Result);
					}
					process.StandardOutput.ReadLineAsync().ContinueWith(outTask);
				};
				process.StandardOutput.ReadLineAsync().ContinueWith(outTask);
				Action<Task<string>> errTask = null;
				errTask = r => {
					if (process.StandardError.EndOfStream && r.Result.Trim().Length == 0)
						return;
					lock (process) {
						q.Add(r.Result);
					}
					process.StandardError.ReadLineAsync().ContinueWith(errTask);
				};
				process.StandardError.ReadLineAsync().ContinueWith(errTask);
				sendCommand("[System.Environment]::SetEnvironmentVariable(\"Path\",\"" + Application.StartupPath + "\\tools\\;\"+[System.Environment]::GetEnvironmentVariable(\"Path\"))");
				//sendCommand(@"tree /F .");
			}
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void sendCommand(String s)
		{
			process.StandardInput.AutoFlush = true;
			foreach (char i in s) {
				process.StandardInput.Write(i);
			}
			process.StandardInput.WriteLine();
		}
		/*public void runAsTrustedInstaller(String cmd)
		{
			Process process=new Process();
			process.StartInfo.UseShellExecute=false;
			process.StartInfo.RedirectStandardError=true;
			process.StartInfo.RedirectStandardInput=true;
			process.StartInfo.RedirectStandardOutput=true;
			process.StartInfo.Arguments="-U:T -P:E -M:S -Priority:RealTime -ShowWindowMode:Hide -Wait -UseCurrentConsole \""+cmd+"\"";
			process.StartInfo.FileName=Application.StartupPath+"\\pwsh\\Win32\\NSudoLC.exe";
			process.StartInfo.CreateNoWindow=true;
			process.StartInfo.WindowStyle=ProcessWindowStyle.Hidden;
			if(process.Start())
			{
				Action<Task<string>> outTask = null;
				outTask = r => {
					if (process.StandardOutput.EndOfStream && r.Result.Trim().Length == 0)
						return;
					lock (this.process) {
						q.Add(r.Result);
					}
					process.StandardOutput.ReadLineAsync().ContinueWith(outTask);
				};
				process.StandardOutput.ReadLineAsync().ContinueWith(outTask);
				Action<Task<string>> errTask = null;
				errTask = r => {
					if (process.StandardError.EndOfStream && r.Result.Trim().Length == 0)
						return;
					lock (this.process) {
						q.Add(r.Result);
					}
					process.StandardError.ReadLineAsync().ContinueWith(errTask);
				};
				process.StandardError.ReadLineAsync().ContinueWith(errTask);
			}else{
				throw new Exception("Cannot create process");
			}
		}*/
		public void terminate()
		{
			process.StandardInput.AutoFlush = true;
			/*process.StandardInput.Write((char)('c'-'a'+1));
			process.StandardInput.Write('\r');
			process.StandardInput.WriteLine();
			process.StandardInput.Write((char)('z'-'a'+1));
			process.StandardInput.Write('\r');
			process.StandardInput.WriteLine();
			process.StandardInput.Write((char)('x'-'a'+1));
			process.StandardInput.Write('\r');
			process.StandardInput.WriteLine();*/
			lock (this) {
				try {
					if(!AttachConsole(process.Id))
						return;
					SetConsoleCtrlHandler(IntPtr.Zero, true);
					GenerateConsoleCtrlEvent(0, 0);
					System.Threading.Thread.Sleep(200);
				} finally {
					SetConsoleCtrlHandler(IntPtr.Zero, false);
					FreeConsole();
				}
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			lock (process) {
				if (q.Count >= 1) {
					foreach(Object i in q)
						richTextBox1.AppendText(i as string + "\n");
					q.Clear();
				}
			}
		}
		public void Form1FormClosed(object sender, FormClosedEventArgs e)
		{
			if (!process.HasExited)
				process.Kill();
			Environment.Exit(0);
		}
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
			if (richTextBox1.Text.Length > 685000)
				richTextBox1.Text = richTextBox1.Text.Substring(500000);
		}
	}
}
