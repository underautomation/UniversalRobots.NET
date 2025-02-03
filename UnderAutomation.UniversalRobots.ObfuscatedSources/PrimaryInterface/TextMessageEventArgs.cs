//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Describes a log message sent with URScript instruction textmsg()
	/// </summary>
	public class TextMessageEventArgs : PackageEventArgs {

		/// <summary>
		/// Log message sent with URScript instruction textmsg()
		/// </summary>
		public string TextMessage { get; set; }
	}
}
