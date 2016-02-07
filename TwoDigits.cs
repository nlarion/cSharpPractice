using System;
class LegalToDrink
{
	static void Main()
	{
		Console.WriteLine("Give me a number:");
		string userNumber = Console.ReadLine();
		int myNumber = int.Parse(userNumber);
		if(Math.Floor(Math.Log10(myNumber)+1)==2)
		{
			Console.WriteLine("HAS TWO DIGITS!!!!");
		}
		else
		{
			Console.WriteLine("doesnt have two digits :(");
		}
	}
}