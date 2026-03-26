//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ssh.Internal {
	/// <summary>
	/// Base class for SSH and SFTP connection parameters, including credentials and port configuration.
	/// </summary>
	public abstract class SshParametersBase {

		/// <summary>
		/// Default SSH server TCP port
		/// </summary>
		public const int DEFAULT_PORT = 22;


		protected SshParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Setup Linux Username for SSH connection 
		/// Default value is "ur" for simulator and "root" for real robot
		/// </summary>
		public string Username { get; set; }

		/// <summary>
		/// Setup Linux Password for SSH connection 
		/// Default value is "easybot"
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// SSH and SFTP TCP port. Default : 22
		/// </summary>
		public int Port { get; set; }
	}
}
