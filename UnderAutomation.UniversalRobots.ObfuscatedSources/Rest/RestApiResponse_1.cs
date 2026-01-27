//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rest {
	/// <summary>
	/// Generic response from a REST API call with typed value
	/// </summary>
	public class RestApiResponse<T> : RestApiResponse {

		/// <summary>
		/// Creates a new RestApiResponse from a base response
		/// </summary>
		public RestApiResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new RestApiResponse from a base response
		/// </summary>
		public RestApiResponse(RestApiResponse baseResponse)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Typed value from the response
		/// </summary>
		public T Value { get; set; }
	}
}
