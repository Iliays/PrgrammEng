using System;
using System.Linq;
using TestingLab;

namespace DEQueue.Runner
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			DEQueue<string> queue = new DEQueue<string>();
			// добавление элементов

			Console.WriteLine("-------Добавление элементов--------");

			queue.pushBack("Bob");
			queue.pushBack("Bill");
			queue.pushBack("Tom");
			queue.pushFront("Kate");
			foreach (var item in queue)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			Console.WriteLine("-------Удаление из начала--------");

			Console.WriteLine(queue.popFront());

			Console.WriteLine();

			foreach (var item in queue)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			Console.WriteLine("-------Удаление из конца--------");

			Console.WriteLine(queue.popBack());

			Console.WriteLine();

			Console.WriteLine("-------Количество элементов в очереди--------");

			Console.WriteLine(queue.size);

			Console.WriteLine();

			foreach (var item in queue)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("-------Очищение очереди--------");

			queue.Clear();

			Console.WriteLine();

			Console.WriteLine("----Добавление элементов-----");

			queue.pushBack("Bob");
			queue.pushBack("Bill");
			queue.pushBack("Tom");
			queue.pushFront("Kate");

			foreach (var item in queue)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("-------Преобразование в список--------");

			foreach (var x in queue.convertToArray())
				Console.WriteLine(x);

			string[] ss = (string[])queue.convertToArray().Clone();

			Console.WriteLine("-------Копия списка--------");

			foreach (var x in ss.ToArray())
				Console.WriteLine(x);

			Console.WriteLine();

			Console.WriteLine("-------True потому что преобразовали очередь в список--------");
			if (ss.ToArray().GetType() == queue.convertToArray().GetType())
			{
				Console.WriteLine("True");
			}

			Console.Read();
		}
	}
}