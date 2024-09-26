﻿// // Use the MinValue and MaxValue properties for each signed integral type

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"\nsbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int   : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long  : {long.MinValue} to {long.MaxValue}");

// // Unsigned integral types

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"\nbyte : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// // Evaluate floating-point types

// // Use the MinValue and MaxValue properties for each signed float type
// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"\nfloat    : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double   : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal  : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// Define a reference type variable

int[] data;
data = new int[3];

int[]? data2 = new int[3];

Console.WriteLine(data);
Console.WriteLine(data2.GetType().Name);