//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Event data for a request value message received from the robot (assignment popup requesting user input).
	/// </summary>
	public class RequestValueMessageEventArgs : PackageEventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RequestValueMessageEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Unique identifier of the request.
		/// </summary>
		public uint RequestId { get; set; }

		/// <summary>
		/// Data type requested from the user.
		/// </summary>
		public RequestedTypes RequestedType { get; set; }

		/// <summary>
		/// Message displayed to the user in the request popup.
		/// </summary>
		public string RequestTextMessage { get; set; }
	}
}
