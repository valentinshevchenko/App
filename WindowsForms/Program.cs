using System;
using System.Windows.Forms;
using Common;
using Ninject;
using WindowsForms.Helpers;
using WindowsForms.Infrastructure;

namespace WindowsForms
{
	public static class Program
	{
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			log4net.Config.XmlConfigurator.Configure();
			KernelContainer.Kernel.Load(new InjectionConfigurationWindowsForms());

			var form = KernelContainer.Kernel.Get<FormMain>();
			form.InitAppSettings();
			Application.Run(form);
		}
	}
}
