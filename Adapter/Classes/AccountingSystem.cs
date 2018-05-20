using System;
using Adapter.Interfaces;

namespace Adapter.Classes
{
	/// <summary>
	/// Бухгалтерский отдел.
	/// </summary>
	public class AccountingDepartment
	{
		/// <summary>
		/// Список сотрудников.
		/// </summary>
		private readonly IEmployees _employeeSource;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="employeeSource">Список сотрудников.</param>
		public AccountingDepartment(IEmployees employeeSource)
		{
			if (employeeSource == null)
			{
				throw new ArgumentNullException(nameof(employeeSource));
			}

			_employeeSource = employeeSource;
		}

		/// <summary>
		/// Отобразить зарегистрированных сотрудников.
		/// </summary>
		public void ShowEmployeeList()
		{
			var employee = _employeeSource.GetEmployeeList();

			Console.WriteLine("Список сотрудников:");
			Console.WriteLine("___________________");
			foreach (var item in employee)
			{
				Console.WriteLine(item);
			}
		}
	}
}