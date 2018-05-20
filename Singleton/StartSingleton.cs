using System;

namespace Singleton
{
	/// <summary>
	/// Класс который хранит дату своего создания.
	/// </summary>
	public class StartSingleton
	{
		/// <summary>
		/// Экземпляр синглтона.
		/// </summary>
		private static StartSingleton _instance;

		/// <summary>
		/// Объект для синхронизации потоков.
		/// </summary>
		private static readonly object _syncRoot = new object();

		/// <summary>
		/// Дата создания.
		/// </summary>
		private static long _timestamp;

		/// <summary>
		/// Конструктор.
		/// </summary>
		private StartSingleton()
		{
			_timestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
		}

		/// <summary>
		/// Получить экземпляр.
		/// </summary>
		public static StartSingleton GetInstance()
		{
			if (_instance == null)
			{
				lock (_syncRoot)
				{
					if (_instance == null)
					{
						_instance = new StartSingleton();
					}
				}
			}

			return _instance;
		}

		/// <summary>
		/// Вернуть дату создания.
		/// </summary>
		public long GetDateOfCreation()
		{
			return _timestamp;
		}
	}
}