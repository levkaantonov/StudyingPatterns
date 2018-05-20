using System;
using System.Collections.Generic;
using Autofac;
using DependencyInjection.Classes;
using DependencyInjection.Interfaces;

namespace DependencyInjection
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//Инверсия контроля используя Dependency Injection.
			var container = ContainerConfig.Configure();

			var textGen = container.Resolve<IEnumerable<ITextGenerator>>();

			foreach (var gen in textGen)
			{
				var speaker = new Speaker(gen);
				speaker.Speak();
			}


			Console.ReadKey();
		}
	}
}