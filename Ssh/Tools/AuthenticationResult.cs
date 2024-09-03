//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ssh.Tools {
	/// <summary>
	/// Represents possible authentication methods results
	/// </summary>
	public enum AuthenticationResult {

		/// <summary>
		/// Authentication was successful.
		/// </summary>
		Success = 0,

		/// <summary>
		/// Authentication completed with partial success.
		/// </summary>
		PartialSuccess = 1,

		/// <summary>
		/// Authentication failed.
		/// </summary>
		Failure = 2,
	}
}
