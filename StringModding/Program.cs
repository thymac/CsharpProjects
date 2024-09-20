// // Exercise - Use the string's IndexOf() and Substring() helper methods

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// openingPosition += 1;

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// message = "What is the value <span>between the tags</span>?";

// openingPosition = message.IndexOf("<span>");
// closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// const string openingSpan = "<span>";
// const string closingSpan = "</span>";

// int openingPosition = message.IndexOf(openingSpan);
// int closingPosition = message.IndexOf(closingSpan);

// openingPosition += openingSpan.Length;
// int length = closingPosition - openingPosition;

// Console.WriteLine(message.Substring(openingPosition, length));

// Exercise - Use the string's IndexOf() and LastIndexOf() helper methods

message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

string message = "(What if) I am (only interested) in the last (set of parentheses)?";

int openingPositon = message.LastIndexOf("(");
int closingPosition = message.LastIndexOf(")");

openingPositon += 1;
int length = closingPosition - openingPositon;

Console.WriteLine(message.Substring(openingPositon, length));

string message = "(What if) there are (more than) one (set of parenthesis)?";

int openingPosition = 0;
int closingPosition = 0;

if (message.Length > 0)
{
  while (true)
  {
    openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1);
  }
}

string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Mesage: {message}");

char[] openSymbols = { '[', '{', '('};
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);

Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);

Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
char[] openSymbols = { '[', '{', '(' };
int closingPosition = 0;

while (true)
{
  int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
  if (openingPosition == -1) break;

  string currentSymbol = message.Substring(openingPosition, 1);
  char matchingSymbol = ' ';

  switch (currentSymbol)
  {
    case "[":
      matchingSymbol = ']';
      break;

    case "{":
      matchingSymbol = '}';
      break;

    case "(":
      matchingSymbol = ')';
      break;
  }

  openingPosition += 1;
  closingPosition = message.IndexOf(matchingSymbol, openingPosition);
  int length = closingPosition - openingPosition;

  Console.WriteLine(message.Substring(openingPosition, length));
}

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
char[] openSymbols = { '[', '{', '(' };
Dictionary<char, char> symbolPairs = new Dictionary<char, char>
{
  { '[', ']' },
  { '{', '}' },
  { '(', ')' }
};
int closingPosition = 0;

while (true)
{
  // Find the next opening symbol
  int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
  if (openingPosition == -1) break; // No more opening symbols

  // Get the matching closing symbol using the dictionary
  char openingSymbol = message[openingPosition];
  if (!symbolPairs.TryGetValue(openingSymbol, out char matchingSymbol)) break;

  // Look for the closing symbol after the opening symbol
  openingPosition++;
  closingPosition = message.IndexOf(matchingSymbol, openingPosition);
  if (closingPosition == -1) break; // No matching closing symbol found

  // Calculate the substring between the symbols
  int length = closingPosition - openingPosition;
  Console.WriteLine(message.Substring(openingPosition, length));
}

// Deferred execution
var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
var even = nums.WherEven().ToList();

nums.Add(10);
nums.Add(20);
nums.Add(30);

Console.WriteLine(string.Join(", ", even));

public static class LinqExtensions
{
  public static IEnumerable<int> WherEven(this IEnumerable<int> source)
  {
    foreach (var number in source)
    {
      if (number % 2 == 0)
        yield return number;
    }
  }
}

Exercise - Use the Remove() and Replace() methods


