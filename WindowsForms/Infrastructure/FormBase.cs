using System.Windows.Forms;
using log4net;

namespace WindowsForms.Infrastructure
{
	public class FormBase : Form
	{
		protected ILog Log
		{
			get { return LogManager.GetLogger(this.GetType()); }
		}
	}
}