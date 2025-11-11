Console.Write("Write your name: ");
String name = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Hello, " + name + "!");
Console.WriteLine($"Hello, {name}!");