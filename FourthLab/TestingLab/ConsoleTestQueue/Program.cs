using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingLab;

namespace ConsoleTestQueue
{
	class Program
	{
		static void Main(string[] args)
		{
			DEQueue<string> queue = new DEQueue<string>();
			queue.Enqueue("Kate");
			queue.Enqueue("Sam");
			queue.Enqueue("Alice");
			queue.Enqueue("Tom");

			foreach (string item in queue)
				Console.WriteLine(item);
			Console.WriteLine();

			Console.WriteLine();
			string firstItem = queue.Dequeue();
			Console.WriteLine($"Извлеченный элемент: {firstItem}");
			Console.WriteLine();

			foreach (string item in queue)
				Console.WriteLine(item);
		}
	}
}
