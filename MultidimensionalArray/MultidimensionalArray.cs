using System;

public class Program
{
	public static void Main()
	{
		int size;

		Console.Write("Enter Size : ");

		size = int.Parse(Console.ReadLine());

		for (int i = 0; i < size; i++)
		{
			for (int j = 0; j < size - i; j++)
			{
				Console.Write("*");
			}

			Console.WriteLine();
		}
	}
}