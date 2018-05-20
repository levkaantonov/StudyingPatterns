using InversionOfControl.Interfaces;

namespace InversionOfControl.Classes
{
	/// <summary>
	/// Реализация создателя генератора текста.
	/// </summary>
	internal class RunTextGeneratorCreator : ITextGeneratorCreator
	{
		/// <summary>
		/// Создать генератор.
		/// </summary>
		/// <returns>Генератор текста.</returns>
		public ITextGenerator CreatTextGenerator()
		{
			return new RunTextGenerator();
		}
	}
}