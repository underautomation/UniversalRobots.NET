//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Tool mode info
	/// </summary>
	public class ToolModeInfoPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// Digital output mode
		/// </summary>
		[PackageDescription("Digital output mode")]
public OutputModes OutputMode { get; set; }

		/// <summary>
		/// Digital output 0 configuration
		/// </summary>
		[PackageDescription("Digital output 0 configuration")]
public DigitalOutputConfigurations DigitalOutputMode0 { get; set; }

		/// <summary>
		/// Digital output 1 configuration
		/// </summary>
		[PackageDescription("Digital output 1 configuration")]
public DigitalOutputConfigurations DigitalOutputMode1 { get; set; }
	}
}
