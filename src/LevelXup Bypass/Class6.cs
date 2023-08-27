using System;
using System.Reflection;

// Token: 0x02000031 RID: 49
internal class Class6
{
	// Token: 0x0600016B RID: 363 RVA: 0x0000CC10 File Offset: 0x0000AE10
	internal static void CwThBussXHrEO(int typemdt)
	{
		Type type = Class6.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class6.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x04000129 RID: 297
	internal static Module module_0 = typeof(Class6).Assembly.ManifestModule;

	// Token: 0x02000032 RID: 50
	// (Invoke) Token: 0x0600016F RID: 367
	internal delegate void Delegate0(object o);
}
