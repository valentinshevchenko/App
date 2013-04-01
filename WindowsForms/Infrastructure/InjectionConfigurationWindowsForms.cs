using Ninject.Modules;

namespace WindowsForms.Infrastructure
{
	public class InjectionConfigurationWindowsForms : NinjectModule
	{
		public override void Load()
		{
			Bind<FormMain>().ToSelf();
		}
	}
}