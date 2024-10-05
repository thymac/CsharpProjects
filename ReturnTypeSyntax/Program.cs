// Exercise - Understand return type syntax

// Use methods to calculate the total purchase price


// double total = 0.00;
// double minimumspend = 30.00;

// double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
// double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

// for (int i = 0; i < items.Length; i++)
// {
//   total += GetdiscountedPrice(i);
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;
// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetdiscountedPrice(int itemIndex)
// {
//   // Calculate the discounted price of the item
//   return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//   // Check if the total meets the minimum
//   return total >= minimumspend;
// }

// string FormatDecimal(double input)
// {
//   // Format the double so only 2 decimal places are displayed
//   return input.ToString(F2);
// }

// Create a method that returns an integer

int vnd = UsdToVnd();
double usd = VndToUsd(vnd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${usd} USD");

int UsdToVnd()
{
  double usd = 23.73;
  int rate = 23500;
  return (int)(usd * rate);
}

double VndToUsd(int vnd)
{
  double rate = 23500.00;
  return (vnd / rate);
}

// Exercise - Return strings from methods

string ReverseWord(string word)
{
  char[] charsArray = word.Split();

  for (int i = word.Length; i >= 0; i--)
  {
    for (int j = 0; j < word.Length; j++)
    {
      charsArray[j] = charsArray[i];
    }
  }

  return Convert.ToString(charsArray);
}