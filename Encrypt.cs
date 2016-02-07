using System;
class MealTime
{
	static void Main()
	{
		Console.WriteLine("Enter a phrase to encrypt:");
		string userString = Console.ReadLine();
		string myEncryptedResults = userString.Replace("e","aeeeeyo");
		Console.WriteLine(myEncryptedResults);
	}
}