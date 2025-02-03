//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Dashboard {
	/// <summary>
	/// Describe a Polysciope version (Robot firmware)
	/// </summary>
	public class PolyscopeVersion {

		/// <summary>
		/// Release date (example : "Nov 2020")
		/// </summary>
		public string Date;

		/// <summary>
		/// Firmware version
		/// </summary>
		public Version Version;

		/// <summary>
		/// String description of the firmware version (exemple : "5.0.16.8524 (Nov 2020)")
		/// </summary>
		public string Description;

		/// <summary>
		/// Returns Description of the version
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
