using System;

class FavoriteFoods
{
  static void Main() 
  {
    string[] foods = { "baccon", "cookies", "cup noodle", "burritos", "curry", "rice","feline supplement 25","eight","nine","ten" };
    for (int i = 0; i < foods.Length; i++) 
    {
      if (i <5) 
      {
        Console.WriteLine("I am Eathing: "+foods[i]);
      }
      else
      {
      	Console.WriteLine("I am full, so no "+foods[i]);
      }
    }
  }
}