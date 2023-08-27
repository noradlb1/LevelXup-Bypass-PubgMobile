using System;
using System.Windows.Forms;
using Superman;

// Token: 0x0200001D RID: 29
internal static class Class0
{
	// Token: 0x060000C8 RID: 200 RVA: 0x0000230F File Offset: 0x0000050F
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new LoginForm());
	}
}
