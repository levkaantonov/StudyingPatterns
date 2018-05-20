using System;
using System.Collections.Generic;
using Mediator.Interfaces;

namespace Mediator.Classes
{
	/// <summary>
	/// Текстовый чат.
	/// Concrete mediator.
	/// </summary>
	internal class TextChat : IChat
	{
		/// <summary>
		/// Участники чата.
		/// </summary>
		private readonly List<IUser> _users = new List<IUser>();

		/// <summary>
		/// Админ.
		/// </summary>
		internal IUser Admin { get; set; }

		/// <summary>
		/// Уведомить участников.
		/// </summary>
		/// <param name="text">Текст.</param>
		/// <param name="user">Пользователь.</param>
		public void NotifyUsers(string text, IUser user)
		{
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentNullException(nameof(text));
			}

			if (user == null)
			{
				throw new ArgumentNullException(nameof(user));
			}

			Console.WriteLine($"{user.GetName()} отправил сообщение: {text}\n");

			foreach (var u in _users)
			{
				if (u != user)
				{
					u.MessageReceived(text);
				}
			}

			Admin.MessageReceived(text);
		}

		/// <summary>
		/// Добавить пользователя в чат.
		/// </summary>
		/// <param name="user">Пользователь.</param>
		public void AddUserInChat(IUser user)
		{
			if (user == null)
			{
				throw new ArgumentNullException(nameof(user));
			}

			_users.Add(user);
		}
	}
}