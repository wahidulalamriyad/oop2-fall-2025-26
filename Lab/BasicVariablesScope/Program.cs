int myVariable = 10;

if (myVariable > 5)
{
    int innerVariable = myVariable * 2;
    Console.WriteLine("Inner Variable: " + innerVariable);
}

// The following line would cause a compile-time error because innerVariable is not accessible here
// Console.WriteLine("Inner Variable outside if block: " + innerVariable);
Console.WriteLine("My Variable: " + myVariable);

// To demonstrate variable scope, we can declare another variable here
int anotherVariable = 20;
Console.WriteLine("Another Variable: " + anotherVariable);
