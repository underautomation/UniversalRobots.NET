//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rest.Internal;

namespace Rest {
	/// <summary>
	/// Standalone REST API client for PolyscopeX robots.
	/// Use this class when you want to interact with the REST API independently from the main UR class.
	/// </summary>
	public class RestClient : RestClientBase {

		/// <summary>
		/// Enable the REST client with the specified connection parameters.
		/// </summary>
		/// <param name="ip">IP address of the robot</param>
		/// <param name="port">HTTP port for REST API. Default: 80</param>
		/// <param name="version">REST API version to use. Default: Latest</param>
		/// <param name="timeoutMs">Request timeout in milliseconds. Default: 5000ms</param>
		public void Enable(string ip, int port = 80, RestApiVersion version = RestApiVersion.Latest, int timeoutMs = 5000)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public RestClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
