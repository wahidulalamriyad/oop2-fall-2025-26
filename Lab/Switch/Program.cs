using System;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Simple switch statement
        int number = 2;
        switch (number)
        {
            case 1:
                Console.WriteLine("Number is one.");
                break;
            case 2:
                Console.WriteLine("Number is two.");
                break;
            case 3:
                Console.WriteLine("Number is three.");
                break;
            default:
                Console.WriteLine("Number is not one, two, or three.");
                break;
        }

        // Example 2: Switch statement with string
        string day = "Monday";
        switch (day)
        {
            case "Monday":
                Console.WriteLine("Start of the work week.");
                break;
            case "Friday":
                Console.WriteLine("End of the work week.");
                break;
            case "Saturday":
            case "Sunday":
                Console.WriteLine("It's the weekend!");
                break;
            default:
                Console.WriteLine("It's a regular weekday.");
                break;
        }

        // Example 3: Switch with pattern matching (C# 7.0 and later)
        Console.WriteLine("Enter your age:");
        string input = Console.ReadLine() ?? "";
        int age;

        switch (int.TryParse(input, out age))
        {
            case true when age < 0:
                Console.WriteLine("Age cannot be negative.");
                break;
            case true when age < 13:
                Console.WriteLine("You are a child.");
                break;
            case true when age < 20:
                Console.WriteLine("You are a teenager.");
                break;
            case true when age < 65:
                Console.WriteLine("You are an adult.");
                break;
            case true:
                Console.WriteLine("You are a senior.");
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a valid age.");
                break;
        }

        // Example 4: Switch expression (C# 8.0 and later)
        int month = 4;
        string monthName = month switch
        {
            1 => "January",
            2 => "February",
            3 => "March",
            4 => "April",
            5 => "May",
            6 => "June",
            7 => "July",
            8 => "August",
            9 => "September",
            10 => "October",
            11 => "November",
            12 => "December",
            _ => "Invalid month"
        };
        Console.WriteLine($"Month {month} is {monthName}.");

        // Example 5: Switch expression with relational patterns (C# 9.0 and later)
        Console.WriteLine("Enter a character:");
        char ch = Console.ReadLine() is string str && str.Length > 0 ? str[0] : '\0';
        string charType = ch switch
        {
            >= 'A' and <= 'Z' => "Uppercase Letter",
            >= 'a' and <= 'z' => "Lowercase Letter",
            >= '0' and <= '9' => "Digit",
            _ when char.IsWhiteSpace(ch) => "Whitespace",
            _ => "Special Character"
        };
        Console.WriteLine(charType);

    }
}
