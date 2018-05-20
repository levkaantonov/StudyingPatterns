using System.Collections.Generic;
using Observer.Magazines;

namespace Observer.Interfaces
{
	/// <summary>
	/// Интерфейс вывода.
	/// </summary>
	internal interface IMagazinable
	{
		/// <summary>
		/// Возвращает все журналы которые получил подписчик.
		/// </summary>
		/// <returns>Список журналов.</returns>
		List<Magazine> GetMagazines();

		/// <summary>
		/// Получить имя подписчика.
		/// </summary>
		/// <returns>Имя подписчика.</returns>
		string GetName();
	}
}