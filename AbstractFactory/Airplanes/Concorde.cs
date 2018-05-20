namespace AbstractFactory.Airplanes
{
	/// <summary>
	/// Класс самолета Concorde.
	/// </summary>
	public class Concorde : AbstractAirplane
	{
		/// <summary>
		/// Полететь.
		/// </summary>
		/// <returns></returns>
		public override string Flight()
		{
			return "Concorde F-BTSC flight!";
		}
	}
}