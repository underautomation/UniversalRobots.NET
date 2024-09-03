//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Tool data
	/// </summary>
	public class VersionEventArgs : PackageEventArgs {

		/// <summary>
		/// URControl project
		/// </summary>
		[PackageDescription("URControl project")]
public string ProjectName { get; set; }

		/// <summary>
		/// Major version number, for example 5 in 5.6.1.1234
		/// </summary>
		[PackageDescription("Major version number")]
public byte MajorVersion { get; set; }

		/// <summary>
		/// Minor firmware version number, for example 6 in 5.6.1.1234
		/// </summary>
		[PackageDescription("Minor firmware version number")]
public byte MinorVersion { get; set; }

		/// <summary>
		/// Firmware bugfix number, for example 1 in 5.6.1.1234
		/// </summary>
		[PackageDescription("Firmware bugfix number")]
public int BugfixVersion { get; set; }

		/// <summary>
		/// Firmware build number, for example 1234 in 5.6.1.1234
		/// </summary>
		[PackageDescription("Firmware build number")]
public int BuildNumber { get; set; }

		/// <summary>
		/// Build date of the firmware, for example "DEC 2020"
		/// </summary>
		[PackageDescription("Build date of the firmware")]
public string BuildDate { get; set; }

		/// <summary>
		/// Version of the firmware
		/// </summary>
		public Version Version { get; }
	}
}
