using System;
using Decorator.Component;
using Decorator.Decorators;

namespace Decorator
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Логи.
			var oldlLog = DateTime.MinValue.ToString("dd.MM.yyyy");
			var newLog = DateTime.Now.ToString("dd.MM.yyyy");

			// В консоль.
			var logger = new ConsoleLogger();
			logger.WriteLogs($"{oldlLog} + logger");
			logger.WriteLogs($"{newLog} + logger");

			// В консоль и файл.
			var fileLogger = new FileLogger(logger);
			fileLogger.WriteLogs($"{oldlLog} + logger + fileLogger ");
			fileLogger.WriteLogs($"{newLog} + logger + fileLogger");

			Console.ReadKey();
		}
	}
}