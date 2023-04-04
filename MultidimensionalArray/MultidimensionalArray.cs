using System;

namespace MultidimensionalArray
{
	class Program
	{
		static void Main(string[] args)
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
}