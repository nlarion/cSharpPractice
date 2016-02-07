using System;
using System.Collections.Generic;

class Restaurant
{
  public string Name;
  public bool Vegan;
  public bool PeanutFree;
  public bool Organic;

  public Restaurant(string name, bool vegan, bool peanutFree, bool organic )
  {
    Name = name;
    Vegan = vegan;
    PeanutFree = peanutFree;
    Organic = organic;
  }
}

public class Program
{
  public static void Main()
  {
  	Restaurant firstRestaurant = new Restaurant("bobs diner", false, false, false);
  	Restaurant secondRestaurant = new Restaurant("joes diner", true, true, true);
  	Restaurant thirdRestaurant = new Restaurant("bills diner", false, false, false);

  	List<Restaurant> restaurants = new List<Restaurant>() { firstRestaurant, secondRestaurant, thirdRestaurant };

    foreach (Restaurant restaurant in restaurants)
    {
      Console.WriteLine(restaurant.Name);
      Console.WriteLine("Vegan? " + restaurant.Vegan);
      Console.WriteLine("PeanutFree? " + restaurant.PeanutFree);
      Console.WriteLine("Organic? " + restaurant.Organic);
    }
  }
}