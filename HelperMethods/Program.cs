// // Exercise - Discover Sort() and Reverse()
// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (string pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Exercise - Explore Clear() and Resize()
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
if (pallets[0] != null)
  Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");

Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

foreach (var pallet in pallets)
{
  Console.WriteLine(pallet ?? "null");
}

Console.WriteLine();
string sentense = "The quick brown fox jumps over the lazy fox.";
var arraySentense = sentense.Split(" ").ToArray();
Console.WriteLine(arraySentense);