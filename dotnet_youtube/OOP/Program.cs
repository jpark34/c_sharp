// Object Oriented Programming

var p1 = new Person("Scott", "Nelson", new DateOnly(1970, 1, 1));
var p2 = new Person("David", "Karlsson", new DateOnly(1986, 1, 1));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Bill"));

p2.Pets.Add(new Cat("Jean"));

List<Person> people = [p1, p2];

Console.WriteLine(people.Count);

foreach(var person in people)
{
    Console.WriteLine($"{person}");
    foreach(var pet in person.Pets)
    {
        Console.WriteLine($"    {pet}");
    }
}

public class Person(string firstName, string lastName, DateOnly birthday)
{
    public string First { get; } = firstName;
    public string Last { get; } = lastName;
    public DateOnly Birthday { get; } = birthday;
    public List<Pet> Pets { get; } = new();

    public override string ToString()
    {
        return $"{First} {Last}";
    }
}

// abstract means that this class is just a model and not a concrete object
public abstract class Pet(string firstName)
{
    public string First{ get; } = firstName;
    public abstract string makeNoise();
    public override string ToString()
    {
        return $"{First} and I am a {GetType().Name} and I {makeNoise()}";
    }
}

// children classes to the parent class Pet
public class Cat(string firstName) : Pet(firstName)
{
    public override string makeNoise() => "meow";
}

public class Dog(string firstName) : Pet(firstName)
{
    public override string makeNoise() { return "bark"; }
}