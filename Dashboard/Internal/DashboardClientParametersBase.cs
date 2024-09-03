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
		/// Dashboard client TCP port. Default : 29999
		/// </summary>
		public int Port { get; set; }
	}
}
