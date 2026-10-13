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
catch (Exception ex)
{
    Console.WriteLine("Error: Attempted to access an array index that does not exist.");

}
finally
{
    Console.WriteLine("Array processing complete.");
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
inventory.Add("Health Potion", 5);
inventory.Add("Mana Potion", 2);
inventory.Add("Gold Coin", 100);

inventory["Health Potion"] = 20; // Update the quantity of Health Potion to 20
Console.WriteLine("Quantity of health potions: " + inventory["Health Potion"]);

try
{ 
 Console.WriteLine("Quantity of Iron Sword: " + inventory["Iron Sword"]);
    // This will throw a KeyNotFoundException because "Iron Sword" is not in the dictionary.
}
catch (Exception ex)
{
    Console.WriteLine("Error: Item not found in inventory.");
}
finally
{
    Console.WriteLine("Inventory processing complete.");
}


Console.WriteLine("\n\nChallenge 4: Exception Handling");

Console.WriteLine("Try-catch block around Challenge 1 code to handle the IndexOutOfRangeException.");


Console.WriteLine("\n\nChallenge 5: Storing custom data types and reference types");

