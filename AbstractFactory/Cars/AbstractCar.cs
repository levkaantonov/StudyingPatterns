namespace AbstractFactory.Cars
{
	/// <summary>
	/// Абстрактный автомобиль.
	/// </summary>
	public abstract class AbstractCar
	{
		/// <summary>
		/// Ехать.
		/// </summary>
		/// <returns></returns>
		public abstract string Drive();

		/// <summary>
		/// Остановиться.
		/// </summary>
		/// <returns></returns>
		public abstract string Stop();
	}
}