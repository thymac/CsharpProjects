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

// // Exercise - Explore Clear() and Resize()
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// if (pallets[0] != null)
//   Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine("");

// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// // pallets[4] = "C01";
// // pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//   Console.WriteLine(pallet ?? "null");
// }

// // List BinarySearch() Method in C#
// List<int> numbers = new List<int> { 1, 3, 5, 7, 9 };
// int index = numbers.BinarySearch(3);
// int index2 = numbers.BinarySearch(4);
// // Console.WriteLine($"indexes of 3 and 4 respectively: {index}, {index2}");

// Console.WriteLine("Original list: " + string.Join(", ", numbers));
// if (index2 < 0)
//   numbers.Insert(~index2, 4);

// index2 = numbers.BinarySearch(4);
// // Console.WriteLine($"indexes of 3 and 4 respectively: {index}, {index2}");

// Console.WriteLine("Updated list: " + string.Join(", ", numbers));

// //  Nullable<T> method GetValueOrDefault()
// int? number = null;
// Console.WriteLine(number.GetValueOrDefault());

// // Parallelism
// Parallel.For(0, 10, i =>
// {
//   Console.WriteLine($"Processing {i} on thread {Thread.CurrentThread.ManagedThreadId}");
// });

// // Enumerable.Aggregate Method
// string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape"};

// string longestName = fruits.Aggregate("banana", (longest, next) => next.Length > longest.Length ? next : longest, fruit =>  fruit.ToUpper());
// Console.WriteLine(longestName);

// int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

// // Aggregate Helper Method
// int numEven = ints.Aggregate(0, (total, next) => next % 2 == 0 ? total + 1 : total);
// Console.WriteLine(numEven);

// // LINQ Method Where
// int[] evenArray = ints.Where(x => x % 2 == 0).ToArray();
// Console.WriteLine(string.Join(", ", evenArray));

// string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

// // Select Helper Method
// var query = fruits.Select((fruit, index) => new { index, str = fruit.Substring(0, index) });

// foreach (var obj in query)
// {
//   Console.WriteLine("{0}", obj);
// }


// // SelectMany Helper method

// SelectManyEx3();

// void SelectManyEx3()
// {
//   PetOwner[] petOwners =
//   {
//         new PetOwner { Name="Higa", Pets = new List<string>{ "Scruffy", "Sam" } },
//         new PetOwner { Name="Ashkenazi", Pets = new List<string>{ "Walker", "Sugar" } },
//         new PetOwner { Name="Price", Pets = new List<string>{ "Scratches", "Diesel" } },
//         new PetOwner { Name="Hines", Pets = new List<string>{ "Dusty" } }
//   };

//   // Project the pet owner's name and the pet's name.
//   var query =
//       petOwners
//       .SelectMany(petOwner => petOwner.Pets, (petOwner, petName) => new { petOwner, petName })
//       .Where(ownerAndPet => ownerAndPet.petName.StartsWith("S"))
//       .Select(ownerAndPet =>
//               new
//               {
//                 Owner = ownerAndPet.petOwner.Name,
//                 Pet = ownerAndPet.petName
//               }
//       );

//   // Print the results with custom formatting.
//   foreach (var obj in query)
//   {
//     Console.WriteLine($"Owner: {obj.Owner}, Pet: {obj.Pet}");
//   }
// }

// class PetOwner
// {
//   public string Name { get; set; } = string.Empty;
//   public List<string> Pets { get; set; } = new List<string>();
// }

// Custom LINQ Extension 
// int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
// var numEven = ints.WhereEven();

// Console.WriteLine(string.Join(", ", numEven));
// public static class LinQExtensions
// {
//   public static IEnumerable<int> WhereEven(this IEnumerable<int> source)
//   {
//     foreach (int number in source)
//     {
//       if (number % 2 == 0)
//         yield return number;
//     }
//   }
// }

// // Exercise - Discover Split() and Join()
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = string.Join(",", valueArray);
// Console.WriteLine(result);

// Console.WriteLine();
// string[] items = (result as string)?.Split(',');
// foreach (string item in items)
// {
//   Console.WriteLine(item);
// }

// Exercise - Complete a challenge to reverse words in a sentence
