// // Write code that attempts to add an int and a string and save the result in an int

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// // Perform a cast
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// //Determine if your conversion is a "widening conversion" or a "narrowing conversion"
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($" decimal: {myDecimal}");
// Console.WriteLine($" float: {myFloat}");

// // Use ToString() to convert a number to a string
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// // Convert a string to an int using the Parse() helper method
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// // Convert a string to a int using the Convert class
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine("result: " + result);

// // Compare casting and converting a decimal into an int
// int value = (int)1.7m;
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.3m);
// Console.WriteLine(value2);

// // Exercise - Examine the TryParse() method
// string value = "12Y3";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//   Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//   Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
//   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Exercise - Complete a challenge to combine string array values as strings and as integers
string[] values = { "12.3", "45", "ABC", "11", "DEF" };