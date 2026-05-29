using System;
class DisplayHello
{
	static void Main()
	{
		Console.Write("Please Enter your name : ");
		string name = Console.ReadLine();

		Console.Write("Please Enter your age : ");
		string age = Console.ReadLine();
		
		//int year = Convert.ToInt32(age);
		int year = int.Parse(age);
		
		int birthYear = 2026-year;

		//string abc = birthYear;

		

		//Console.WriteLine("Your name is {0} and you are {1} Years old ", name, age);
		Console.WriteLine("Your name is {0} and you have born in {1} Year", name, birthYear);

		Console.ReadLine();
	}
}