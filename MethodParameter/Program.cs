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

DisplayAdjustedTimes(schedule, 6, -6);

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

// Exercise - Understand method scope

string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

DisplayStudents(students);
DisplayStudents(new string[] { "Robert", "Vanya" });

void DisplayStudents(string[] students)
{
  foreach (string student in students)
  {
    Console.WriteLine($"{student}, ");
  }

  Console.WriteLine();
}

double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius)
{
  Console.WriteLine($"Circle with radius {radius}");
  PrintCircleArea(radius);
  PrintCircleCircumfrence(radi us);
}

void PrintCircleArea(int radius)
{
  double area = pi * (radius * radius);
  Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumfrence(int radius)
{
  double circumfrence = pi * (radius * 2);
  Console.WriteLine($"Circumfrence = {circumfrence}");
}

// Exercise - Use value and reference type parameters

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c)
{
  c = a * b;
  Console.WriteLine($"Inside Multiply method: {a} x {b} = {c}");
}

int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    Console.Write($"{item}, ");
  }
  Console.WriteLine("");
}

void Clear(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = 0;
  }
}

// Test with strings

string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(status, false);
Console.WriteLine($"End: {status}");

void SetHealth(string status, bool isHealthy)
{
  status = (isHealthy ? "Healthy" : "Unhealthy");
  Console.WriteLine($"Middle: {status}");
}

// Exercise - Methods with optional parameters

// Create an RSVP application

string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
  if (inviteOnly)
  {
    // search guestList before adding rsvp
    if (!guestList.Contains(name))
    {
      // guest is not on the guestList
      Console.WriteLine($"Sorry, {name} is not on the guest list!");
      return;
    }
  }

  rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
  count++;
}

void ShowRSVPs()
{
  Console.WriteLine($"\nTotal RSVPs: {count}");
  for (int i = 0; i < count; i++)
  {
    Console.WriteLine(rsvps[i]);
  }
}

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

// Exercise - Complete the challenge to display email addresses