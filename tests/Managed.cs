using System;
using System.Runtime.InteropServices;

public class Program
{
	const string NativeLib = "NativeLib.dll";

    [DllImport(NativeLib)]
    public static extern void NativeFunc(int x);

	static void Main(string[] args)
	{
		Console.WriteLine("Hello world from managed!");
		Console.WriteLine("Calling into native code...");

		NativeFunc(42);

		Console.WriteLine("Back into managed code.");
	}
}
