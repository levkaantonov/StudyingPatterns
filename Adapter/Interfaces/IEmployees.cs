using System.Collections.Generic;

namespace Adapter.Interfaces
{
	/// <summary>
	/// Интерфейс списка сотрудников.
	/// </summary>
	public interface IEmployees
	{
		/// <summary>
		/// Получить список сотрудников.
		/// </summary>
		/// <returns>Список.</returns>
		List<string> GetEmployeeList();
	}
}