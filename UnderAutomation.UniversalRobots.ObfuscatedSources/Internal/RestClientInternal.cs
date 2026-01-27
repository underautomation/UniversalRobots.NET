//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rest.Internal;
using Rest;

namespace Internal {
	/// <summary>
	/// Internal REST client for use within the UR class
	/// </summary>
	public class RestClientInternal : RestClientBase {

		/// <summary>
		/// Enable REST client connection using the IP from the parent UR instance
		/// </summary>
		/// <param name="port">HTTP port for REST API. Default: 80</param>
		/// <param name="version">REST API version to use. Default: Latest</param>
		/// <param name="timeoutMs">Request timeout in milliseconds. Default: 5000ms</param>
		public void Enable(int port = 80, RestApiVersion version = RestApiVersion.Latest, int timeoutMs = 5000)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
