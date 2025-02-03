//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Kinematics info
	/// </summary>
	public class KinematicsInfoPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// Calibration status (0 : OK)
		/// </summary>
		[PackageDescription("Calibration status (0 : OK)")]
public int CalibrationStatus { get; set; }

		/// <summary>
		/// Base kinematics info
		/// </summary>
		[PackageDescription("Base kinematics info")]
public JointKinematicsInfo Base { get; set; }

		/// <summary>
		/// Shoulder kinematics info
		/// </summary>
		[PackageDescription("Shoulder kinematics info")]
public JointKinematicsInfo Shoulder { get; set; }

		/// <summary>
		/// Elbow kinematics info
		/// </summary>
		[PackageDescription("Elbow kinematics info")]
public JointKinematicsInfo Elbow { get; set; }

		/// <summary>
		/// Wrist1 kinematics info
		/// </summary>
		[PackageDescription("Wrist1 kinematics info")]
public JointKinematicsInfo Wrist1 { get; set; }

		/// <summary>
		/// Wrist2 kinematics info
		/// </summary>
		[PackageDescription("Wrist2 kinematics info")]
public JointKinematicsInfo Wrist2 { get; set; }

		/// <summary>
		/// Wrist3 (Tool) kinematics info
		/// </summary>
		[PackageDescription("Wrist3 (Tool) kinematics info")]
public JointKinematicsInfo Wrist3 { get; set; }
	}
}
