//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ssh.Internal;

namespace Internal {
	/// <summary>
	/// Implementation of the SSH File Transfer Protocol (SFTP) over SSH for transfering files to the robot controller
	/// </summary>
	public class SftpClientInternal : SftpClientBase {

		/// <summary>
		/// Connects to Sftp robot server
		/// </summary>
		/// <param name="port">SFTP port to connect to</param>
		/// <param name="username">Robot linux username (default username is admin)</param>
		/// <param name="password">Associated user password (default is easybot)</param>
		public void Connect(int port, string username, string password)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
