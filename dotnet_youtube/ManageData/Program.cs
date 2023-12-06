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