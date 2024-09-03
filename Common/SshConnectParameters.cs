//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ssh.Internal;

namespace Common {
	/// <summary>
	/// Setup SSH client
	/// </summary>
	public class SshConnectParameters : SshParametersBase {

		/// <summary>
		/// Choose to enable SSH command line client
		/// Default value is false
		/// </summary>
		public bool EnableSsh { get; set; }

		/// <summary>
		/// Choose to enable FTP
		/// Default value is false
		/// </summary>
		public bool EnableSftp { get; set; }
	}
}
