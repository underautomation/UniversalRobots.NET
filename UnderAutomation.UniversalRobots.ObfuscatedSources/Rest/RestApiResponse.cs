//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Net;

namespace Rest {
	/// <summary>
	/// Response from a REST API call
	/// </summary>
	public class RestApiResponse {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RestApiResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Indicates whether the API call succeeded (HTTP 200)
		/// </summary>
		public bool Succeed { get; set; }

		/// <summary>
		/// HTTP status code returned by the API
		/// </summary>
		public HttpStatusCode StatusCode { get; set; }

		/// <summary>
		/// Response message or error description
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Raw JSON response body
		/// </summary>
		public string RawResponse { get; set; }
	}
}
