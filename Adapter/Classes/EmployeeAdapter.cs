using System;
using System.Collections.Generic;
using System.Linq;
using Adapter.Interfaces;

namespace Adapter.Classes
{
	/// <summary>
	/// Адаптер.
	/// </summary>
	public class EmployeeAdapter : IEmployees
	{
		/// <summary>
		/// Отдел кадров.
		/// </summary>
		private readonly HrDepartment _hrSystem;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="hrSystem">Отдел кадров.</param>
		public EmployeeAdapter(HrDepartment hrSystem)
		{
			if (hrSystem == null)
			{
				throw new ArgumentNullException(nameof(hrSystem));
			}

			_hrSystem = hrSystem;
		}

		/// <summary>
		/// Получить список сотрудников.
		/// </summary>
		/// <returns>Список.</returns>
		public List<string> GetEmployeeList()
		{
			return _hrSystem
				.GetEmployees()
				.Select(e => $"{e.Id} {e.FullName} {e.Position}")
				.ToList();
		}
	}
}