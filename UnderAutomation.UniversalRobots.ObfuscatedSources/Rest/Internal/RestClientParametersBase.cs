//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rest;

namespace Rest.Internal {
	/// <summary>
	/// Base parameters for REST API client configuration
	/// </summary>
	public abstract class RestClientParametersBase {

		/// <summary>
		/// Default REST API HTTP port
		/// </summary>
		public const int DEFAULT_PORT = 80;

		/// <summary>
		/// Default request timeout in milliseconds
		/// </summary>
		public const int DEFAULT_TIMEOUT_MS = 5000;


		protected RestClientParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// REST API HTTP port. Default: 80
		/// </summary>
		public int Port { get; set; }

		/// <summary>
		/// REST API version to use. Default: Latest
		/// </summary>
		public RestApiVersion Version { get; set; }

		/// <summary>
		/// Request timeout in milliseconds. Default: 5000ms
		/// </summary>
		public int TimeoutMs { get; set; }
	}
}
