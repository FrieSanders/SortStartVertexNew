using System.Diagnostics;

namespace SortStartVertexNew
{
	class Program
	{
		static void Main(string[] args)
		{
			// Размеры для тестирования
			int[] testSizes = { 10000, 100000, 1000000, 10000000 };

			foreach (var size in testSizes)
			{
				// Генерация случайных дуг
				List<Tuple<int, int, int>> edges = GenerateEdges(size);

				// Замер времени до сортировки
				Stopwatch stopwatch = Stopwatch.StartNew();

				// Сортировка списка дуг
				edges.Sort((a, b) => a.Item1.CompareTo(b.Item1));

				// Замер времени после сортировки
				stopwatch.Stop();

				// Вывод времени
				Console.WriteLine($"Размер списка: {size}, Время сортировки: {stopwatch.ElapsedMilliseconds} миллисекунд");
			}
		}

		// Метод для генерации случайных дуг
		static List<Tuple<int, int, int>> GenerateEdges(int size)
		{
			Random random = new Random();
			List<Tuple<int, int, int>> edges = new List<Tuple<int, int, int>>();

			for (int i = 0; i < size; i++)
			{
				int u = random.Next(1, 1000);
				int v = random.Next(1, 1000);
				int w = random.Next(1, 1000);
				edges.Add(Tuple.Create(u, v, w));
			}

			return edges;
		}
	}
}
