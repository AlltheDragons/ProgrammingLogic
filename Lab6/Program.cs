namespace Lab6;

using System;

class Car
{
  public string model;
  public string color;
  public int year;

  // Example method to display car details. You can use this as an example for the other methods.
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }
  //problem 1: print
  public void Start()
    {
        Console.WriteLine("The car is starting.");
    }
  //problem 2: print
  public void Drive(int miles)
    {
      Console.WriteLine($"The car drove {miles} miles.");
    }
  //problem 3: return string
  public string GetDescription()
    {
        return $"{year} {color} {model}";
    }
  //proble 4: method
  public void Repaint(string newColor)
    {
        color = newColor;
    }
}

class Program
{
  static void Main()
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;
    myCar.Display(); // Calling the Display method
    // problem 1: call method
    myCar.Start();
    // problem 2: call method
    myCar.Drive(50);
    // problem 3: store result
    string description = myCar.GetDescription();
      Console.WriteLine(description);
    //problem 4: print repainting
    myCar.Repaint("Red");
      Console.WriteLine($"The car has been repainted to {myCar.color}.");
  }
}
