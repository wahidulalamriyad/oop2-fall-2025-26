using NameSpaces;
using NameSpaces.Data;
using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("John", "Doe");
        House house = new House("123 Main St", 4);

        Console.WriteLine("Person: " + person);
        Console.WriteLine("House: " + house);
    }
}