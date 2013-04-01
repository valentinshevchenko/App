using Ninject;

namespace Common
{
	public class KernelContainer
	{
		private static readonly IKernel _kernel = new StandardKernel(new NinjectSettings { InjectNonPublic = true });

		public static IKernel Kernel
		{
			get { return _kernel; }
		}
	}
}