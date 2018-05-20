using System;
using Observer.Interfaces;
using Observer.Publishers;
using Observer.Subscribers;

namespace Observer
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Подписчики.
			var sokolov = new Person("Соколов Е. А.");
			var manilova = new Person("Манилова А. М.");
			var marcenkevich = new Person("Марценкевич М. И.");
			var google = new Company("Google Inc.");

			// Издатель.
			var publisher = new Publisher();

			// Подписки.
			publisher.Subscribe(sokolov);
			publisher.Subscribe(marcenkevich);

			// Публикация и оповещение.
			publisher.NotifyAllSubscribers();

			publisher.Unsubscribe(sokolov);
			publisher.NotifyAllSubscribers();
			publisher.Subscribe(google);
			publisher.NotifyAllSubscribers();
			publisher.NotifyAllSubscribers();


			// Вывод.
			PrintMagazines(sokolov);
			WriteToConsole("");
			PrintMagazines(manilova);
			WriteToConsole("");
			PrintMagazines(marcenkevich);
			WriteToConsole("");
			PrintMagazines(google);

			Console.ReadKey();
		}


		#region Вывод на консоль

		/// <summary>
		/// Вывод списка подписчиков.
		/// </summary>
		/// <param name="magazinable"></param>
		private static void PrintMagazines(IMagazinable magazinable)
		{
			WriteToConsole(magazinable.GetName());

			foreach (var magazine in magazinable.GetMagazines())
				WriteToConsole(magazine.ToString());
		}

		/// <summary>
		/// Вывод на консоль.
		/// </summary>
		/// <param name="text">Строка.</param>
		private static void WriteToConsole(string text)
		{
			Console.WriteLine(text);
		}

		#endregion
	}
}