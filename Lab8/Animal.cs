using System;

namespace Lab8;

public class Animal
{
public virtual void AnimalSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}
public class Cat : Animal
{
public override void AnimalSound()
    {
        Console.WriteLine("The cat says: Meow.");
    }
    }  
public class Dog : Animal
{
public override void AnimalSound()
    {
        Console.WriteLine("The dog says: Bow wow.");
    }
}

