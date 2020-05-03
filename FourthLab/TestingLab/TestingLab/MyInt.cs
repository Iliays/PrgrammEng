using System;
using System.Text;

namespace TestingLab
{
	public class MyInt
	{
		public StringBuilder myNumber = new StringBuilder(50);

		// Конструкторы

		#region Конструкторы

		public MyInt()
		{
			myNumber = new StringBuilder(50);
		}

		public MyInt(int myNumber)
		{
			if (int.MaxValue > myNumber && myNumber > int.MinValue)
				this.myNumber.Append(myNumber);
		}

		public MyInt(String myNumber)
		{
			this.myNumber.Append(myNumber);
		}

		public MyInt(Boolean myNumber)
		{
			this.myNumber.Append(myNumber);
		}

		public MyInt(byte[] myNumber)
		{
			if (myNumber[0] == 1)
				this.myNumber.Append("-");

			for (int i = 1; i < myNumber.Length; i++)
			{
				this.myNumber.Append(myNumber[i]);
			}
		}

		#endregion Конструкторы

		// Методы

		#region Методы

		// Сложение
		public MyInt Add(MyInt num)
		{
			int result = int.Parse(myNumber.ToString()) + int.Parse(num.myNumber.ToString());

			if (int.MaxValue > result && result > int.MinValue)
				return new MyInt(result);
			else
				return new MyInt("Переполнение");
		}

		// Вычитание
		public MyInt Subtract(MyInt num)
		{
			int result = int.Parse(myNumber.ToString()) - int.Parse(num.myNumber.ToString());
			if (int.MaxValue > result && result > int.MinValue)
				return new MyInt(result);
			else
				return new MyInt("Переполнение");
		}

		// Умножение
		public MyInt Multiply(MyInt num)
		{
			int result = int.Parse(myNumber.ToString()) * int.Parse(num.myNumber.ToString());
			if (int.MaxValue > result && result > int.MinValue)
				return new MyInt(result);
			else
				return new MyInt("Переполнение");
		}

		// Деление
		public MyInt Divide(MyInt num)
		{
			if (int.Parse(num.myNumber.ToString()) != 0)
			{
				int result = int.Parse(myNumber.ToString()) / int.Parse(num.myNumber.ToString());
				if (int.MaxValue > result && result > int.MinValue)
					return new MyInt(result);
				else
					return new MyInt("Переполнение");
			}
			else
			{
				return new MyInt("Деление на 0 не доступно");
			}
		}

		// Максимум
		public MyInt Max(MyInt num)
		{
			Boolean condition = int.Parse(myNumber.ToString()) >= int.Parse(num.myNumber.ToString());

			if (condition)
				return new MyInt(myNumber.ToString());
			else
				return num;
		}

		// Минимум
		public MyInt Min(MyInt num)
		{
			Boolean condition = int.Parse(myNumber.ToString()) <= int.Parse(num.myNumber.ToString());

			if (condition)
				return new MyInt(this.myNumber.ToString());
			else
				return num;
		}

		// Сравнение
		public MyInt CompareTo(MyInt num)
		{
			Boolean result = int.Parse(myNumber.ToString()).Equals(int.Parse(num.myNumber.ToString()));
			return new MyInt(result);
		}

		// Модуль
		public MyInt ABS()
		{
			return new MyInt(Math.Abs(int.Parse(myNumber.ToString())));
		}

		// Наибольший общий делитель
		public MyInt GCD(MyInt num)
		{
			int x = int.Parse(myNumber.ToString());
			int y = int.Parse(num.myNumber.ToString());

			while (y != 0)
			{
				var t = y;
				y = x % y;
				x = t;
			}
			return new MyInt(x);
		}

		// В строку
		public String toString()
		{
			return myNumber.ToString();
		}

		// В тип long
		public long longValue()
		{
			return long.Parse(myNumber.ToString());
		}

		#endregion Методы
	}
}