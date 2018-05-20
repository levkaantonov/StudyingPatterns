namespace Decorator.Component
{
	/// <summary>
	/// Класс логгирования.
	/// Abstract Component.
	/// </summary>
	internal abstract class Logger
	{
		/// <summary>
		/// Запись логов.
		/// </summary>
		/// <param name="text">Текст.</param>
		public abstract void WriteLogs(string text);
	}
}