//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Internal robot events (such as starting or stopping a program)
	/// </summary>
	public class KeyMessageEventArgs : PackageEventArgs {

		/// <summary>
		/// Message code
		/// </summary>
		public int RobotMessageCode { get; set; }

		/// <summary>
		/// Message argument
		/// </summary>
		public int RobotMessageArgument { get; set; }

		/// <summary>
		/// Message title
		/// </summary>
		public string RobotMessageTitle { get; set; }

		/// <summary>
		/// Message key
		/// </summary>
		public string KeyTextMessage { get; set; }
	}
}
