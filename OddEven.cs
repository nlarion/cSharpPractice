using System;

class OddEven
{
  static void Main() 
  {
    Console.WriteLine("Give me a number please: ");
    string userNumber = Console.ReadLine();
    int retNum = int.Parse(userNumber);

    for (int i = 1; i <= retNum; i++) 
    {
      if (i % 2 == 0) 
      {
        Console.WriteLine(i+ " is even");
      }
      else
      {
      	Console.WriteLine(i + " is odd");
      }
    }
  }
}