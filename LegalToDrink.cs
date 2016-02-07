using System;
class LegalToDrink
{
	static void Main()
	{
		Console.WriteLine("Tell me your age:");
		string userAge = Console.ReadLine();
		int myAge = int.Parse(userAge);
		if(myAge < 21)
		{
			Console.WriteLine("Get bent");
		}
		else
		{
			Console.WriteLine("Have a drink my firend");
		}
	}
}