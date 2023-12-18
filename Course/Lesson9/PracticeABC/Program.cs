﻿// Практика А:
// Task1


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
     void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Эвелина";
        person.Age = 17;

        Console.WriteLine("Имя: " + person.Name);
        Console.WriteLine("Возраст: " + person.Age);
    }
}

// Task2
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine("Привет, мое имя " + Name);
    }
}

class Program
{
    void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Эвелина";
        person.Age = 17;

        person.Introduce();
    }
}

// Task3
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine("Привет, мое имя " + Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Эвелина", 17);
        person.Introduce();
    }
}

// Task4
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine("Привет, мое имя " + Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[]
        {
            new Person("Эвелина", 17),
            new Person("Анна", 34),
            new Person("Сергей", 20)
        };

        foreach (Person person in people)
        {
            person.Introduce();
        }
    }
}