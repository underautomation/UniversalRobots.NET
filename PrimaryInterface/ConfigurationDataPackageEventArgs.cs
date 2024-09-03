//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Joint configuration
	/// </summary>
	public class ConfigurationDataPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// Default joint angular speed in rad/s
		/// </summary>
		[PackageDescription("Default joint angular speed in rad/s", PackageUnit.RadianPerSecond)]
public double VJointDefault { get; set; }

		/// <summary>
		/// Default joint acceleration speed in rad/s²
		/// </summary>
		[PackageDescription("Default joint acceleration speed in rad/s²", PackageUnit.RadianPerSecondSquared)]
public double AJointDefault { get; set; }

		/// <summary>
		/// Default TCP speed speed in m/s
		/// </summary>
		[PackageDescription("Default TCP speed speed in m/s", PackageUnit.MeterPerSecond)]
public double VToolDefault { get; set; }

		/// <summary>
		/// Default TCP acceleration speed in m/s²
		/// </summary>
		[PackageDescription("Default TCP acceleration speed in m/s²", PackageUnit.MeterPersSecondSquared)]
public double AToolDefault { get; set; }

		/// <summary>
		/// Equipment radius in meter
		/// </summary>
		[PackageDescription("Equipment radius in meter", PackageUnit.Meter)]
public double EqRadius { get; set; }

		/// <summary>
		/// Masterboard version
		/// </summary>
		[PackageDescription("Masterboard version")]
public int MasterboardVersion { get; set; }

		/// <summary>
		/// Controller box type
		/// </summary>
		[PackageDescription("Controller box type")]
public ControllerBoxTypes ControllerBoxType { get; set; }

		/// <summary>
		/// Model of the robot (UR3, UR5, UR10, UR16)
		/// </summary>
		[PackageDescription("Model of the robot")]
public RobotModels RobotType { get; set; }

		/// <summary>
		/// Robot serie
		/// </summary>
		[PackageDescription("Robot serie")]
public RobotSubTypes RobotSubType { get; set; }

		/// <summary>
		/// Base joint configuration
		/// </summary>
		[PackageDescription("Base joint configuration")]
public JointConfiguration Base { get; set; }

		/// <summary>
		/// Shoulder joint configuration
		/// </summary>
		[PackageDescription("Shoulder joint configuration")]
public JointConfiguration Shoulder { get; set; }

		/// <summary>
		/// Elbow joint configuration
		/// </summary>
		[PackageDescription("Elbow joint configuration")]
public JointConfiguration Elbow { get; set; }

		/// <summary>
		/// Wrist1 joint configuration
		/// </summary>
		[PackageDescription("Wrist1 joint configuration")]
public JointConfiguration Wrist1 { get; set; }

		/// <summary>
		/// Wrist2 joint configuration
		/// </summary>
		[PackageDescription("Wrist2 joint configuration")]
public JointConfiguration Wrist2 { get; set; }

		/// <summary>
		/// Wrist3 (Tool) joint configuration
		/// </summary>
		[PackageDescription("Wrist3 (Tool) joint configuration")]
public JointConfiguration Wrist3 { get; set; }
	}
}
