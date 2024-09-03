//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ssh.Tools {
	/// <summary>
	/// Provides access to built-in remote path transformations.
	/// </summary>
	public static class RemotePathTransformation {

		/// <summary>
		/// Quotes a path in a way to be suitable to be used with a shell-based server.
		/// </summary>
		/// <returns>A quoted path.</returns>
		public static IRemotePathTransformation ShellQuote { get; }

		/// <summary>
		/// Performs no transformation.
		/// </summary>
		public static IRemotePathTransformation None { get; }

		/// <summary>
		/// Encloses a path in double quotes, and escapes any embedded double quote with a backslash.
		/// </summary>
		/// <returns>A transformation that encloses a path in double quotes, and escapes any embedded double quote with
		/// a backslash.</returns>
		public static IRemotePathTransformation DoubleQuote { get; }
	}
}
