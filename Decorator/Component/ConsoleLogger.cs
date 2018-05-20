using System;

namespace Decorator.Component
{
	/// <summary>
	/// Консольный логгер.
	/// Concrete Component.
	/// </summary>
	internal class ConsoleLogger : Logger
	{
		/// <summary>
		/// Запись логов.
		/// </summary>
		/// <param name="text">Текст.</param>
		public override void WriteLogs(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentNullException(nameof(text));
			}

			Console.WriteLine(text);
		}
	}
}