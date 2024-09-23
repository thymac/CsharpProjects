// // #1 the ourAnimals array will store the following: 
// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";
// string suggestedDonation = "";

// // #2 variables that support data entry
// int maxPets = 8;
// string? readResult;
// string menuSelection = "";
// decimal decimalDonation = 0.00m;

// // #3 array used to store runtime data, there is no persisted data
// string[,] ourAnimals = new string[maxPets, 7];

// // #4 create sample data ourAnimals array entries
// for (int i = 0; i < maxPets; i++)
// {
//   switch (i)
//   {
//     case 0:
//       animalSpecies = "dog";
//       animalID = "d1";
//       animalAge = "2";
//       animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
//       animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//       animalNickname = "lola";
//       suggestedDonation = "85.00";
//       break;

//     case 1:
//       animalSpecies = "dog";
//       animalID = "d2";
//       animalAge = "9";
//       animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//       animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//       animalNickname = "gus";
//       suggestedDonation = "49.99";
//       break;

//     case 2:
//       animalSpecies = "cat";
//       animalID = "c3";
//       animalAge = "1";
//       animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//       animalPersonalityDescription = "friendly";
//       animalNickname = "snow";
//       suggestedDonation = "40.00";
//       break;

//     case 3:
//       animalSpecies = "cat";
//       animalID = "c4";
//       animalAge = "3";
//       animalPhysicalDescription = "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
//       animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
//       animalNickname = "Lion";
//       suggestedDonation = "";
//       break;

//     default:
//       animalSpecies = "";
//       animalID = "";
//       animalAge = "";
//       animalPhysicalDescription = "";
//       animalPersonalityDescription = "";
//       animalNickname = "";
//       suggestedDonation = "";
//       break;

//   }

//   ourAnimals[i, 0] = "ID #: " + animalID;
//   ourAnimals[i, 1] = "Species: " + animalSpecies;
//   ourAnimals[i, 2] = "Age: " + animalAge;
//   ourAnimals[i, 3] = "Nickname: " + animalNickname;
//   ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//   ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

//   if (!decimal.TryParse(suggestedDonation, out decimalDonation))
//   {
//     decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
//   }
//   ourAnimals[i, 6] = $"SuggestedDonation: {decimalDonation:C2}";
// }

// // #5 display the top-level menu options
// do
// {
//   // NOTE: the Console.Clear method is throwing an exception in debug sessions
//   Console.Clear();

//   Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//   Console.WriteLine(" 1. List all of our current pet information");
//   Console.WriteLine(" 2. Display all dogs with a specified characteristic");
//   Console.WriteLine();
//   Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//   readResult = Console.ReadLine();
//   if (readResult != null)
//   {
//     menuSelection = readResult.ToLower();
//   }

//   // use switch-case to process the selected menu option
//   switch (menuSelection)
//   {
//     case "1":
//       // list all pet info
//       for (int i = 0; i < maxPets; i++)
//       {
//         if (ourAnimals[i, 0] != "ID #: ")
//         {
//           Console.WriteLine();
//           for (int j = 0; j < 7; j++)
//           {
//             Console.WriteLine(ourAnimals[i, j]);
//           }
//         }
//       }
//       Console.WriteLine("\n\rPress the Enter key to continue");
//       readResult = Console.ReadLine();

//       break;

//     case "2":
//       // Display all dogs with a specified characteristic
//       string dogCharacteristic = "";

//       while (dogCharacteristic == "")
//       {
//         // have the user enter physical characteristics to search for
//         Console.WriteLine($"\nEnter one desired dog characteristic to search for");
//         readResult = Console.ReadLine();

//         if (!string.IsNullOrEmpty(readResult))
//         {
//           dogCharacteristic = readResult.ToLower();
//         }
//       }
//       Console.WriteLine("Press the Enter key to continue.");
//       readResult = Console.ReadLine();
//       break;

//     default:
//       break;
//   }

// } while (menuSelection != "exit");





















// // BinarySearch with bitwise compliment to insert into a sorted collection

// List<int> sortedList = new List<int> { 10, 20, 30, 50, 60 };

// int integer = 42;
// int index = sortedList.BinarySearch(integer);

// Console.WriteLine($"Index of {integer}: " + index);

// int insertionPoint = ~index;
// Console.WriteLine("Bitwise complimented index: " + insertionPoint);

// sortedList.Insert(insertionPoint, integer);

// Console.WriteLine(string.Join(", ", sortedList));

// // string.IsNullOrWhiteSpace method

// string str1 = " ";
// string str2 = "\t";

// bool result = string.IsNullOrWhiteSpace(str1);
// bool result2 = string.IsNullOrEmpty(str2);

// Console.WriteLine(result);
// Console.WriteLine(result2);

