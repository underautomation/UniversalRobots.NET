//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Dashboard.Internal;

namespace Dashboard {

	public class DashboardClient : DashboardClientBase {

		/// <summary>
		/// Specifies the IP address of the robot. No TCP connection is maintained. A new connection is created when sending each command.
		/// </summary>
		/// <param name="ip">IP of the robot</param>
		/// <param name="port">Robot dashboard server port. Default : 29999</param>
		public void Enable(string ip, int port = 29999)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
