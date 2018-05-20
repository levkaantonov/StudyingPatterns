namespace Mediator.Interfaces
{
	/// <summary>
	/// Интерфейс чата.
	/// Mediator.
	/// </summary>
	internal interface IChat
	{
		/// <summary>
		/// Уведомить участников.
		/// </summary>
		/// <param name="text">Текст.</param>
		/// <param name="user">Пользователь.</param>
		void NotifyUsers(string text, IUser user);
	}
}