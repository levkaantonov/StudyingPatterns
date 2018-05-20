using Observer.Magazines;

namespace Observer.Interfaces
{
	/// <summary>
	/// Интерфейс подписчика.
	/// </summary>
	internal interface ISubscriber
	{
		/// <summary>
		/// Добавить номер журнала подписчику.
		/// </summary>
		/// <param name="magazine">Журнал.</param>
		void Add(Magazine magazine);
	}
}