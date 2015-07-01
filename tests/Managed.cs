using System;
using System.Runtime.InteropServices;

public class Program
{
	const string NativeLib = "NativeLib.dll";

    [DllImport(NativeLib)]
    public static extern void NativeFunc();

	static void Main(string[] args)
	{
		Console.WriteLine("Hello world from managed!");
		Console.WriteLine("Calling into native code...");

		NativeFunc();

		Console.WriteLine("Back into managed code.");
	}
}