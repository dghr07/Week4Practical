string[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda"};

// Displaying the car manufacturers in the original order.
Console.WriteLine("\nOriginal car manufacturers:");
foreach (string manufacturer in carManufacturers)
{
    Console.WriteLine(manufacturer);
}

// Displaying the car manufacturers in sorted order.
Console.WriteLine("\nSorted car manufacturers:");
Array.Sort(carManufacturers);
foreach (string manufacturer in carManufacturers)
{
    Console.WriteLine(manufacturer);
}

// Intentionally causing an IndexOutOfRangeException by accessing an index that is out of bounds.
Console.WriteLine("\nAttempting to access an out-of-bounds index:");
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