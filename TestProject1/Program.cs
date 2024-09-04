bool flag = true;
int value = 0;

if (flag)
{
  Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");

bool flag = true;
if (flag) Console.WriteLine(flag);

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

name = "steve";

if (name == "bob")
  Console.WriteLine("Found Bob");
else if (name == "steve")
  Console.WriteLine("Found Steve");
else
  Console.WriteLine("Found Chuck");

int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
  int total;

  total += number;

  if (number == 42 )
    bool found = true;   
}

if (found)
  Console.WriteLine("Set contains 42");

  Console.WriteLine($"Total: {total}");

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
  total += number;
  if (number == 42)
    found = true;
}

if (found)
  Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

int employeeLevel = 400;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
  case 100:
    title = "Junior Associate";
    break;
  case 200:
    title = "Senior Associate";
    break;
  case 300:
    title = "Manager";
    break;
  case 400:
    title = "Senior Manager";
    break;
  default:
    title = "Associate";
    break;
};

Console.WriteLine($"{employeeName}, {title}");


string sku = "01-BL-S";

string[] product = sku.Split('-');

string _type = product[0];
string _color = product[1];
string _size = product[2];

string type = "";
string color = "";
string size = "";


switch (_type)
{
  case "01":
    type = "Sweat shirt";
    break;
  case "02":
    type = "Tshirt";
    break;
  case "03":
    type = "Sweat pants";
    break;
  default:
    type = "Other";
    break;
}

switch (_color)
{
  case "BL":
    color = "Black";
    break;
  case "MN":
    color = "Maroon";
    break;
  default:
    color = "White";
    break;
}

switch (_size)
{
  case "S":
    size = "Small";
    break;
  case "M":
    size = "Medium";
    break;
  case "L":
    size = "Large";
    break;
  default:
    size = "One Size Fits All";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");

for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
}

for (int i = 0; i <= 100; i++)
{
  if (i % 3 == 0 && i % 5 == 0)
    Console.WriteLine($"{i} - FizzBuzz");

  else if (i % 3 == 0)
    Console.WriteLine($"{i} - Fizz");

  else if (i % 5 == 0)
    Console.WriteLine($"{i} - Buzz");

  else
    Console.WriteLine(i);
}

int number;
// Random random = new Random();
// do
// {
//   number = random.Next(1, 11);
//   Console.WriteLine(number);
// } while (number != 7)

while (number >= 3)
{
  Console.WriteLine(number);
  number = random.Next(1, 11);
}
Console.WriteLine($"Last number: {number}");

Random random = new Random();
var current = random.Next(1, 11);
do
{
  current = random.Next(1, 11);

  if (current >= 8) continue;
  Console.WriteLine(current);
} while (current != 7)

int heroHealth = 10;
int monsterHealth = 10;
Random random = new Random();

do
{
  int heroAttack = random.Next(1, 11);

  if (heroAttack >= monsterHealth)
  {
    monsterHealth -= heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");
    Console.WriteLine("Hero wins!");
    break;
  }
  else
  {
    monsterHealth -= heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

    int monsterAttack = random.Next(1, 11);
    heroHealth -= monsterAttack;

    if (heroHealth <= 0)
    {
      Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
      Console.WriteLine("Monster wins!");
      break;
    }

    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
  }
} while (monsterHealth > 0 && heroHealth > 0);

bool validEntry = false;
string? readResult;

int numericValue = 0;
bool validNumber  = false;

do
{
  readResult = Console.ReadLine();
  if (!string.IsNullOrEmpty(readResult) && readResult.Length >= 3)
  {
    validNumber = int.TryParse(readResult, out numericValue);
    if (validNumber)
    {
      validEntry = true;
      validNumber == true ? Console.WriteLine(numericValue) : Console.WriteLine(string.Empty);
    }
  }
  else
  {
    Console.WriteLine("Your input is invalid, please try again!");
  }
} while (!validEntry);


string? readResult;
bool validEntry = false;
int numericValue;

Console.WriteLine("Enter an integer value between 5 and 10");
do
{
  readResult = Console.ReadLine()?.Trim();
  if (!string.IsNullOrEmpty(readResult) && int.TryParse(readResult, out numericValue))
  {
    if (numericValue < 5 || numericValue > 10)
    {
     Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
    }
    else
    {
      Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
      validEntry = true;
    }
  }
  else
  {
    Console.WriteLine("Sorry, you entered an invalid number, please try again!");
  }
} while (!validEntry);


string? stringEntry;
string? matchedEntry;
string message;
bool validString = false;

string[] validEntries = {
  "Administrator",
  "Manager",
  "User"
};

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
  stringEntry = Console.ReadLine()?.Trim();
  if (!string.IsNullOrEmpty(stringEntry))
  {
    matchedEntry = Array.Find(validEntries, entry => entry.Equals(stringEntry, StringComparison.OrdinalIgnoreCase));
    if (matchedEntry != null)
    {
      message = matchedEntry switch
      {
        "Administrator" => "Your input (Administrator) has been accepted.",
        "Manager" => "Your input (Manager) has been accepted.",
        "User" => "Your input (User) has been accepted.",
      };
      validString = true;
    }
    else
    {
      message = $@"The role name that you entered, ""{stringEntry}"" is not valid. Enter your role name (Administrator, Manager, or User).";
    }
  }
  else
  {
    message = "The input cannot be empty. Please enter a role name (Administrator, Manager, or User).";
  }

  Console.WriteLine(message);

} while (!validString);



string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
string? subString;

foreach (string myString in myStrings)
{
  periodLocation = myString.IndexOf(".");
  if (periodLocation == -1)
  {
    Console.WriteLine("No occurence of a period character.");
  }
  else
  {
    do
    {
      subString = myString.Substring(0);
      Console.WriteLine(subString);
      if (myString.Length > periodLocation)
      {
        do
        {
          char[] trimmedCharString = char.GetChars(subString, periodLocation)
          string trimmedString = myString.TrimStart(trimmedCharString);
          periodLocation = trimmedString.IndexOf(".");

          if (periodLocation != -1 && myString.Length > periodLocation)
          {
            subString = trimmedString.Substring(0, periodLocation);
            myString.Remove(periodLocation, 1);
          }
          subString = trimmedString.Substring(0);

          Console.WriteLine(subString);
          subString += trimmedString;
        } while (periodLocation < myString.Length);
      }
    } while (periodLocation < myString.Length);
  }
}


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;
string? subString;

foreach (string? myString in myStrings)
{
  if (string.IsNullOrEmpty(myString))
  {
    Console.WriteLine("Empty string, cannot parse an empty string array!");
  }
  else
  {
    periodLocation = myString.IndexOf(".");
    string? newString = myString;
    do
    {
      if (periodLocation == -1 && myString.Length > 0)
      {
        Console.WriteLine(myString);
      }
      else
      {
        subString = newString?.Substring(0, periodLocation);
        Console.WriteLine(subString);
        char[] charSubString = subString.ToCharArray();
        string? newMyString = newString?.Remove(0, charSubString.Length);
        periodLocation = newMyString.IndexOf(".");
        newString = newMyString?.TrimStart('.');
      }
    } while (periodLocation != -1 || myString.Length > 0);
  }
}


subString = newString.Substring(0, periodLocation);
subString.Remove(0);
Console.WriteLine(subString);
char[] newCharString = subString.ToCharArray();
char[] nextString = newString.Substring(periodLocation, newCharString.Length);
newString = nextString.TrimStart(".");
periodLocation = newString.IndexOf(".");

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;

foreach (string myString in myStrings)
{
  if (myString.Length > 0)
  {
    string subString;
    int startIndex = 0;
    string newString = myString;
    periodLocation = myString.IndexOf(".");

    while (periodLocation != -1)
    {
      subString = newString.Substring(startIndex, periodLocation);
      Console.WriteLine(subString);
      string nextString = newString.Remove(startIndex, periodLocation);

      if (nextString.Length > 0)
      {
        nextString = nextString.TrimStart('.', ' ');
        periodLocation = nextString.IndexOf(".");
        if (periodLocation != -1)
        {
          newString = nextString;
        }
        else
        {
          nextString = newString.Substring(startIndex, newString.Length);
          Console.WriteLine(nextString);
          periodLocation = -1;
        }
      }
    }

    if (periodLocation == -1)
    {
      Console.WriteLine(myString);
    }
  }
  else
  {
    Console.WriteLine("Cannot parse a empty string!");
  }
}



string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string myString in myStrings)
{
  if (myString.Length > 0)
  {
    string newString = myString;
    int periodLocation;

    while ((periodLocation = newString.IndexOf('.')) != -1)
    {
      string subString = newString.Substring(0, periodLocation);
      Console.WriteLine(subString.TrimStart());

      newString = newString.Remove(0, periodLocation + 1);
      newString = newString.TrimStart();
    }

    if (newString.Length > 0)
    {
      Console.WriteLine(newString.TrimStart());
    }
  }
  else
  {
    Console.WriteLine("Cannot parse an empty string!");
  }
}
