using System;
using System.Collections.Generic;

class AnimalShelter
{
  public string Species;
  public int Age;
  public bool IsAdopted;

  public AnimalShelter(string animalSpecies,int animalAge, bool animalIsAdopted)
  {
    Species = animalSpecies;
    Age = animalAge;
    IsAdopted = animalIsAdopted;
  }

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
    AnimalShelter snake = new AnimalShelter("snake",3,false);
    AnimalShelter doggie = new AnimalShelter("dog",2,false);
    AnimalShelter cat = new AnimalShelter("cat",4,false);
    AnimalShelter fatcat = new AnimalShelter("cat",5,false);

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