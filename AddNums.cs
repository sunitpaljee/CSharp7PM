class AddNums
{
        static void Main(string[] args)
        {
	int sum =0;
            foreach (string str in args)
            {
		sum += int.Parse(str);
            }
	System.Console.WriteLine("Sum of all no's is : {0}", sum);
        }
    }