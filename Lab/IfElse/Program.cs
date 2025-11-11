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

// switch
string day = "Monday";
switch (day)
{
    case "Monday":
        Console.WriteLine("Start of the work week.");
        break;
    case "Friday":
        Console.WriteLine("End of the work week.");
        break;
    default:
        Console.WriteLine("Midweek day.");
        break;
}
