string[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda"};

foreach (string manufacturer in carManufacturers)
{
    Console.WriteLine(manufacturer);
}


Array.Sort(carManufacturers);
foreach (string manufacturer in carManufacturers)
{
    Console.WriteLine(manufacturer);
}