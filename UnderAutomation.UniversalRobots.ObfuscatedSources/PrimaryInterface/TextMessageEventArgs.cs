//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Describes a log message sent with URScript instruction textmsg()
	/// </summary>
	public class TextMessageEventArgs : PackageEventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public TextMessageEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Log message sent with URScript instruction textmsg()
		/// </summary>
		public string TextMessage { get; set; }
	}
}
