var names = new List<string> { "Scott", "Ana", "Felipe" };

names.Sort();

Console.WriteLine($"Scott is at index {names.IndexOf("Scott")}");

foreach (var name in names)
{
    Console.WriteLine($"Hello {name}");
}