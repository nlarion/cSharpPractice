using System;

class TemperatureCheck 
{
  static void Main()
  {
    Console.WriteLine("What is the temperature outside?");
    string userTemp = Console.ReadLine();
    int localTemp = int.Parse(userTemp);

    if (localTemp>  50 && localTemp < 60) 
    {
      Console.WriteLine("put on a jacket");
    } 
    else if (localTemp > 59 ) 
    {
      Console.WriteLine("Shorts time!");
    } 
    else 
    {
      Console.WriteLine("better put on a coat");
    }
  }
}