//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace PrimaryInterface {
	/// <summary>
	/// Firmware version for variable decoding
	/// </summary>
	public enum GlobalVariablesFirmwareVersion {

		/// <summary>
		/// FW up to 3.2
		/// </summary>
		UpTo32 = 0,

		/// <summary>
		/// FW up to 5.9
		/// </summary>
		UpTo59 = 1,

		/// <summary>
		/// Recent firmware
		/// </summary>
		Latest = 2,
	}
}
