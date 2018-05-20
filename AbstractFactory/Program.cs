using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			try
			{
				// Выпуск французской фабрики.
				var frenchFactory = GetFactory("FR");
				var frenchAirplane = frenchFactory.CreateAirplane();
				WriteToConsole($"{frenchAirplane.Flight()}\n");

				var frenchCar = frenchFactory.CreateCar();
				WriteToConsole(frenchCar.Drive());
				WriteToConsole($"{frenchCar.Stop()}\n");

				// Выпуск американской фабрики.
				var usaFactory = GetFactory("US");
				var usaCar = usaFactory.CreateCar();
				WriteToConsole(usaCar.Drive());
				WriteToConsole(usaCar.Stop());
			}
			catch (Exception e)
			{
				WriteToConsole(e.Message);
			}

			Console.ReadKey();
		}

		/// <summary>
		/// Возвращает конкретную фабрику.
		/// </summary>
		/// <param name="text">Код страны.</param>
		/// <returns>Фабрика.</returns>
		private static AbstractVehicleFactory GetFactory(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentNullException(nameof(text));
			}

			switch (text)
			{
				case "FR":
					return new FrenchFactory();
				case "US":
					return new UsaFactory();
				default:
					throw new NotImplementedException($"Unsupported region: {text}");
			}
		}


		/// <summary>
		/// Вывод на консоль.
		/// </summary>
		/// <param name="text">Строка для вывода.</param>
		private static void WriteToConsole(string text)
		{
			Console.WriteLine(text);
		}
	}
}