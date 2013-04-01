using System.Windows.Forms;
using WindowsForms.Properties;

namespace WindowsForms.Helpers
{
	public static class WindowsFormHelper
	{
		public static void InitAppSettings(this Form form)
		{
			form.Text = Settings.Default["AppName"] as string;
		}
	}
}