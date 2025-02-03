//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Popup message that appears with the Assignment instruction or the URScript popup() function
	/// </summary>
	public class PopupMessageEventArgs : PackageEventArgs {

		/// <summary>
		/// Each popup has a unique ID
		/// </summary>
		public uint RequestId { get; set; }

		/// <summary>
		/// Type for assignment popups
		/// </summary>
		public RequestedTypes RequestedType { get; set; }

		/// <summary>
		/// Popup is a warning
		/// </summary>
		public bool Warning { get; set; }

		/// <summary>
		/// Popup is an error
		/// </summary>
		public bool Error { get; set; }

		/// <summary>
		/// Popup is blocking script execution
		/// </summary>
		public bool Blocking { get; set; }

		/// <summary>
		/// Popup title
		/// </summary>
		public string PopupMessageTitle { get; set; }

		/// <summary>
		/// Popup message, null for assignment popups
		/// </summary>
		public string PopupTextMessage { get; set; }
	}
}
