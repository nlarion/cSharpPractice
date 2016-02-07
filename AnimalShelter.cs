using System;
using System.Collections.Generic;

class AnimalShelter
{
  public string Species;
  public int Age;
  public bool IsAdopted;

  public bool IsCat(){
    if(this.Species == "cat")
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public void ChangeAdopted(){
    if(this.IsAdopted == false)
    {
      this.IsAdopted = true;
    }
    else
    {
      this.IsAdopted = false;
    }
  }

}

public class Program
{
  public static void Main()
  {
    AnimalShelter snake = new AnimalShelter();
    snake.Age = 3;
    snake.Species = "snake";
    snake.IsAdopted = false;

    AnimalShelter doggie = new AnimalShelter();
    doggie.Age = 2;
    doggie.Species = "dog";
    doggie.IsAdopted = false;

    AnimalShelter cat = new AnimalShelter();
    cat.Age = 4;
    cat.Species = "cat";
    cat.IsAdopted = false;

    AnimalShelter fatcat = new AnimalShelter();
    fatcat.Age = 5;
    fatcat.Species = "cat";
    fatcat.IsAdopted = false;

    List<AnimalShelter> Animals = new List<AnimalShelter>() { snake, doggie, cat, fatcat };

    foreach(AnimalShelter animal in Animals)
    {
      Console.WriteLine(animal.Species+ " is Adopted? " +animal.IsAdopted);
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
      Console.WriteLine("Adopt "+animal.Species+"(yes/no)?");
      string adopt = Console.ReadLine();
      if(adopt=="yes"){
        animal.ChangeAdopted();
      }
    }

   foreach(AnimalShelter animal in Animals)
    {
      Console.WriteLine(animal.Species+ " is Adopted? " +animal.IsAdopted);
    }
  }
}