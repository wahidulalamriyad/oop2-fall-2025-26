// Arithmatic Operations
int multiply = 10 * 20;
int divide = 10 / 2;
int remainder = 10 % 2;
int add = 10 + 20;
int subtract = 10 - 20;
Console.WriteLine($"Multiply: {multiply}, Divide: {divide}, Remainder: {remainder}, Add: {add}, Subtract: {subtract}");

// Comparison Operators
string s1 = "Hello";
string s2 = "World";
bool isEqual = s1 == s2;
bool isNotEqual = s1 != s2;
bool isGreater = s1.Length > s2.Length;
bool isLessOrEqual = s1.Length <= s2.Length;
Console.WriteLine($"Is Equal: {isEqual}, Is Not Equal: {isNotEqual}, Is Greater: {isGreater}, Is Less Or Equal: {isLessOrEqual}");

// Logical Operators
bool condition1 = true;
bool condition2 = false;
bool andResult = condition1 && condition2;
bool orResult = condition1 || condition2;
bool notResult = !condition1;
Console.WriteLine($"AND Result: {andResult}, OR Result: {orResult}, NOT Result: {notResult}");

// Increment and Decrement
int x = 5;
int y = x++; // Post-increment
int z = ++x; // Pre-increment
Console.WriteLine($"Post-increment y: {y}");
Console.WriteLine($"Pre-increment z: {z}");

// Ternary Operator
int a = 10;
int b = 20;
string result = (a > b) ? "a is greater" : "b is greater";
Console.WriteLine(result);

// Assignment Operators
int assignValue = 10;
assignValue += 5; // Equivalent to assignValue = assignValue + 5
assignValue *= 2; // Equivalent to assignValue = assignValue * 2
Console.WriteLine($"Assigned Value: {assignValue}");

// Equality Operators
int num1 = 100;
int num2 = 100;
bool isNumEqual = num1.Equals(num2);
Console.WriteLine($"Numbers are equal: {isNumEqual}");
