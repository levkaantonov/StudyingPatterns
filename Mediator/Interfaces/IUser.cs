namespace Mediator.Interfaces
{
	/// <summary>
	/// Интерфейс пользователя.
	/// Colleague.
	/// </summary>
	internal interface IUser
	{
		/// <summary>
		/// Получить имя.
		/// </summary>
		/// <returns>Имя.</returns>
		string GetName();

		/// <summary>
		/// Отправить сообщение в чат.
		/// </summary>
		/// <param name="text">Текст.</param>
		void SendMessage(string text);

		/// <summary>
		/// Полученное сообщение.
		/// </summary>
		/// <param name="text">Текст.</param>
		void MessageReceived(string text);
	}
}