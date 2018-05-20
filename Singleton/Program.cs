using System;
using System.Threading;

namespace Singleton
{
	public class Program
	{
		private static void Main(string[] args)
		{
			// Проверка.
			var date = new DateTime(1970, 1, 1, 0, 0, 0, 0);

			new Thread(() =>
			{
				var sngTwo = StartSingleton.GetInstance();
				WriteToConsole($"Второй поток: {date.AddSeconds(sngTwo.GetDateOfCreation()).ToLocalTime()}");
			}).Start();

			var sngOne = StartSingleton.GetInstance();
			WriteToConsole($"Основной поток: {date.AddSeconds(sngOne.GetDateOfCreation()).ToLocalTime()}");

			Console.ReadKey();
		}

		/// <summary>
		/// Вывод на консоль.
		/// </summary>
		/// <param name="text">Текст.</param>
		private static void WriteToConsole(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentNullException(nameof(text));
			}

			Console.WriteLine(text);
		}
	}
}