using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000033 RID: 51
internal class Class7
{
	// Token: 0x06000172 RID: 370 RVA: 0x0000CC7C File Offset: 0x0000AE7C
	static Class7()
	{
		Class7.assembly_0 = typeof(Class7).Assembly;
		Class7.uint_0 = new uint[]
		{
			3614090360U,
			3905402710U,
			606105819U,
			3250441966U,
			4118548399U,
			1200080426U,
			2821735955U,
			4249261313U,
			1770035416U,
			2336552879U,
			4294925233U,
			2304563134U,
			1804603682U,
			4254626195U,
			2792965006U,
			1236535329U,
			4129170786U,
			3225465664U,
			643717713U,
			3921069994U,
			3593408605U,
			38016083U,
			3634488961U,
			3889429448U,
			568446438U,
			3275163606U,
			4107603335U,
			1163531501U,
			2850285829U,
			4243563512U,
			1735328473U,
			2368359562U,
			4294588738U,
			2272392833U,
			1839030562U,
			4259657740U,
			2763975236U,
			1272893353U,
			4139469664U,
			3200236656U,
			681279174U,
			3936430074U,
			3572445317U,
			76029189U,
			3654602809U,
			3873151461U,
			530742520U,
			3299628645U,
			4096336452U,
			1126891415U,
			2878612391U,
			4237533241U,
			1700485571U,
			2399980690U,
			4293915773U,
			2240044497U,
			1873313359U,
			4264355552U,
			2734768916U,
			1309151649U,
			4149444226U,
			3174756917U,
			718787259U,
			3951481745U
		};
		Class7.bool_0 = false;
		Class7.bool_1 = false;
		Class7.byte_1 = new byte[0];
		Class7.rsacryptoServiceProvider_0 = null;
		Class7.dictionary_0 = null;
		Class7.object_0 = new object();
		Class7.pigniOgZaM = new byte[0];
		Class7.byte_0 = new byte[0];
		Class7.intptr_2 = IntPtr.Zero;
		Class7.YybnsxqiJb = IntPtr.Zero;
		Class7.string_0 = new string[0];
		Class7.int_2 = new int[0];
		Class7.int_3 = 1;
		Class7.bool_2 = false;
		Class7.sortedList_0 = new SortedList();
		Class7.int_0 = 0;
		Class7.long_1 = 0L;
		Class7.delegate2_0 = null;
		Class7.delegate2_1 = null;
		Class7.long_0 = 0L;
		Class7.int_1 = 0;
		Class7.rvonOlmsfE = false;
		Class7.bool_3 = false;
		Class7.int_4 = 0;
		Class7.intptr_0 = IntPtr.Zero;
		Class7.bool_4 = false;
		Class7.IognuNxTuM = new Hashtable();
		Class7.delegate4_0 = null;
		Class7.delegate5_0 = null;
		Class7.delegate6_0 = null;
		Class7.delegate7_0 = null;
		Class7.delegate8_0 = null;
		Class7.delegate9_0 = null;
		Class7.intptr_1 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000173 RID: 371 RVA: 0x000022B4 File Offset: 0x000004B4
	private void lROhBusIBqm5b()
	{
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
	internal static byte[] smethod_0(byte[] byte_2)
	{
		uint[] array = new uint[16];
		int num = 448 - byte_2.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0U)
		{
			num2 = 512U;
		}
		uint num3 = (uint)((long)byte_2.Length + (long)((ulong)(num2 / 8U)) + 8L);
		ulong num4 = (ulong)((long)byte_2.Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < byte_2.Length; i++)
		{
			array2[i] = byte_2[i];
		}
		byte[] array3 = array2;
		int num5 = byte_2.Length;
		array3[num5] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num3 - (ulong)((long)j)))))] = (byte)(num4 >> (8 - j) * 8 & 255UL);
		}
		uint num6 = (uint)(array2.Length * 8 / 32);
		uint num7 = 1732584193U;
		uint num8 = 4023233417U;
		uint num9 = 2562383102U;
		uint num10 = 271733878U;
		for (uint num11 = 0U; num11 < num6 / 16U; num11 += 1U)
		{
			uint num12 = num11 << 6;
			for (uint num13 = 0U; num13 < 61U; num13 += 4U)
			{
				array[(int)((UIntPtr)(num13 >> 2))] = (uint)((int)array2[(int)((UIntPtr)(num12 + (num13 + 3U)))] << 24 | (int)array2[(int)((UIntPtr)(num12 + (num13 + 2U)))] << 16 | (int)array2[(int)((UIntPtr)(num12 + (num13 + 1U)))] << 8 | (int)array2[(int)((UIntPtr)(num12 + num13))]);
			}
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			uint num17 = num10;
			Class7.smethod_1(ref num7, num8, num9, num10, 0U, 7, 1U, array);
			Class7.smethod_1(ref num10, num7, num8, num9, 1U, 12, 2U, array);
			Class7.smethod_1(ref num9, num10, num7, num8, 2U, 17, 3U, array);
			Class7.smethod_1(ref num8, num9, num10, num7, 3U, 22, 4U, array);
			Class7.smethod_1(ref num7, num8, num9, num10, 4U, 7, 5U, array);
			Class7.smethod_1(ref num10, num7, num8, num9, 5U, 12, 6U, array);
			Class7.smethod_1(ref num9, num10, num7, num8, 6U, 17, 7U, array);
			Class7.smethod_1(ref num8, num9, num10, num7, 7U, 22, 8U, array);
			Class7.smethod_1(ref num7, num8, num9, num10, 8U, 7, 9U, array);
			Class7.smethod_1(ref num10, num7, num8, num9, 9U, 12, 10U, array);
			Class7.smethod_1(ref num9, num10, num7, num8, 10U, 17, 11U, array);
			Class7.smethod_1(ref num8, num9, num10, num7, 11U, 22, 12U, array);
			Class7.smethod_1(ref num7, num8, num9, num10, 12U, 7, 13U, array);
			Class7.smethod_1(ref num10, num7, num8, num9, 13U, 12, 14U, array);
			Class7.smethod_1(ref num9, num10, num7, num8, 14U, 17, 15U, array);
			Class7.smethod_1(ref num8, num9, num10, num7, 15U, 22, 16U, array);
			Class7.smethod_2(ref num7, num8, num9, num10, 1U, 5, 17U, array);
			Class7.smethod_2(ref num10, num7, num8, num9, 6U, 9, 18U, array);
			Class7.smethod_2(ref num9, num10, num7, num8, 11U, 14, 19U, array);
			Class7.smethod_2(ref num8, num9, num10, num7, 0U, 20, 20U, array);
			Class7.smethod_2(ref num7, num8, num9, num10, 5U, 5, 21U, array);
			Class7.smethod_2(ref num10, num7, num8, num9, 10U, 9, 22U, array);
			Class7.smethod_2(ref num9, num10, num7, num8, 15U, 14, 23U, array);
			Class7.smethod_2(ref num8, num9, num10, num7, 4U, 20, 24U, array);
			Class7.smethod_2(ref num7, num8, num9, num10, 9U, 5, 25U, array);
			Class7.smethod_2(ref num10, num7, num8, num9, 14U, 9, 26U, array);
			Class7.smethod_2(ref num9, num10, num7, num8, 3U, 14, 27U, array);
			Class7.smethod_2(ref num8, num9, num10, num7, 8U, 20, 28U, array);
			Class7.smethod_2(ref num7, num8, num9, num10, 13U, 5, 29U, array);
			Class7.smethod_2(ref num10, num7, num8, num9, 2U, 9, 30U, array);
			Class7.smethod_2(ref num9, num10, num7, num8, 7U, 14, 31U, array);
			Class7.smethod_2(ref num8, num9, num10, num7, 12U, 20, 32U, array);
			Class7.smethod_3(ref num7, num8, num9, num10, 5U, 4, 33U, array);
			Class7.smethod_3(ref num10, num7, num8, num9, 8U, 11, 34U, array);
			Class7.smethod_3(ref num9, num10, num7, num8, 11U, 16, 35U, array);
			Class7.smethod_3(ref num8, num9, num10, num7, 14U, 23, 36U, array);
			Class7.smethod_3(ref num7, num8, num9, num10, 1U, 4, 37U, array);
			Class7.smethod_3(ref num10, num7, num8, num9, 4U, 11, 38U, array);
			Class7.smethod_3(ref num9, num10, num7, num8, 7U, 16, 39U, array);
			Class7.smethod_3(ref num8, num9, num10, num7, 10U, 23, 40U, array);
			Class7.smethod_3(ref num7, num8, num9, num10, 13U, 4, 41U, array);
			Class7.smethod_3(ref num10, num7, num8, num9, 0U, 11, 42U, array);
			Class7.smethod_3(ref num9, num10, num7, num8, 3U, 16, 43U, array);
			Class7.smethod_3(ref num8, num9, num10, num7, 6U, 23, 44U, array);
			Class7.smethod_3(ref num7, num8, num9, num10, 9U, 4, 45U, array);
			Class7.smethod_3(ref num10, num7, num8, num9, 12U, 11, 46U, array);
			Class7.smethod_3(ref num9, num10, num7, num8, 15U, 16, 47U, array);
			Class7.smethod_3(ref num8, num9, num10, num7, 2U, 23, 48U, array);
			Class7.smethod_4(ref num7, num8, num9, num10, 0U, 6, 49U, array);
			Class7.smethod_4(ref num10, num7, num8, num9, 7U, 10, 50U, array);
			Class7.smethod_4(ref num9, num10, num7, num8, 14U, 15, 51U, array);
			Class7.smethod_4(ref num8, num9, num10, num7, 5U, 21, 52U, array);
			Class7.smethod_4(ref num7, num8, num9, num10, 12U, 6, 53U, array);
			Class7.smethod_4(ref num10, num7, num8, num9, 3U, 10, 54U, array);
			Class7.smethod_4(ref num9, num10, num7, num8, 10U, 15, 55U, array);
			Class7.smethod_4(ref num8, num9, num10, num7, 1U, 21, 56U, array);
			Class7.smethod_4(ref num7, num8, num9, num10, 8U, 6, 57U, array);
			Class7.smethod_4(ref num10, num7, num8, num9, 15U, 10, 58U, array);
			Class7.smethod_4(ref num9, num10, num7, num8, 6U, 15, 59U, array);
			Class7.smethod_4(ref num8, num9, num10, num7, 13U, 21, 60U, array);
			Class7.smethod_4(ref num7, num8, num9, num10, 4U, 6, 61U, array);
			Class7.smethod_4(ref num10, num7, num8, num9, 11U, 10, 62U, array);
			Class7.smethod_4(ref num9, num10, num7, num8, 2U, 15, 63U, array);
			Class7.smethod_4(ref num8, num9, num10, num7, 9U, 21, 64U, array);
			num7 += num14;
			num8 += num15;
			num9 += num16;
			num10 += num17;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num10), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x06000175 RID: 373 RVA: 0x000026D6 File Offset: 0x000008D6
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class7.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[(int)((UIntPtr)uint_5)] + Class7.uint_0[(int)((UIntPtr)(uint_6 - 1U))], ushort_0);
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00002701 File Offset: 0x00000901
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class7.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[(int)((UIntPtr)uint_5)] + Class7.uint_0[(int)((UIntPtr)(uint_6 - 1U))], ushort_0);
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0000272C File Offset: 0x0000092C
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class7.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[(int)((UIntPtr)uint_5)] + Class7.uint_0[(int)((UIntPtr)(uint_6 - 1U))], ushort_0);
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00002754 File Offset: 0x00000954
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class7.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[(int)((UIntPtr)uint_5)] + Class7.uint_0[(int)((UIntPtr)(uint_6 - 1U))], ushort_0);
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0000277D File Offset: 0x0000097D
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return uint_1 >> (int)(32 - ushort_0) | uint_1 << (int)ushort_0;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000278F File Offset: 0x0000098F
	internal static bool smethod_6()
	{
		if (!Class7.bool_0)
		{
			Class7.smethod_8();
			Class7.bool_0 = true;
		}
		return Class7.bool_1;
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0000D48C File Offset: 0x0000B68C
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm result = null;
		if (Class7.smethod_6())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
		}
		return result;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
	internal static void smethod_8()
	{
		try
		{
			Class7.bool_1 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x0600017D RID: 381 RVA: 0x000027A8 File Offset: 0x000009A8
	internal static byte[] smethod_9(byte[] byte_2)
	{
		if (!Class7.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_2);
		}
		return Class7.smethod_0(byte_2);
	}

	// Token: 0x0600017E RID: 382 RVA: 0x0000D50C File Offset: 0x0000B70C
	internal static void smethod_10(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		while (uint_1 > 0U)
		{
			int num = (uint_1 > (uint)byte_2.Length) ? byte_2.Length : ((int)uint_1);
			stream_0.Read(byte_2, 0, num);
			Class7.smethod_11(hashAlgorithm_0, byte_2, 0, num);
			uint_1 -= (uint)num;
		}
	}

	// Token: 0x0600017F RID: 383 RVA: 0x000027C3 File Offset: 0x000009C3
	internal static void smethod_11(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_5, int int_6)
	{
		hashAlgorithm_0.TransformBlock(byte_2, int_5, int_6, byte_2, int_5);
	}

	// Token: 0x06000180 RID: 384 RVA: 0x0000D548 File Offset: 0x0000B748
	internal static uint smethod_12(uint uint_1, int int_5, long long_2, BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_5; i++)
		{
			binaryReader_0.BaseStream.Position = long_2 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_1 && uint_1 < num2 + num)
			{
				return num3 + uint_1 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x06000181 RID: 385 RVA: 0x0000D5A4 File Offset: 0x0000B7A4
	public static void smethod_13(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Class7.dictionary_0 == null)
			{
				lock (Class7.object_0)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Class7).Assembly.GetManifestResourceStream("LuVdH0MHNitqh0myPY.herhLbJPElwfQAyngb"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length > 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0U;
						if (num > 0)
						{
							num2++;
						}
						for (int i = 0; i < num2; i++)
						{
							int num4 = i * 4;
							uint num5 = 255U;
							int num6 = 0;
							uint num7;
							if (i == num2 - 1 && num > 0)
							{
								num7 = 0U;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num7 <<= 8;
									}
									num7 |= (uint)array[array.Length - (1 + j)];
								}
							}
							else
							{
								uint num8 = (uint)num4;
								num7 = (uint)((int)array[(int)((UIntPtr)(num8 + 3U))] << 24 | (int)array[(int)((UIntPtr)(num8 + 2U))] << 16 | (int)array[(int)((UIntPtr)(num8 + 1U))] << 8 | (int)array[(int)((UIntPtr)num8)]);
							}
							num3 = num3;
							num3 += 0U;
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num7;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num5 <<= 8;
										num6 += 8;
									}
									array2[num4 + k] = (byte)((num9 & num5) >> num6);
								}
							}
							else
							{
								uint num10 = num3 ^ num7;
								array2[num4] = (byte)(num10 & 255U);
								array2[num4 + 1] = (byte)((num10 & 65280U) >> 8);
								array2[num4 + 2] = (byte)((num10 & 16711680U) >> 16);
								array2[num4 + 3] = (byte)((num10 & 4278190080U) >> 24);
							}
						}
						array = array2;
						int num11 = array.Length / 8;
						Class7.Class10 @class = new Class7.Class10(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = @class.method_3();
							int value = @class.method_3();
							dictionary.Add(key, value);
						}
						@class.method_4();
					}
					Class7.dictionary_0 = dictionary;
				}
			}
			foreach (FieldInfo fieldInfo in typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField))
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = Class7.dictionary_0[metadataToken];
				bool flag2 = (num12 & 1073741824) > 0;
				num12 &= 1073741823;
				MethodInfo methodInfo = (MethodInfo)typeof(Class7).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
				}
				else
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num13 = parameters.Length + 1;
					Type[] array3 = new Type[num13];
					if (methodInfo.DeclaringType.IsValueType)
					{
						array3[0] = methodInfo.DeclaringType.MakeByRefType();
					}
					else
					{
						array3[0] = typeof(object);
					}
					for (int n = 0; n < parameters.Length; n++)
					{
						array3[n + 1] = parameters[n].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					for (int num14 = 0; num14 < num13; num14++)
					{
						switch (num14)
						{
						case 0:
							ilgenerator.Emit(OpCodes.Ldarg_0);
							break;
						case 1:
							ilgenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							ilgenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							ilgenerator.Emit(OpCodes.Ldarg_3);
							break;
						default:
							ilgenerator.Emit(OpCodes.Ldarg_S, num14);
							break;
						}
					}
					ilgenerator.Emit(OpCodes.Tailcall);
					ilgenerator.Emit(flag2 ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					ilgenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000182 RID: 386 RVA: 0x000027D1 File Offset: 0x000009D1
	private static uint smethod_14(uint uint_1)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0000DA10 File Offset: 0x0000BC10
	[Class7.Attribute0(typeof(Class7.Attribute0.Class8<object>[]))]
	internal static string smethod_15(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x06000184 RID: 388 RVA: 0x000027DD File Offset: 0x000009DD
	private static int smethod_16()
	{
		return 5;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0000DA40 File Offset: 0x0000BC40
	private static void smethod_17()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0000DA68 File Offset: 0x0000BC68
	private static Delegate jSfbltyrfR(IntPtr intptr_3, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[]
		{
			intptr_3,
			type_0
		});
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0000DACC File Offset: 0x0000BCCC
	internal static object smethod_18(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_1).Location))
			{
				return ((Assembly)assembly_1).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x06000188 RID: 392
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	// Token: 0x06000189 RID: 393
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_3, string string_1);

	// Token: 0x0600018A RID: 394 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
	private static IntPtr smethod_19(IntPtr intptr_3, string string_1, uint uint_1)
	{
		if (Class7.delegate4_0 == null)
		{
			IntPtr procAddress = Class7.GetProcAddress(Class7.umLocehuEC(), "Find ".Trim() + "ResourceA");
			Class7.delegate4_0 = (Class7.Delegate4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class7.Delegate4));
		}
		return Class7.delegate4_0(intptr_3, string_1, uint_1);
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0000DC34 File Offset: 0x0000BE34
	private static IntPtr smethod_20(IntPtr intptr_3, uint uint_1, uint uint_2, uint uint_3)
	{
		if (Class7.delegate5_0 == null)
		{
			IntPtr procAddress = Class7.GetProcAddress(Class7.umLocehuEC(), "Virtual ".Trim() + "Alloc");
			Class7.delegate5_0 = (Class7.Delegate5)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class7.Delegate5));
		}
		return Class7.delegate5_0(intptr_3, uint_1, uint_2, uint_3);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000DC90 File Offset: 0x0000BE90
	private static int smethod_21(IntPtr intptr_3, IntPtr intptr_4, [In] [Out] byte[] byte_2, uint uint_1, out IntPtr intptr_5)
	{
		if (Class7.delegate6_0 == null)
		{
			IntPtr procAddress = Class7.GetProcAddress(Class7.umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			Class7.delegate6_0 = (Class7.Delegate6)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class7.Delegate6));
		}
		return Class7.delegate6_0(intptr_3, intptr_4, byte_2, uint_1, out intptr_5);
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
	private static int smethod_22(IntPtr intptr_3, int int_5, int int_6, ref int int_7)
	{
		if (Class7.delegate7_0 == null)
		{
			IntPtr procAddress = Class7.GetProcAddress(Class7.umLocehuEC(), "Virtual ".Trim() + "Protect");
			Class7.delegate7_0 = (Class7.Delegate7)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class7.Delegate7));
		}
		return Class7.delegate7_0(intptr_3, int_5, int_6, ref int_7);
	}

	// Token: 0x0600018E RID: 398 RVA: 0x0000DD54 File Offset: 0x0000BF54
	private static IntPtr smethod_23(uint uint_1, int int_5, uint uint_2)
	{
		if (Class7.delegate8_0 == null)
		{
			IntPtr procAddress = Class7.GetProcAddress(Class7.umLocehuEC(), "Open ".Trim() + "Process");
			Class7.delegate8_0 = (Class7.Delegate8)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class7.Delegate8));
		}
		return Class7.delegate8_0(uint_1, int_5, uint_2);
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000DDB0 File Offset: 0x0000BFB0
	private static int smethod_24(IntPtr intptr_3)
	{
		if (Class7.delegate9_0 == null)
		{
			IntPtr procAddress = Class7.GetProcAddress(Class7.umLocehuEC(), "Close ".Trim() + "Handle");
			Class7.delegate9_0 = (Class7.Delegate9)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class7.Delegate9));
		}
		return Class7.delegate9_0(intptr_3);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x000027E0 File Offset: 0x000009E0
	private static IntPtr umLocehuEC()
	{
		if (Class7.intptr_1 == IntPtr.Zero)
		{
			Class7.intptr_1 = Class7.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class7.intptr_1;
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0000DE08 File Offset: 0x0000C008
	[Class7.Attribute0(typeof(Class7.Attribute0.Class8<object>[]))]
	private static byte[] smethod_25(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			long length = fileStream.Length;
			int i = (int)length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002816 File Offset: 0x00000A16
	internal static byte[] smethod_26(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000DE70 File Offset: 0x0000C070
	[Class7.Attribute0(typeof(Class7.Attribute0.Class8<object>[]))]
	private static byte[] smethod_27(byte[] byte_2)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class7.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			28,
			191,
			47,
			6,
			75,
			20,
			225,
			4,
			24,
			100,
			44,
			45,
			145,
			217,
			162,
			229,
			54,
			1,
			113,
			214,
			150,
			49,
			242,
			223,
			130,
			186,
			159,
			196,
			67,
			14,
			208,
			3
		};
		symmetricAlgorithm.IV = new byte[]
		{
			221,
			194,
			144,
			27,
			2,
			121,
			141,
			218,
			0,
			159,
			152,
			36,
			203,
			1,
			181,
			25
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_2, 0, byte_2.Length);
		cryptoStream.Close();
		return Class7.smethod_26(stream);
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
	private byte[] method_0()
	{
		return null;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
	private byte[] method_1()
	{
		return null;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
	private byte[] method_2()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0000DF34 File Offset: 0x0000C134
	private byte[] method_3()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0000DF74 File Offset: 0x0000C174
	private byte[] method_4()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
	private byte[] method_5()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
	internal byte[] method_6()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600019B RID: 411 RVA: 0x0000E034 File Offset: 0x0000C234
	internal byte[] method_7()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0000E074 File Offset: 0x0000C274
	internal byte[] method_8()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
	internal byte[] method_9()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000282B File Offset: 0x00000A2B
	internal static bool smethod_28()
	{
		return null == null;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00002831 File Offset: 0x00000A31
	internal static object smethod_29()
	{
		return null;
	}

	// Token: 0x0400012A RID: 298
	internal static Assembly assembly_0;

	// Token: 0x0400012B RID: 299
	private static bool bool_0;

	// Token: 0x0400012C RID: 300
	private static bool bool_1;

	// Token: 0x0400012D RID: 301
	private static object object_0;

	// Token: 0x0400012E RID: 302
	private static byte[] pigniOgZaM;

	// Token: 0x0400012F RID: 303
	private static bool bool_2;

	// Token: 0x04000130 RID: 304
	private static SortedList sortedList_0;

	// Token: 0x04000131 RID: 305
	private static int int_0;

	// Token: 0x04000132 RID: 306
	private static int int_1;

	// Token: 0x04000133 RID: 307
	private static bool bool_3;

	// Token: 0x04000134 RID: 308
	internal static Hashtable IognuNxTuM;

	// Token: 0x04000135 RID: 309
	private static Class7.Delegate5 delegate5_0;

	// Token: 0x04000136 RID: 310
	private static Class7.Delegate9 delegate9_0;

	// Token: 0x04000137 RID: 311
	private static Class7.Delegate6 delegate6_0;

	// Token: 0x04000138 RID: 312
	private static int[] int_2;

	// Token: 0x04000139 RID: 313
	internal static RSACryptoServiceProvider rsacryptoServiceProvider_0;

	// Token: 0x0400013A RID: 314
	private static int int_3;

	// Token: 0x0400013B RID: 315
	private static IntPtr intptr_0;

	// Token: 0x0400013C RID: 316
	private static uint[] uint_0;

	// Token: 0x0400013D RID: 317
	private static Class7.Delegate8 delegate8_0;

	// Token: 0x0400013E RID: 318
	private static byte[] byte_0;

	// Token: 0x0400013F RID: 319
	private static long long_0;

	// Token: 0x04000140 RID: 320
	[Class7.Attribute0(typeof(Class7.Attribute0.Class8<object>[]))]
	private static bool bool_4;

	// Token: 0x04000141 RID: 321
	private static IntPtr YybnsxqiJb;

	// Token: 0x04000142 RID: 322
	internal static Class7.Delegate2 delegate2_0;

	// Token: 0x04000143 RID: 323
	private static byte[] byte_1;

	// Token: 0x04000144 RID: 324
	private static Class7.Delegate4 delegate4_0;

	// Token: 0x04000145 RID: 325
	private static Class7.Delegate7 delegate7_0;

	// Token: 0x04000146 RID: 326
	private static Dictionary<int, int> dictionary_0;

	// Token: 0x04000147 RID: 327
	internal static Class7.Delegate2 delegate2_1;

	// Token: 0x04000148 RID: 328
	private static bool rvonOlmsfE;

	// Token: 0x04000149 RID: 329
	private static bool bool_5 = false;

	// Token: 0x0400014A RID: 330
	private static IntPtr intptr_1;

	// Token: 0x0400014B RID: 331
	private static IntPtr intptr_2;

	// Token: 0x0400014C RID: 332
	private static int int_4;

	// Token: 0x0400014D RID: 333
	private static long long_1;

	// Token: 0x0400014E RID: 334
	private static string[] string_0;

	// Token: 0x02000034 RID: 52
	// (Invoke) Token: 0x060001A2 RID: 418
	private delegate void Delegate1(object o);

	// Token: 0x02000035 RID: 53
	internal class Attribute0 : Attribute
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x00002834 File Offset: 0x00000A34
		[Class7.Attribute0(typeof(Class7.Attribute0.Class8<object>[]))]
		public Attribute0(object object_0)
		{
		}

		// Token: 0x02000036 RID: 54
		internal class Class8<T>
		{
		}
	}

	// Token: 0x02000037 RID: 55
	internal class Class9
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x0000E0F4 File Offset: 0x0000C2F4
		[Class7.Attribute0(typeof(Class7.Attribute0.Class8<object>[]))]
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class7.smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class7.smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	// Token: 0x02000038 RID: 56
	// (Invoke) Token: 0x060001AA RID: 426
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate2(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x02000039 RID: 57
	// (Invoke) Token: 0x060001AE RID: 430
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate3();

	// Token: 0x0200003A RID: 58
	internal struct Struct2
	{
		// Token: 0x0400014F RID: 335
		internal bool bool_0;

		// Token: 0x04000150 RID: 336
		internal byte[] byte_0;
	}

	// Token: 0x0200003B RID: 59
	internal class Class10
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x0000283C File Offset: 0x00000A3C
		public Class10(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002850 File Offset: 0x00000A50
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000285D File Offset: 0x00000A5D
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000286B File Offset: 0x00000A6B
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000287B File Offset: 0x00000A7B
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002888 File Offset: 0x00000A88
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x04000151 RID: 337
		private BinaryReader binaryReader_0;
	}

	// Token: 0x0200003C RID: 60
	// (Invoke) Token: 0x060001B8 RID: 440
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Delegate4(IntPtr hModule, string lpName, uint lpType);

	// Token: 0x0200003D RID: 61
	// (Invoke) Token: 0x060001BC RID: 444
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate5(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x0200003E RID: 62
	// (Invoke) Token: 0x060001C0 RID: 448
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate6(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	// Token: 0x0200003F RID: 63
	// (Invoke) Token: 0x060001C4 RID: 452
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate7(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	// Token: 0x02000040 RID: 64
	// (Invoke) Token: 0x060001C8 RID: 456
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate8(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	// Token: 0x02000041 RID: 65
	// (Invoke) Token: 0x060001CC RID: 460
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate9(IntPtr ptr);

	// Token: 0x02000042 RID: 66
	[Flags]
	private enum Enum1
	{

	}
}
