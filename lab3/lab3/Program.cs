using System;

namespace lab3
{
	class Program
	{
		static void Main(string[] args)
		{
			IOperation[] operations = { new DIV(), new MOD(), new GCD(), new LCM() };

			int a, b;
			Console.WriteLine("Введите числа: ");
			try
			{
				a = int.Parse(Console.ReadLine());
				b = int.Parse(Console.ReadLine());

				Console.WriteLine("{0,-25} {1,15} {2,20}\n", "Название операции", "Знак операции", "Пример");
				foreach (IOperation operation in operations)
				{
					Console.WriteLine("{0,-25} {1,15} {2,20}", operation.GetName(), operation.GetSign(),
						$"{a} {operation.GetSign()} {b} = {operation.Estimate(a, b)}");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
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

	class GCD : IOperation
	{
		public int Estimate(int a, int b)
		{
			return b == 0 ? Math.Abs(a) : Estimate(b, a % b);
		}

		public string GetName()
		{
			return "Наибольший общий делитель";
		}

		public string GetSign()
		{
			return "НОД";
		}
	}

	class LCM : IOperation
	{
		public int Estimate(int a, int b)
		{
			return Math.Abs(a * b) / (new GCD()).Estimate(b, a % b);
		}

		public string GetName()
		{
			return "Наименьшее общее кратное";
		}

		public string GetSign()
		{
			return "НОК";
		}
	}
}