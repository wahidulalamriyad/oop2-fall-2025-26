// C# program to demonstrate bool
bool enabled = false;
Console.WriteLine($"bool: {enabled}");

enabled = true;
Console.WriteLine($"bool: {enabled}");

// C# program to demonstrate char
char c = 'a';
Console.WriteLine($"char: {c}");

// C# program to demonstrate int
int i = 1;
int j = 0;
int k = -5;
Console.WriteLine($"int: {i}, {j}, {k}");

// C# program to demonstrate long
long l = 1_000_000_000_000_000_000;
Console.WriteLine($"long: {l}");

// Arithmatic Operations
int multiply = 10 * 20;
int divide = 10 / 2;
int remainder = 10 % 2;
int add = 10 + 20;
int subtract = 10 - 20;
Console.WriteLine($"Multiply: {multiply}, Divide: {divide}, Remainder: {remainder}, Add: {add}, Subtract: {subtract}");

// C# program to demonstrate floating point
float f = 1.23456789f;
double d = 1.23456789d;
decimal d1 = 1.23456789m;
Console.WriteLine($"float: {f}, double: {d}, decimal: {d1}");

Console.WriteLine($"Float Calculation: {1.1111111f / 0.8234234f}");
Console.WriteLine($"Double Calculation: {1.1111111d / 0.8234234d}");
Console.WriteLine($"Decimal Calculation: {1.1111111m / 0.8234234m}");

// Copying values
int x = 10;
int y = x;
x = 20;
Console.WriteLine($"x: {x}, y: {y}");

// C# program to demonstrate Nullable
int? n = 10;
n = null;
Console.WriteLine($"Nullable: {n}");