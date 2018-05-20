using AbstractFactory.Airplanes;
using AbstractFactory.Cars;

namespace AbstractFactory.Factories
{
	/// <summary>
	/// Французская транспортная фабрика.
	/// </summary>
	public class FrenchFactory : AbstractVehicleFactory
	{
		/// <summary>
		/// Создать авто.
		/// </summary>
		/// <returns>Авто.</returns>
		public override AbstractCar CreateCar()
		{
			return new CitroenXs();
		}

		/// <summary>
		/// Создать самолет.
		/// </summary>
		/// <returns>Самолет.</returns>
		public override AbstractAirplane CreateAirplane()
		{
			return new Concorde();
		}
	}
}