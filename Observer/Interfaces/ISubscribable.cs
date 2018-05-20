namespace Observer.Interfaces
{
	/// <summary>
	/// Интерфейс редакции.
	/// </summary>
	internal interface ISubscribable
	{
		/// <summary>
		/// Подписать на рассылку.
		/// </summary>
		/// <param name="subscriber">Подписчик.</param>
		void Subscribe(ISubscriber subscriber);

		/// <summary>
		/// Отписать от рассылки.
		/// </summary>
		/// <param name="subscriber">Подписчик.</param>
		void Unsubscribe(ISubscriber subscriber);

		/// <summary>
		/// Оповестить подписчиков.
		/// </summary>
		void NotifyAllSubscribers();
	}
}