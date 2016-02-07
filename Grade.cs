using System;

class Grade 
{
  static void Main()
  {
    Console.WriteLine("What is your grade from your class?");
    string grade = Console.ReadLine();

    if (grade == "A" || grade =="B") 
    {
      Console.WriteLine("Gewd jobby");
    } 
    else if (grade == "C") 
    {
      Console.WriteLine("Hang in there buddy!");
    } 
    else 
    {
      Console.WriteLine("better practice coding more dood");
    }
  }
}