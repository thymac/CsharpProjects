// // Create a method to display random numbers

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers()
// {
//   Random random = new Random();

//   for (int i = 0; i < 5; i++)
//   {
//     Console.Write($"{random.Next(1, 100)} ");
//   }

//   Console.WriteLine();
// }

// // Identify duplicated code

// using System;

// int[] times = { 800, 1200, 1600, 200 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//   Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//   diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//   /* Adjust the times by adding the difference, keeping the value within 24hrs */
//   AdjustTimes();
// }
// else
// {
//   diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//   /* Adjust the times by adding the differnece, keeping the value within 24 hours */
//   AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// DisplayTimes();


// void DisplayTimes()
// {
//   /* Format and display medicine times */
//   foreach (int val in times)
//   {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//       // time = time.PadLeft(4, '0');
//       time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//       time = time.Insert(0, "0:");
//     }
//     else
//     {
//       time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
//   }

//   Console.WriteLine();
// }

// void AdjustTimes()
// {
//   for (int i = 0; i < times.Length; i++)
//   {
//     times[i] = (times[i] + diff) % 2400;
//   }
// }

// Exercise - Build code with methods

// /*
// If ipAddress consists of 4 numbers
// and
// if each ipAddress number has no leading zeroes
// and
// if each ipAddress number is in range 0 - 255

// then ipAddress is valid

// else ipAddress is is invalid
// */

// // string ipv4Input = "241.31.100.5";
// string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };

// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input)
// {
//   ValidateLength(ip);
//   ValidateZeroes(ip);
//   ValidateRange(ip);

//   if (validLength && validZeroes && validRange)
//   {
//     Console.WriteLine($"{ip} is a valid IPV4 address\n");
//   }
//   else
//   {
//     Console.WriteLine($"{ip} is an invalid IPV4 address\n");
//   }
// }

// void ValidateLength(string ip)
// {
//   string[] address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);

//   validLength = address.Length == 4;

//   if (!validLength)
//     Console.WriteLine($"{ip} is of an invalid length.");
// }

// void ValidateZeroes(string ip)
// {
//   string[] address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);

//   foreach (string number in address)
//   {
//     if (number.Length > 1 && number.StartsWith('0'))
//     {
//       Console.WriteLine($"{ip} has a number with an invalid leading '0'.");
//       validZeroes = false;
//       return;
//     }
//   }

//   validZeroes = true;
// }

// void ValidateRange(string ip)
// {
//   string[] address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);

//   int maxValue = 255;
//   int value = 0;

//   foreach (string number in address)
//   {
//     value = Convert.ToInt32(number);
//     if (value > maxValue)
//     {
//       Console.WriteLine($"{ip} has a number that's in an invalid range.");
//       validRange = false;
//       return;
//     }
//   }

//   validRange = true;
// }


// Exercise - Complete the challenge to create a reusable method

Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

TellFortune();

void TellFortune()
{
  Console.WriteLine("A fortune teller whispers the following words:");
  string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
  for (int i = 0; i < 4; i++)
  {
    Console.Write($"{text[i]} {fortune[i]} ");
  }
}