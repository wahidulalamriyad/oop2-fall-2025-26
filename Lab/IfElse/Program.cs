// if-else
string s1 = "Hello";
string s2 = "World!";

if (s1.Length > s2.Length)
{
    Console.WriteLine("s1 is longer than s2");
}
else if (s1.Length < s2.Length)
{
    Console.WriteLine("s1 is shorter than s2");
}
else
{
    Console.WriteLine("s1 and s2 are of equal length");
}

// Nested if-else
int number = 15;
if (number > 0)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("The number is positive and even.");
    }
    else
    {
        Console.WriteLine("The number is positive and odd.");
    }
}
else if (number < 0)
{
    Console.WriteLine("The number is negative.");
}
else
{
    Console.WriteLine("The number is zero.");
}

// Ternary operator
int a = 10;
int b = 20;
string result = (a > b) ? "a is greater than b" : "a is not greater than b";
Console.WriteLine(result);
