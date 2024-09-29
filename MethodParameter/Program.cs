// Add parameters to methods

CountTo(5);

void CountTo(int max)
{
  for (int i = 0; i < max; i++)
  {
    if (i == (max - 1))
    {
      Console.WriteLine($"{i}");
    }
    else
    {
      Console.Write($"{i}, ");
    }
  }
}

// Exercise - Use parameters in methods
Console.Write(new string(' ', Console.BufferWidth));

int[] schedule = { 800, 1200, 1600, 2000 };

DisplayAdjustedTimes(schedule, 3, -12);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
  int diff = 0;

  if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
  {
    Console.WriteLine("Invalid GMT");
  }
  else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
  {
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
  }
  else
  {
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
  }

  for (int i = 0; i < times.Length; i++)
  {
    int newTime = (times[i] + diff) % 2400;
    Console.WriteLine($"{times[i]} -> {newTime}");
  }
}
