using System;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Classes
{
	/// <summary>
	/// Класс воспроизводящий текст.
	/// </summary>
	internal class Speaker
	{
		/// <summary>
		/// Генератор текста.
		/// </summary>
		private readonly ITextGenerator _writer;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="writer">Генератор текста.</param>
		public Speaker(ITextGenerator writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException(nameof(writer));
			}

			_writer = writer;
		}

		/// <summary>
		/// Говорить.
		/// </summary>
		public void Speak()
		{
			Console.WriteLine(_writer.GetText());
		}
	}
}