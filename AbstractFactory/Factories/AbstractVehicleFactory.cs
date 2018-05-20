using AbstractFactory.Airplanes;
using AbstractFactory.Cars;

namespace AbstractFactory.Factories
{
	/// <summary>
	/// Абстрактная транспортная фабрика.
	/// </summary>
	public abstract class AbstractVehicleFactory
	{
		/// <summary>
		/// Создать автомобиль.
		/// </summary>
		/// <returns></returns>
		public abstract AbstractCar CreateCar();

		/// <summary>
		/// Создать самолет.
		/// </summary>
		/// <returns></returns>
		public abstract AbstractAirplane CreateAirplane();
	}
}