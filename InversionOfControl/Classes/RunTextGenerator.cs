using InversionOfControl.Interfaces;

namespace InversionOfControl.Classes
{
	/// <summary>
	/// Реализация генератора текста.
	/// </summary>
	internal class RunTextGenerator : ITextGenerator
	{
		/// <summary>
		/// Получить текст.
		/// </summary>
		/// <returns>Строка.</returns>
		public string GetText()
		{
			return "Беги Форрест, беги!!";
		}
	}
}