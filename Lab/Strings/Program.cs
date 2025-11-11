string str = "Hello, World!";
Console.WriteLine(str);

// Empty string
string anotherEmptyStr = string.Empty;
Console.WriteLine(anotherEmptyStr);

// Verbatim string literal
string verbatimStr = @"C:\Users\Username\Documents\file.txt";
Console.WriteLine(verbatimStr);

// String interpolation
string name = "Alice";
int age = 30;
string interpolatedStr = $"Name: {name}, Age: {age}";
Console.WriteLine(interpolatedStr);

// Multi-line string
string multiLineStr = @"This is a multi-line
string that spans
several lines.";
Console.WriteLine(multiLineStr);

// String with escape sequences
string escapeStr = "First Line\nSecond Line\tTabbed";
Console.WriteLine(escapeStr);

// String concatenation
string part1 = "Hello, ";
string part2 = "World!";
string concatenatedStr = part1 + part2;
Console.WriteLine(concatenatedStr);

// String length
int length = str.Length;
Console.WriteLine($"Length of str: {length}");

// String Substring
string subStr = str.Substring(7, 5);
Console.WriteLine($"Substring: {subStr}");

// String Replace
string replacedStr = str.Replace("World", "C#");
Console.WriteLine(replacedStr);

// String ToUpper and ToLower
string upperStr = str.ToUpper();
string lowerStr = str.ToLower();
Console.WriteLine(upperStr);
Console.WriteLine(lowerStr);

// String Trim
string paddedStr = "   Trim me   ";
string trimmedStr = paddedStr.Trim();
Console.WriteLine($"'{trimmedStr}'");

// String Parse
string numberStr = "123";
int number = int.Parse(numberStr);
double d = double.Parse("30.5");
Console.WriteLine($"Parsed number: {number}");
Console.WriteLine($"Parsed double: {d}");
