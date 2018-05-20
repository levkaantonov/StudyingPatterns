using InversionOfControl.Interfaces;

namespace InversionOfControl.Classes
{
	/// <summary>
	/// Реализация генератора текста.
	/// </summary>
	internal class HiTextGenerator : ITextGenerator
	{
		/// <summary>
		/// Получить текст.
		/// </summary>
		/// <returns>Строка.</returns>
		public string GetText()
		{
			return "Привет, я Форрест, Форрест Гамп!";
		}
	}
}