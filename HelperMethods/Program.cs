﻿// // Exercise - Discover Sort() and Reverse()
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

// // Exercise - Complete a challenge to reverse words in a sentence

// string pangram = "The quick brown fox jumps over the lazy dog";

// Console.WriteLine(string.Join(" ", pangram.Split(' ').Select(word => new string(word.Reverse().ToArray()))));

// string word = "renumeration";
// Console.WriteLine(new string(word.Reverse().ToArray()));

// void reverseString(string pangram)
// {
// char[] characters = pangram.ToCharArray();
// int start = 0;

// for (int i = 0; i <= characters.Length; i++)
// {
//   if (i == characters.Length || characters[i] == ' ')
//   {
//     Array.Reverse(characters, start, i - start);
//     start = i + 1;
//   }
// }

// Console.WriteLine(new string(characters));

//   char[] charArray = pangram.ToCharArray();
//   int start = 0;

//   for (int i = 0; i <= charArray.Length; i++)
//   {
//     if (i == charArray.Length || charArray[i] == ' ')
//     {
//       Array.Reverse(charArray, start, i - start);
//       start = i + 1;
//     }
//   }

//   Console.WriteLine(new string(charArray));
// }

// string message = "The poor people from the hills need to come down to the city and ask for help";
// reverseString(message);
// reverseString(pangram);

// // Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// var result = orderStream
//   .Split(',')
//   .Select(x => x.Length != 4 ? $"{x} \t - Error" : $"{x}")
//   .OrderBy(x => x);

// Console.WriteLine(string.Join("\n", result));

// Console.WriteLine("");

// string[] orderArray = orderStream.Split(',');
// Array.Sort(orderArray);
// string message = "";

// for (int i = 0; i < orderArray.Length; i++)
// {
//   message = orderArray[i];
//   if (orderArray[i].Length != 4)
//   {
//     message = $"{orderArray[i]} \t - Error";
//   }
//   Console.WriteLine(message);
// }

// Console.WriteLine("");

// string orderStream1 = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string result1 = orderStream1
//     .Split(',')
//     .OrderBy(x => x)  // Sort the orders alphabetically
//     .Aggregate("", (acc, x) =>
//         acc + (x.Length != 4 ? $"{x} \t - Error\n" : $"{x}\n"));

// Console.WriteLine(result1);