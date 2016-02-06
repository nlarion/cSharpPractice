using System;

class AlwaysOne
{
	static void Main()
	{
		Console.WriteLine("Give me two integers");
		Console.WriteLine("I will add them together");
		Console.WriteLine("The first please:");
		string stringNumber1 = Console.ReadLine();
		Console.WriteLine("The second please:");
		string stringNumber2 = Console.ReadLine();
		int yourNumber1 = int.Parse(stringNumber1);
		int yourNumber2 = int.Parse(stringNumber2);
		int addition = yourNumber1*yourNumber2;
		string ret = addition.ToString();
		Console.WriteLine("Here it is: "+ ret);
	}
}