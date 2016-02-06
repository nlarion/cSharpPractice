using System;
class Shipping
{
	static int GetNumber(string question)
	{
		Console.WriteLine(question);
		string answer = Console.ReadLine();
		return int.Parse(answer);
	}

	static void Main()
	{
		Console.WriteLine("Tell me about what you want to ship..");
		int packageWeight = GetNumber("Weight of package?");
		int distanceToTravel = GetNumber("distance to travel?");
		int total = (packageWeight/10) +(distanceToTravel/5) /8;
		Console.WriteLine("Your shipping cost is: $"+total);
	}
}