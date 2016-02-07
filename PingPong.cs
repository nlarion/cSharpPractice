using System;

class PingPong
{

  static void pingPong(int num)
  {
    for (int i = 0; i <= num; i++) 
    {
      if (i % 15 == 0 && i !=0) 
      {
        Console.WriteLine("Ping-Pong!");
      }
      else if(i % 5 ==0 && i !=0)
      {
         Console.WriteLine("Pong");
      }      
      else if(i % 3 ==0 && i !=0)
      {
         Console.WriteLine("Ping");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }

  static void Main() 
  {
    Console.WriteLine("Give me a number please: ");
    string userNumber = Console.ReadLine();
    int retNum = int.Parse(userNumber);
    pingPong(retNum);
  }
}