// // Exercise - Investigate string formatting basics

// // What is Composite Formatting?

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0}, {1}!", first, second);
// Console.WriteLine(result);

// // What is string interpolation?

// first = "Hello";
// second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// // Formatting currency

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// // Formatting numbers

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");

// // Formatting percentages

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// // Combining formatting approaches

// price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);
// Console.WriteLine(yourDiscount);

// yourDiscount += $" A discount of {((price - salePrice) / price):P2}!";

// Console.WriteLine(yourDiscount);

// // Exercise - Explore string interpolation

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"InvoiceNumber: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// // Exercise - Discover padding and alignment

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '-'));


// // Working with padded strings

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

// // Exercise - Complete a challenge to apply string interpolation to a form letter

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string personalisedLetter = "";

personalisedLetter += $"Dear {customerName},\n";

personalisedLetter += $"As a cusiomer of our {currentProduct} offering we are excited to tell you about a new finacial product that would dramatically increase your return.\n\n";

personalisedLetter += $"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n\n";

personalisedLetter += $"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential would be {newProfit:C2}.\n";

string comparisonMessage = "";

comparisonMessage += $"{currentProduct.ToString().PadRight(20)} {currentReturn.ToString("P2").PadRight(9)} {currentProfit:C2}\n";
comparisonMessage += $"{newProduct.ToString().PadRight(20)} {newReturn.ToString("P2").PadRight(9)} {newProfit:C2}";

Console.WriteLine(personalisedLetter);
Console.WriteLine("Here's a quick comparison:\n");
Console.WriteLine(comparisonMessage);