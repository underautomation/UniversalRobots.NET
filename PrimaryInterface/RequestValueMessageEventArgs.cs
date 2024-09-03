//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Information about current robot mode
	/// </summary>
	public class RequestValueMessageEventArgs : PackageEventArgs {


		public uint RequestId { get; set; }


		public RequestedTypes RequestedType { get; set; }


		public string RequestTextMessage { get; set; }
	}
}
