using System;
using Mediator.Classes;

namespace Mediator
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Чат.
			var chat = new TextChat();

			// Пользователи.
			var admin = new Admin(chat, "Adm");
			var normalUserOne = new NormalUser(chat, "AC");
			var normalUserTwo = new NormalUser(chat, "DC");

			// Добавление пользователей в чат.
			chat.Admin = admin;
			chat.AddUserInChat(normalUserOne);
			chat.AddUserInChat(normalUserTwo);

			// Общение.
			normalUserOne.SendMessage("Where is my DC?");
			normalUserTwo.SendMessage("I'm here!!");
			admin.SendMessage("Back in black!");

			Console.ReadKey();
		}
	}
}