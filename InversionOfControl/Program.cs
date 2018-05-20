using System;
using InversionOfControl.Classes;

namespace InversionOfControl
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Инверсия контроля, используя Factory Method для создания необходимой реализации интерфейса.
			var hiTextGenerator = new HiTextGeneratorCreator().CreatTextGenerator();
			var speakerHi = new Speaker(hiTextGenerator);
			speakerHi.Speak();

			var runTextGenerator = new RunTextGeneratorCreator().CreatTextGenerator();
			var speakerRun = new Speaker(runTextGenerator);
			speakerRun.Speak();

			Console.ReadKey();
		}
	}
}