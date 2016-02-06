using System;

class DoubleIt
{
	static void Main()
	{
		Console.WriteLine("Give me a numver and I will double it for you!..");
		string stringNumber = Console.ReadLine();
		int yourNumber = int.Parse(stringNumber);
		int yourDoubleNumber = yourNumber * 2;
		string stringDoubledNumber = yourDoubleNumber.ToString();
		Console.WriteLine("I doubled your number for you: "+stringDoubledNumber);
	}
}
