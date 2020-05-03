using System;
using TestingLab;

namespace TestingLab.Runner
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("-------Сложение--------");

			MyInt x = new MyInt(-120);
			MyInt y = new MyInt(40);

			MyInt summ = x.Add(y);

			Console.WriteLine(summ.myNumber.ToString());

			Console.WriteLine();

			Console.WriteLine("-------Вычитание--------");

			MyInt subs = x.Subtract(y);

			Console.WriteLine(subs.myNumber.ToString());

			Console.WriteLine();

			Console.WriteLine("-------Умножение--------");

			MyInt mult = x.Multiply(y);

			Console.WriteLine(mult.myNumber.ToString());

			Console.WriteLine();

			Console.WriteLine("-------Деление--------");

			MyInt div = x.Divide(y);

			Console.WriteLine(div.myNumber.ToString());

			Console.WriteLine();

			Console.WriteLine("-------Ноибольший общий делитель--------");

			MyInt gcd = x.GCD(y);

			Console.WriteLine(gcd.myNumber.ToString());

			Console.WriteLine();

			Console.WriteLine("-------Модуль--------");

			MyInt abs = x.ABS();

			Console.WriteLine(abs.myNumber.ToString());

			Console.WriteLine();

			Console.ReadLine();
		}
	}
}