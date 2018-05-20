using System;
using System.Collections.Generic;
using Observer.Interfaces;
using Observer.Magazines;

namespace Observer.Publishers
{
	/// <summary>
	/// Класс издатель.
	/// </summary>
	internal class Publisher : ISubscribable
	{
		/// <summary>
		/// Подписчики.
		/// </summary>
		private readonly List<ISubscriber> _subscribers;

		/// <summary>
		/// Новый журнал.
		/// </summary>
		private Magazine _newMagazine;

		/// <summary>
		/// Конструктор.
		/// </summary>
		public Publisher()
		{
			_subscribers = new List<ISubscriber>();
		}

		/// <summary>
		/// Оповестить всех подписчиков.
		/// </summary>
		public void NotifyAllSubscribers()
		{
			// Выпуск журнала.
			_newMagazine = new Magazine();

			foreach (var subscriber in _subscribers)
			{
				subscriber.Add(_newMagazine);
			}
		}

		/// <summary>
		/// Подсписать.
		/// </summary>
		/// <param name="subscriber">Подписчик.</param>
		public void Subscribe(ISubscriber subscriber)
		{
			if (subscriber == null)
			{
				throw new ArgumentNullException(nameof(subscriber));
			}

			_subscribers.Add(subscriber);
		}

		/// <summary>
		/// Отписать.
		/// </summary>
		/// <param name="subscriber">Подписчик.</param>
		public void Unsubscribe(ISubscriber subscriber)
		{
			if (subscriber == null)
			{
				throw new ArgumentNullException(nameof(subscriber));
			}

			_subscribers.Remove(subscriber);
		}
	}
}