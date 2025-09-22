//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Dashboard.Internal {

	public abstract class DashboardClientParametersBase {

		/// <summary>
		/// Default Dashboard server TCP port
		/// </summary>
		public const int DEFAULT_PORT = 29999;

		/// <summary>
		/// Default receive timeout in milliseconds
		/// </summary>
		public const int DEFAULT_RECEIVE_TIMEOUT_MS = 2000;

		/// <summary>
		/// Default send timeout in milliseconds
		/// </summary>
		public const int DEFAULT_SEND_TIMEOUT_MS = 500;


		protected DashboardClientParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Dashboard client TCP port. Default : 29999
		/// </summary>
		public int Port { get; set; }

		/// <summary>
		/// Receive timeout in milliseconds. Default : 2000 ms
		/// </summary>
		public int ReceiveTimeoutMs { get; set; }

		/// <summary>
		/// Send timeout in milliseconds. Default : 500 ms
		/// </summary>
		public int SendTimeoutMs { get; set; }
	}
}
