using System;
class LoopDemo
{
	static void Main()
	{
		int num, len;
		Console.Write("Please Enter the num for which you want table : ");
		num = int.Parse(Console.ReadLine());
		Console.Write("Please Enter the table length : ");
		len = int.Parse(Console.ReadLine());
		for(int i=1; i<=len; i++)
		{
			Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
		}
	}

}
