using System;
using System.Collections.Generic;

namespace DependencyInjection.Classes
{
	/// <summary>
	/// Словарь предложений.
	/// </summary>
	internal class DictionarySentences
	{
		/// <summary>
		/// Коллекция.
		/// </summary>
		private readonly Dictionary<string, string> _sentences = new Dictionary<string, string>
		{
			{"hi", "Привет, я Форрест, Форрест Гамп!"},
			{"run", "Беги Форрест, беги!!"}
		};

		/// <summary>
		/// Получить предложение.
		/// </summary>
		/// <returns>Ключ.</returns>
		public string GetSentence(string key)
		{
			if (string.IsNullOrEmpty(key))
			{
				throw new ArgumentNullException(nameof(key));
			}
			return _sentences[key];
		}
	}
}