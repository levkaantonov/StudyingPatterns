namespace InversionOfControl.Interfaces
{
	/// <summary>
	/// Создатель генератора текста.
	/// </summary>
	internal interface ITextGeneratorCreator
	{
		/// <summary>
		/// Создать генератор.
		/// </summary>
		/// <returns>Генератор текста.</returns>
		ITextGenerator CreatTextGenerator();
	}
}