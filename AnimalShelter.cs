using System;
using System.Collections.Generic;

class AnimalShelter
{
  public string Species;
  public int Age;
}

public class Program
{
  public static void Main()
  {
    AnimalShelter snake = new AnimalShelter();
    snake.Age = 3;
    snake.Species = "snake";

    AnimalShelter doggie = new AnimalShelter();
    doggie.Age = 2;
    doggie.Species = "dog";

    AnimalShelter cat = new AnimalShelter();
    cat.Age = 4;
    cat.Species = "cat";

    AnimalShelter fatcat = new AnimalShelter();
    fatcat.Age = 5;
    fatcat.Species = "cat";

    List<AnimalShelter> Animals = new List<AnimalShelter>() { snake, doggie, cat, fatcat };
    foreach(AnimalShelter animal in Animals)
    {
      Console.WriteLine(animal.Species);
    }
    
    Console.WriteLine("Enter maximum Age for pet: ");
    string stringMaxAge = Console.ReadLine();
    int maxAge = int.Parse(stringMaxAge);

    List<AnimalShelter> AnimalSheltersMatchingSearch = new List<AnimalShelter>();

    foreach (AnimalShelter animal in Animals) 
    {
      if (animal.Age <= maxAge) 
      {
        AnimalSheltersMatchingSearch.Add(animal);
      }
    }

    foreach(AnimalShelter animal in AnimalSheltersMatchingSearch)
    {
      Console.WriteLine(animal.Species);
    }
  }
}