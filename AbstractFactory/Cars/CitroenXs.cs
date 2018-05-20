namespace AbstractFactory.Cars
{
	/// <summary>
	/// Класс автомобиля Citroen Xs.
	/// </summary>
	public class CitroenXs : AbstractCar
	{
		/// <summary>
		/// Ехать.
		/// </summary>
		/// <returns></returns>
		public override string Drive()
		{
			return "Citroen Xs drive!";
		}

		/// <summary>
		/// Остановиться.
		/// </summary>
		/// <returns></returns>
		public override string Stop()
		{
			return "Citroen Xs stop!";
		}
	}
}