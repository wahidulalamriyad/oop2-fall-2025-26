using System;

class House
{
    // === Fields ===
    private int yearBuilt;
    private double size; // in square feet or square meters

    // === Properties ===
    public int YearBuilt
    {
        get { return yearBuilt; }
        private set { yearBuilt = value; }
    }

    public double Size
    {
        get { return size; }
        private set { size = value; }
    }

    // === Constructor ===
    public House(int yearBuilt, double size)
    {
        this.YearBuilt = yearBuilt;
        this.Size = size;
    }

    // === Private Method ===
    private int HowOld()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - YearBuilt;
    }

    // === Public Method ===
    public bool CanBeSold()
    {
        return HowOld() > 15;
    }

    // === Display Method ===
    public void ShowInfo()
    {
        Console.WriteLine("\n--- House Information ---");
        Console.WriteLine($"Year Built: {YearBuilt}");
        Console.WriteLine($"Size: {Size} sq. units");
        Console.WriteLine($"Can be sold: {CanBeSold()}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== House Details Input ===");

        Console.Write("Enter the year the house was built: ");
        int yearBuilt = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of the house: ");
        double size = Convert.ToDouble(Console.ReadLine());

        // Create a House object using user input
        House myHouse = new House(yearBuilt, size);

        // Display results
        myHouse.ShowInfo();
    }
}
