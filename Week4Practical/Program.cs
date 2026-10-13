Console.WriteLine("Challenge 1: Using arrays and forcing errors:");
string[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda"};

// Displaying the car manufacturers in the original order.
Console.WriteLine("Original car manufacturers:");
foreach (string manufacturer in carManufacturers)
{
    Console.WriteLine(manufacturer);
}

// Displaying the car manufacturers in sorted order.
Console.WriteLine("Sorted car manufacturers:");
Array.Sort(carManufacturers);
foreach (string manufacturer in carManufacturers)
{
    Console.WriteLine(manufacturer);
}

// Intentionally causing an IndexOutOfRangeException by accessing an index that is out of bounds.
Console.WriteLine("Attempting to access an out-of-bounds index:");
try
{
    for (int carIndex = 0; carIndex <= carManufacturers.Length; carIndex++)
    {
        Console.WriteLine(carManufacturers[carIndex]);
    }
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);

}


Console.WriteLine("\n\nChallenge 2: Dynamic Lists");
List<string> months = new List<string>();
months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");
// Print number of months in the list.
Console.WriteLine("Number of months: " + months.Count);

months.Remove("September");
months.Remove("November");
// Print number of months after removal.
Console.WriteLine("Number of months after removal: " + months.Count);

Console.WriteLine("The index of 'December' is: " + months.IndexOf("December"));

string[] monthNamesArray = months.ToArray();

Console.WriteLine("\n\nChallenge 3: Dictionaries and key-value pairs");
Dictionary<string, int> inventory = new Dictionary<string, int>();



Console.WriteLine("\n\nChallenge 4: Exception Handling");




Console.WriteLine("\n\nChallenge 5: Storing custom data types and reference types");

