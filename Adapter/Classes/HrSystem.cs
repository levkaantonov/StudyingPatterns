using System.Collections.Generic;

namespace Adapter.Classes
{
	/// <summary>
	/// Отдел кадров.
	/// Адаптируемый класс.
	/// </summary>
	public class HrDepartment
	{
		/// <summary>
		/// Получить сотрудников.
		/// </summary>
		/// <returns>Список.</returns>
		public Employee[] GetEmployees()
		{
			var employees = new[]
			{
				new Employee
				{
					Id = 100,
					FullName = "Колмогоров А. Б.",
					Position = "Team Leader"
				},
				new Employee
				{
					Id = 101,
					FullName = "Максоков А. Ю.",
					Position = "Developer"
				},
				new Employee
				{
					Id = 102,
					FullName = "Борман И. Г.",
					Position = "Developer"
				},
				new Employee
				{
					Id = 103,
					FullName = "Мамонтов Р. Д.",
					Position = "Tester"
				},
				new Employee
				{
					Id = 104,
					FullName = "Корбут М. Е.",
					Position = "Architect"
				},
				new Employee
				{
					Id = 105,
					FullName = "Майских Л. А.",
					Position = "Tester assistant"
				},
				new Employee
				{
					Id = 106,
					FullName = "Кужелев И. П.",
					Position = "Developer assistant"
				}
			};

			return employees;
		}
	}
}