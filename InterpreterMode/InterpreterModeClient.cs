//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using InterpreterMode.Internal;

namespace InterpreterMode {

	public class InterpreterModeClient : InterpreterModeClientBase {

		/// <summary>
		/// Specifies the IP address of the robot. No TCP connection is maintained. A new connection is created when sending each command.
		/// </summary>
		/// <param name="ip">IP of the robot</param>
		/// <param name="port">Robot interpreter mode port. Default : 30020</param>
		public void Connect(string ip, int port = 30020)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
