using System;

/*public class Person
{
    public string Name { get; }
    public int Age { get; }
    public Person(string name, int age)
        => (Name, Age) = (name, age);
}*/

/* Using Constructor/Deconstructor for records
public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
    public Person(string name, int age)
        => (Name, Age) = (name, age);
    public void Deconstruct(out string name, out int age)
        => (name, age) = (Name, Age);
    
}*/

// Positional record
//public record Person(string Name, int Age);

// Derived record
public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}

public record Employee :  Person
{
    public int Id { get; init; }
}
