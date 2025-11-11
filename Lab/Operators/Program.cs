// Operators
string s1 = "Hello";
string s2 = "World";
bool areEqual = s1 == s2;
bool areNotEqual = s1 != s2;
Console.WriteLine($"Are equal: {areEqual}");
Console.WriteLine($"Are not equal: {areNotEqual}");

// && and ||
bool condition1 = (s1.Length > 3) && (s2.Length > 3);
bool condition2 = (s1.Length < 3) || (s2.Length < 3);
Console.WriteLine($"Condition1: {condition1}");
Console.WriteLine($"Condition2: {condition2}");
