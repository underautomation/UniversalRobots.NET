//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Dashboard.Internal;

namespace Common {
	/// <summary>
	/// Setup Dashboard Client
	/// </summary>
	public class DashboardConnectParameters : DashboardClientParametersBase {

		/// <summary>
		/// Enable aDashboard client communication
		/// Default value is true
		/// </summary>
		public bool Enable { get; set; }
	}
}
