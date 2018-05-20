using System;
using Mediator.Interfaces;

namespace Mediator.Classes
{
	/// <summary>
	/// Обычный пользователь.
	/// Concrete colleague.
	/// </summary>
	internal class NormalUser : IUser
	{
		/// <summary>
		/// Чат в котором участвует.
		/// </summary>
		private readonly IChat _chat;

		/// <summary>
		/// Имя пользователя.
		/// </summary>
		private readonly string _name;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="chat">Чат.</param>
		/// <param name="name">Имя.</param>
		public NormalUser(IChat chat, string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException(nameof(name));
			}

			if (chat == null)
			{
				throw new ArgumentNullException(nameof(chat));
			}

			_chat = chat;
			_name = name;
		}

		/// <summary>
		/// Получить имя пользователя.
		/// </summary>
		/// <returns></returns>
		public string GetName()
		{
			return _name;
		}

		/// <summary>
		/// Отправить сообщение в чат.
		/// </summary>
		/// <param name="text"></param>
		public void SendMessage(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentNullException(nameof(text));
			}

			_chat.NotifyUsers(text, this);
		}

		/// <summary>
		/// Полученное сообщение.
		/// </summary>
		/// <param name="text"></param>
		public void MessageReceived(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentNullException(nameof(text));
			}

			Console.WriteLine($"\t{_name} получил сообщение: {text}\n");
		}
	}
}