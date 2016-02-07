using System;
class AddOrSubtract
{
	static void Main()
	{
		Console.WriteLine("Give me a number");
		string userNumber = Console.ReadLine();
		int myNumber = int.Parse(userNumber);
		if(myNumber < 0)
		{
			Console.WriteLine(myNumber - 1);
		}
		else
		{
			Console.WriteLine(myNumber + 1);
		}
	}
}