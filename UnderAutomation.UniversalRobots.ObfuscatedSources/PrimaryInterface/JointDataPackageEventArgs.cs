//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Status of each joints
	/// </summary>
	public class JointDataPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// Base joint data
		/// </summary>
		[PackageDescription("Base joint data")]
public JointData Base { get; set; }

		/// <summary>
		/// Shoulder joint data
		/// </summary>
		[PackageDescription("Shoulder joint data")]
public JointData Shoulder { get; set; }

		/// <summary>
		/// Elbow joint data
		/// </summary>
		[PackageDescription("Elbow joint data")]
public JointData Elbow { get; set; }

		/// <summary>
		/// Wrist1 joint data
		/// </summary>
		[PackageDescription("Wrist1 joint data")]
public JointData Wrist1 { get; set; }

		/// <summary>
		/// Wrist2 joint data
		/// </summary>
		[PackageDescription("Wrist2 joint data")]
public JointData Wrist2 { get; set; }

		/// <summary>
		/// Wrist3 (Tool) joint data
		/// </summary>
		[PackageDescription("Wrist3 (Tool) joint data")]
public JointData Wrist3 { get; set; }
	}
}
