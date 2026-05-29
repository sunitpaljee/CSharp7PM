using System;
class DataTypeDemo
{
	static void Main()
	{
		int a = 100;
		long b = 6553L;

		
		float c = 10.5f;
		double d = 30.845874;
		decimal e = 45.67m;

		char f ='a';
		bool g = true;
		
		string h = "How are you all";

		object i = 50;

		byte ? j = null;

		Console.WriteLine("Value: {0} , {1} , {2} , {3} , {4} , {5} , {6} , {7} , {8}, {9} ",a,b,c,d,e,f,g,h,i,j);

		Console.WriteLine(int.MinValue);
		Console.WriteLine(int.MaxValue);

		Console.WriteLine(byte.MinValue);
		Console.WriteLine(byte.MaxValue);


	}

}