using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Superman.Properties;

namespace Superman
{
	// Token: 0x0200001B RID: 27
	public partial class LoginForm : Form
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x000022D8 File Offset: 0x000004D8
		public LoginForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000096AC File Offset: 0x000078AC
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005C58 File Offset: 0x00003E58
		public string executee(string arg)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				FileName = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + "\\cmd.exe",
				Arguments = "/c " + arg
			};
			process.Start();
			process.WaitForExit();
			return process.StandardOutput.ReadToEnd();
		}

		// Token: 0x060000B8 RID: 184
		[DllImport("MemLib.dll")]
		public static extern void LoggClck();

		// Token: 0x060000B9 RID: 185 RVA: 0x000096E4 File Offset: 0x000078E4
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00009734 File Offset: 0x00007934
		private void LoginForm_Load(object sender, EventArgs e)
		{
			try
			{
				WebClient webClient = new WebClient();
				string a = webClient.DownloadString("https://nskmedia.net/rizwan/BPSTOPHERE/LevelXup");
				if (a == "KICK")
				{
					MessageBox.Show("Please Recharge Your Panel..Thanks", "Developer");
					Application.Exit();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please Connect To Internet And Start Again.", "Developer");
				Application.Exit();
			}
			if (!File.Exists("C:\\\\Windows\\\\click.wav"))
			{
				File.WriteAllBytes("C:\\click.wav", Resources.click);
			}
			if (!File.Exists("MemLib.dll"))
			{
				using (WebClient webClient2 = new WebClient())
				{
					webClient2.DownloadFile("https://nskmedia.net/rizwan/LOG/Memlib", "C:\\\\ProgramData\\\\MemLib.dll");
					File.Move("C:\\ProgramData\\MemLib.dll", "MemLib.dll");
				}
			}
			this.executee("attrib -h -s -r Temp");
			this.executee("attrib +h +s +r MemLib.dll");
			if (File.Exists("Temp"))
			{
				this.executee("attrib +h +s +r Temp");
				this.executee("attrib -h -s -r MemLib.dll");
				File.Delete("MemLib.dll");
				File.Move("Temp", "MemLib.dll");
			}
			if (File.Exists("C:\\\\BP.lic"))
			{
				this.license.Text = File.ReadAllText("C:\\\\BP.lic");
			}
			if (!File.Exists("C:\\\\Windows\\\\adb.exe"))
			{
				using (WebClient webClient3 = new WebClient())
				{
					webClient3.DownloadFile("https://nskmedia.net/rizwan/LOG/adb", "C:\\\\Windows\\\\adb.exe");
				}
			}
			if (!File.Exists("C:\\\\Windows\\\\AdbWinApi.dll"))
			{
				using (WebClient webClient4 = new WebClient())
				{
					webClient4.DownloadFile("https://nskmedia.net/rizwan/LOG/AdbWinApi", "C:\\\\Windows\\\\AdbWinApi.dll");
				}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000022B4 File Offset: 0x000004B4
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00009908 File Offset: 0x00007B08
		//////////private void method_1(object sender, EventArgs e)
		//////////{
		//////////	LoginForm.<License_TextChanged>d__9 <License_TextChanged>d__ = new LoginForm.<License_TextChanged>d__9();
		//////////	<License_TextChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//////////	<License_TextChanged>d__.<>4__this = this;
		//////////	<License_TextChanged>d__.sender = sender;
		//////////	<License_TextChanged>d__.e = e;
		//////////	<License_TextChanged>d__.<>1__state = -1;
		//////////	<License_TextChanged>d__.<>t__builder.Start<LoginForm.<License_TextChanged>d__9>(ref <License_TextChanged>d__);
		//////////}

		// Token: 0x060000BD RID: 189 RVA: 0x000022B6 File Offset: 0x000004B6
		private void Exit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000022B4 File Offset: 0x000004B4
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000022B6 File Offset: 0x000004B6
		private void method_3(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00009950 File Offset: 0x00007B50
		private void LOGINBUTTON_Click(object sender, EventArgs e)
		{
			string text = this.license.Text;
			if (!text.Contains("LevelXup"))
			{
				MessageBox.Show("Please Put LevelXup Tag In Your Key", "LevelXup");
				Environment.Exit(0);
			}
			TextWriter textWriter = new StreamWriter("C:\\\\BP.lic");
			textWriter.Write(this.license.Text);
			textWriter.Close();
			TextWriter textWriter2 = new StreamWriter("C:\\\\Windows\\\\Start");
			textWriter2.Write(this.license.Text);
			textWriter2.Close();
			LoginForm.LoggClck();
			MainForm mainForm = new MainForm();
			mainForm.Show();
			base.Hide();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000022B6 File Offset: 0x000004B6
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x040000DA RID: 218
		

		// Token: 0x040000DB RID: 219
		public const string fileName = "C:\\\\BP.lic";
	}
}
