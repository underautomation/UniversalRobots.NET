//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rest.Internal;

namespace Common {
	/// <summary>
	/// Configuration parameters for REST API connection (PolyscopeX only)
	/// </summary>
	public class RestConnectParameters : RestClientParametersBase {

		/// <summary>
		/// Enable REST API client communication.
		/// Default value is false because REST API is only available on PolyscopeX robots.
		/// </summary>
		public bool Enable { get; set; }
	}
}
