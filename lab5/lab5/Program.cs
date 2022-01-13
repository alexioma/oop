using System;

namespace lab5
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 0;
			Console.WriteLine("Введите число: ");
			try
			{
				n = int.Parse(Console.ReadLine());
				int[] arr = new int[n];

				Console.WriteLine("Введите элементы массива: ");
				for(int i = 0; i < arr.Length; i++)
				{
					arr[i] = int.Parse(Console.ReadLine());
				}
				while (true)
				{
					IOperation[] operations = { new DIV(), new MOD() };
					for (int i = 0; i < operations.Length; i++)
					{
						Console.WriteLine("{0}. {1, -25}", i, operations[i].GetName());
					}

					Console.WriteLine("Выберите операцию: ");
					int op = int.Parse(Console.ReadLine());

					Console.WriteLine("Введите число: ");
					n = int.Parse(Console.ReadLine());

					for (int i = 0; i < arr.Length; i++)
					{
						Console.WriteLine("{0} {1} {2} = {3}", arr[i], operations[op].GetSign(), n,
							operations[op].Estimate(arr[i], n));
					}
				}
			}
			catch(DivideByZeroException e)
			{
				Console.WriteLine("DivideByZeroException: " + e.Message);
			}
			catch(FormatException e)
			{
				Console.WriteLine("FormatException: " + e.Message);
			}
			catch(IndexOutOfRangeException e)
			{
				Console.WriteLine("IndexOutOfRangeException: " + e.Message);
			}
		}
	}
	interface IOperation
	{
		string GetSign();
		string GetName();
		int Estimate(int a, int b);
	}

	class DIV : IOperation
	{
		public int Estimate(int a, int b)
		{
			return a / b;
		}

		public string GetName()
		{
			return "Частное от деления";
		}

		public string GetSign()
		{
			return "/";
		}
	}

	class MOD : IOperation
	{
		public int Estimate(int a, int b)
		{
			return a % b;
		}

		public string GetName()
		{
			return "Остаток от деления";
		}

		public string GetSign()
		{
			return "%";
		}
	}
}
