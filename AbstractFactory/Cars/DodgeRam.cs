namespace AbstractFactory.Cars
{
	/// <summary>
	/// Класс автомобиля Dodge Ram.
	/// </summary>
	public class DodgeRam : AbstractCar
	{
		/// <summary>
		/// Ехать.
		/// </summary>
		/// <returns></returns>
		public override string Drive()
		{
			return "Dodge Ram drive!";
		}

		/// <summary>
		/// Остановиться.
		/// </summary>
		/// <returns></returns>
		public override string Stop()
		{
			return "Dodge Ram stop!";
		}
	}
}