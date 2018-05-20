using Autofac;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Classes
{
	/// <summary>
	/// Привязки интерфейсов и реализаций.
	/// </summary>
	internal static class ContainerConfig
	{
		/// <summary>
		/// Конфигурация контейнера.
		/// </summary>
		public static IContainer Configure()
		{
			// Экземпляр контейнера.
			var builder = new ContainerBuilder();

			// Сопоставление типов.
			builder.RegisterType<HiTextGenerator>()
				.Named("HiTextGenerator", typeof(HiTextGenerator))
				.As<ITextGenerator>()
				.WithParameter("dictionary", new DictionarySentences());

			builder.RegisterType<RunTextGenerator>()
				.Named("RunTextGenerator", typeof(RunTextGenerator))
				.As<ITextGenerator>()
				.WithParameter("dictionary", new DictionarySentences());

			return builder.Build();
		}
	}
}