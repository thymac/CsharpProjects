// Exercise - Investigate string formatting basics

// What is Composite Formatting?

string first = "Hello";
string second = "World";
string result = string.Format("{0}, {1}!", first, second);
Console.WriteLine(result);

// What is string interpolation?

first = "Hello";
second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// Formatting currency

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// Formatting numbers

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

// Formatting percentages

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

// Combining formatting approaches

price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);
Console.WriteLine(yourDiscount);

yourDiscount += $" A discount of {((price - salePrice) / price):P2}!";

Console.WriteLine(yourDiscount);