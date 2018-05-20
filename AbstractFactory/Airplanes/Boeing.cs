namespace AbstractFactory.Airplanes
{
	/// <summary>
	/// Класс самолета Boeing.
	/// </summary>
	public class Boeing : AbstractAirplane
	{
		/// <summary>
		/// Полететь.
		/// </summary>
		/// <returns></returns>
		public override string Flight()
		{
			return "Boeing A320 flight!!";
		}
	}
}