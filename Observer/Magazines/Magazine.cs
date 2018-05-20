namespace Observer.Magazines
{
	/// <summary>
	/// Класс журнала.
	/// </summary>
	internal class Magazine
	{
		/// <summary>
		/// Количество изданных выпусков.
		/// </summary>
		private static int _counter;

		/// <summary>
		/// Номер выпуска.
		/// </summary>
		private readonly int _issue;

		/// <summary>
		/// Конструктор.
		/// </summary>
		public Magazine()
		{
			_issue = ++_counter;
		}

		public override string ToString()
		{
			return $"Номер журнала: {_issue}.";
		}
	}
}