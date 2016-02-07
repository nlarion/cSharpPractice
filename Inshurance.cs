using System;

class Insurance 
{
  static void Main()
  {
    Console.WriteLine("What is your gender? (male/female)");
    string gender = Console.ReadLine();

    Console.WriteLine("How old are you?");
    string stringAge = Console.ReadLine();
    int age = int.Parse(stringAge);

    bool young = age < 26;
    bool male = gender == "male";

    if (young && male) 
    {
      Console.WriteLine("Your insurance is going to be expensive!");
    } 
    else if (young || male) 
    {
      Console.WriteLine("Your insurance is going to be pretty expensive!");
    } 
    else 
    {
      Console.WriteLine("Your insurance is going to be expensive, but it could be worse.");
    }
  }
}