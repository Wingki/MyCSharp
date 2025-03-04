using System;

class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of Person class
        Person person1 = new Person("Alice", 29);
        person1.Introduce();

        // Additional example
        Person person2 = new Person("Bob", 30);
        person2.Introduce();
    }
}
