string[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda"};

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



foreach (string manufacturer in carManufacturers)
{
    Console.WriteLine(manufacturer);
}


Array.Sort(carManufacturers);
foreach (string manufacturer in carManufacturers)
{
    Console.WriteLine(manufacturer);
}