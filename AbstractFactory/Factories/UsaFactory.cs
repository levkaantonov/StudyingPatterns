using AbstractFactory.Airplanes;
using AbstractFactory.Cars;

namespace AbstractFactory.Factories
{
	/// <summary>
	/// Американская транспортная фабрика.
	/// </summary>
	public class UsaFactory : AbstractVehicleFactory
	{
		/// <summary>
		/// Создать авто.
		/// </summary>
		/// <returns>Авто.</returns>
		public override AbstractCar CreateCar()
		{
			return new DodgeRam();
		}

		/// <summary>
		/// Создать самолет.
		/// </summary>
		/// <returns>Самолет.</returns>
		public override AbstractAirplane CreateAirplane()
		{
			return new Boeing();
		}
	}
}