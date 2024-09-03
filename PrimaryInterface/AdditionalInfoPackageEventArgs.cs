//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Additional information
	/// </summary>
	public class AdditionalInfoPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// The free drive button is pressed
		/// </summary>
		[PackageDescription("The free drive button is pressed")]
public bool FreedriveButtonPressed { get; set; }

		/// <summary>
		/// The free drive button is enabled
		/// </summary>
		[PackageDescription("The free drive button is enabled")]
public bool FreedriveButtonEnabled { get; set; }

		/// <summary>
		/// Free drive is enable via IO
		/// </summary>
		[PackageDescription("Free drive is enable via IO")]
public bool IOEnabledFreedrive { get; set; }
	}
}
