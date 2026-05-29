using System;
class IFDemo
{
	static void Main()
	{
		int x, y;
		Console.WriteLine("Please Enter month Value");
		x = int.Parse(Console.ReadLine());
		Console.WriteLine("Please Enter Y Value");
		y = int.Parse(Console.ReadLine());
		if(x>y)
		{
			Console.WriteLine("X Value is Grater");
		}
		else if(x<y)
		{
			Console.WriteLine("Y Value is Grater");
		}
		else 
		{
			Console.WriteLine("Both are equal");
		}

	}
}


