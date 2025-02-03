//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ssh.Internal;

namespace Ssh {

	public class SftpClient : SftpClientBase {

		/// <summary>
		/// Connects to the robot
		/// </summary>
		/// <param name="ip">Robot IP address</param>
		/// <param name="username">Robot linux username (default username is ur for simulator and root for real robot)</param>
		/// <param name="password">Associated user password (default is easybot)</param>
		/// <param name="port">SFTP port</param>
		public void Connect(string ip, string username, string password, int port = 22)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
