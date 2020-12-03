
using System.Windows.Forms;

namespace GamepadMouse
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputMonitor = new GamepadMouse();
			inputMonitor.Start();
			Application.Run(new Draw());
		
			
			
		}
	}
}
