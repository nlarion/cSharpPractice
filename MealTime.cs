using System;
class MealTime
{
	static void AskWhatYouAteFor(string meal)
	{
		Console.WriteLine("what did you eat for " + meal+"?");
		string yourMeal = Console.ReadLine();
		Console.WriteLine("you had " + yourMeal +" for "+meal+"...");
	}

	static void Main()
	{
		AskWhatYouAteFor("breakfast");
		AskWhatYouAteFor("lunch");
		AskWhatYouAteFor("dinner");
	}
}