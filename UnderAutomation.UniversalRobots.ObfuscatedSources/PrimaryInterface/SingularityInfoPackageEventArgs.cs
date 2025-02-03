//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Singularity info
	/// </summary>
	public class SingularityInfoPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// Severity of the singularity
		/// </summary>
		[PackageDescription("Severity of the singularity")]
public byte SingularitySeverity { get; set; }

		/// <summary>
		/// Type of the singularity
		/// </summary>
		[PackageDescription("Type of the singularity")]
public byte SingularityType { get; set; }
	}
}
