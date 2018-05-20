using DependencyInjection.Interfaces;

namespace DependencyInjection.Classes
{
	/// <summary>
	/// Реализация генератора текста.
	/// </summary>
	internal class RunTextGenerator : ITextGenerator
	{
		/// <summary>
		/// Словарь.
		/// </summary>
		private readonly DictionarySentences _dictionary;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="dictionary">Словарь.</param>
		public RunTextGenerator(DictionarySentences dictionary)
		{
			_dictionary = dictionary;
		}

		/// <summary>
		/// Получить текст.
		/// </summary>
		/// <returns>Строка.</returns>
		public string GetText()
		{
			return _dictionary.GetSentence("run");
		}
	}
}