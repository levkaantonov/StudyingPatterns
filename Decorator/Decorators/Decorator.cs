using System;
using Decorator.Component;

namespace Decorator.Decorators
{
	/// <summary>
	/// Декоратор добавляющий вывод логов в файл.
	/// Abstract Decorator.
	/// </summary>
	internal abstract class Decorator : Logger
	{
		/// <summary>
		/// Декорируемый объект.
		/// </summary>
		private readonly Logger _logger;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="logger">Логгер.</param>
		public Decorator(Logger logger)
		{
			if (logger == null)
			{
				throw new ArgumentNullException(nameof(logger));
			}

			_logger = logger;
		}

		/// <summary>
		/// Вывод логов.
		/// </summary>
		/// <param name="text">Текст.</param>
		public override void WriteLogs(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentNullException(nameof(text));
			}

			_logger.WriteLogs(text);
		}
	}
}