namespace DependencyInjection.Interfaces
{
	/// <summary>
	/// Интерфейс генератора текста.
	/// </summary>
	internal interface ITextGenerator
	{
		/// <summary>
		/// Получить текст.
		/// </summary>
		/// <returns>Строка.</returns>
		string GetText();
	}
}