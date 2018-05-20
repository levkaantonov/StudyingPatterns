using System;
using System.Collections.Generic;
using Observer.Interfaces;
using Observer.Magazines;

namespace Observer.Subscribers
{
	/// <summary>
	/// Физ. лицо.
	/// </summary>
	internal class Person : ISubscriber, IMagazinable
	{
		/// <summary>
		/// Список полученных журналов.
		/// </summary>
		private readonly List<Magazine> _magazines;


		/// <summary>
		/// Имя подписчика.
		/// </summary>
		private readonly string _name;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="name">Имя.</param>
		public Person(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException(nameof(name));
			}

			_name = name;
			_magazines = new List<Magazine>();
		}

		/// <summary>
		/// Получить журналы.
		/// </summary>
		/// <returns>Список журналов.</returns>
		public List<Magazine> GetMagazines()
		{
			return _magazines;
		}

		/// <summary>
		/// Получить имя.
		/// </summary>
		/// <returns>Имя получателя.</returns>
		public string GetName()
		{
			return _name;
		}

		/// <summary>
		/// Добавляет журнал в список полученных журналов.
		/// </summary>
		/// <param name="magazine">Журнал.</param>
		public void Add(Magazine magazine)
		{
			if (magazine == null)
			{
				throw new ArgumentNullException(nameof(magazine));
			}

			_magazines.Add(magazine);
		}
	}
}