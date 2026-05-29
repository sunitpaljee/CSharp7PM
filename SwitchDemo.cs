using System;
class SwitchDemo
{
	static void Main()
	{
		int dayNum;
		Console.WriteLine("Please Enter Day Num");
		dayNum = int.Parse(Console.ReadLine());
		switch(dayNum)
		{
			case 1 :
			Console.WriteLine ("Monday");
			break;
			case 2 :
			Console.WriteLine ("Tue");
			break;
			case 3 :
			Console.WriteLine ("Wed");
			break;
			case 4 :
			Console.WriteLine ("Thus");
			break;
			case 5 :
			Console.WriteLine ("Fri");
			break;
			case 6 :
			Console.WriteLine ("Sat");
			break;
			case 7 :
			Console.WriteLine ("Sun");
			break;
			default :
			Console.WriteLine ("Envalid Day Num");
			break;
		}
	}
}
