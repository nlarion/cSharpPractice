using System;
using System.Collections.Generic;

class Potluck
{
	static void Main()
	{
		Dictionary<string, string> whatToBring = new Dictionary<string,string>(){{"A","grapes"},{"J","juice"},{"B","Beer"},{"C","Cookies"},{"D","drink cups"}};
		string[] ppl ={"Alexandra","Cameron","Janice","Brian","David"};
		foreach(string guy in ppl)
		{
			string firstLetter = guy.Substring(0,1);
			string getWhatToBring = whatToBring[firstLetter];
			Console.WriteLine(guy+" should bring "+getWhatToBring);
		}
	}
}