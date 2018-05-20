using System;
using System.IO;
using System.Text;
using Decorator.Component;

namespace Decorator.Decorators
{
	/// <summary>
	/// Файловый логгер.
	/// Concrete Decorator.
	/// </summary>
	internal class FileLogger : Decorator
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="logger"></param>
		public FileLogger(Logger logger) : base(logger)
		{
		}

		/// <summary>
		/// Запись в файл.
		/// </summary>
		/// <remarks>Логи в папке проекта - bin.</remarks>
		/// <param name="text">Текст.</param>
		private void WriteToFile(string text)
		{
			using (var fileStream = new FileStream($"{Directory.GetCurrentDirectory()}\\Log.txt",
				FileMode.Append,
				FileAccess.Write))
			{
				fileStream.Write(Encoding.UTF8.GetBytes(text), 0, text.Length);
			}
		}

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

			base.WriteLogs($"{text}");
			WriteToFile(text);
		}
	}
}