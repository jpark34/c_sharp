// construct a new list object
// lists are mutable
var names = new List<string> { "<name>", "Ana", "Felipe" };

names.Add("David");
names.Add("Damian");
names.Add("Maria");

// run through everything that is contained in the list
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// can also iterate through a range of a list
foreach (var name in names[2..4]) {
    Console.WriteLine($"Heller {name.ToUpper()}");
}

Console.WriteLine(names);
Console.WriteLine(names[0]);
Console.WriteLine(names[^1]);

// construct a new array
var arrays = new string[] { "string", "int", "float" };

foreach (var array in arrays) {
    Console.WriteLine($"Hello {array.ToLower()}");
}