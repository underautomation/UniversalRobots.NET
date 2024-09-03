//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace PrimaryInterface {
	/// <summary>
	/// TCP ports to communicate with an UR controller
	/// </summary>
	public enum Interfaces {

		/// <summary>
		/// The default port that allow reading data and sending URScript
		/// </summary>
		PrimaryInterface = 30001,

		/// <summary>
		/// The secondary port with same features as PrimaryClient
		/// </summary>
		SecondaryInterface = 30002,

		/// <summary>
		/// This port can only read data. It is unable to send URScript.
		/// </summary>
		PrimaryInterfaceReadOnly = 30011,

		/// <summary>
		/// A secondary port that can only read data. It is unable to send URScript.
		/// </summary>
		SecondaryInterfaceReadOnly = 30012,
	}
}
