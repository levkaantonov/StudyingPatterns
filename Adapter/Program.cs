using System;
using Adapter.Classes;

namespace Adapter
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Взаимодействие отделов предприятия.

			// Класс отдела кадров.
			var hrSystem = new HrDepartment();

			// Класс бухгалтерской системы.
			var client = new AccountingDepartment(new EmployeeAdapter(hrSystem));
			client.ShowEmployeeList();

			Console.ReadKey();
		}
	}
}