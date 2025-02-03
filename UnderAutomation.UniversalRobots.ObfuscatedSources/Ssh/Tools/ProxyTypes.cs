//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ssh.Tools {
	/// <summary>
	/// Specifies the type of proxy client will use to connect to server.
	/// </summary>
	public enum ProxyTypes {

		/// <summary>
		/// No proxy server.
		/// </summary>
		None = 0,

		/// <summary>
		/// A SOCKS4 proxy server.
		/// </summary>
		Socks4 = 1,

		/// <summary>
		/// A SOCKS5 proxy server.
		/// </summary>
		Socks5 = 2,

		/// <summary>
		/// A HTTP proxy server.
		/// </summary>
		Http = 3,
	}
}
