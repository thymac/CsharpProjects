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
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

Array.Clear(pallets, 0, 2);
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}