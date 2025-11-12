using System.Globalization;

// Creating DateTime Instances
DateTime dateOfBirth = new DateTime(1996, 7, 21);
Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");

// Computed Values
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;
Console.WriteLine($"Today: {today}");
Console.WriteLine($"Now: {now}");
Console.WriteLine($"UTC Now: {utcNow}");

// DateTime Parsing
DateTime localDate = DateTime.Parse("21.07.1996");
DateTime usDate = DateTime.Parse("07/21/1996", new CultureInfo("en-US"));
Console.WriteLine($"Local Date: {localDate}");
Console.WriteLine($"US Date: {usDate}");

// DateTime Formatting
Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("en-US")));
Console.WriteLine(dateOfBirth.ToString("YYYY-MM-dd"));
