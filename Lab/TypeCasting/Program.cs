// Implicit conversion: No special syntax, no data loss, no precision loss
// Explicit conversion: Special syntax, potential data loss, potential precision loss

int age = 20;
float weight = 78.58f;

Console.WriteLine(age + " years old");
Console.WriteLine(weight + " kg");

// Implicit conversion
long myAge = age;

// Explicit conversion
int lessWeight = (int)weight; // Precision loss
int notMyAge = (int)myAge; // No precision loss

long bigNumber = 111111111111111;
int smallNumber = (int)bigNumber;

Console.WriteLine(smallNumber);
