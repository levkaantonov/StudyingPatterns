using System;
using InversionOfControl.Interfaces;

namespace InversionOfControl.Classes
{
	/// <summary>
	/// Класс воспроизводящий текст.
	/// </summary>
	internal class Speaker
	{
		/// <summary>
		/// Генератор.
		/// </summary>
		private readonly ITextGenerator _writer;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="writer">Генератор.</param>
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