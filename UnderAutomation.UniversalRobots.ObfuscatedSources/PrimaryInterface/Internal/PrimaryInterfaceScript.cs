//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface.Internal {
	/// <summary>
	/// Handles Primary interface send script feature
	/// </summary>
	public class PrimaryInterfaceScript {

		/// <summary>
		/// Remotely execute script.Please see the Universal Robot Script documentation : https://www.universal-robots.com/download/.
		/// </summary>
		/// <param name="script">The script command to execute. You can for example move the robot at a specified joint coordinate with the command : movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)</param>
		public StatusCode Send(string script)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
