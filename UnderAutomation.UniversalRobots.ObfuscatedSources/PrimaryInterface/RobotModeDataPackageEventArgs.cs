//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Information about current robot mode
	/// </summary>
	public class RobotModeDataPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// Timespan since the robot controller has started
		/// </summary>
		[PackageDescription("Timespan since the robot controller has started")]
public TimeSpan Timestamp { get; set; }

		/// <summary>
		/// Robot is connected to its controller
		/// </summary>
		[PackageDescription("Robot is connected to its controller")]
public bool PhysicalRobotConnected { get; set; }

		/// <summary>
		/// Real robot mode active. False if robot is in simulation
		/// </summary>
		[PackageDescription("Real robot mode active. False if robot is in simulation")]
public bool RealRobotEnabled { get; set; }

		/// <summary>
		/// Robot is powered on and boot is completed. If false, you need to press "ON" button to power it on
		/// </summary>
		[PackageDescription("Robot is powered on and boot is completed. If false, you need to press \"ON\" button to power it on")]
public bool RobotPowerOn { get; set; }

		/// <summary>
		/// The button Emergency Stop is pressed
		/// </summary>
		[PackageDescription("The button Emergency Stop is pressed")]
public bool EmergencyStopped { get; set; }

		/// <summary>
		/// A stop occured due to a fault detection
		/// </summary>
		[PackageDescription("A stop occured due to a fault detection")]
public bool ProtectiveStopped { get; set; }

		/// <summary>
		/// A program is running
		/// </summary>
		[PackageDescription("A program is running")]
public bool ProgramRunning { get; set; }

		/// <summary>
		/// The running program is paused
		/// </summary>
		[PackageDescription("The running program is paused")]
public bool ProgramPaused { get; set; }

		/// <summary>
		/// Current robot running mode
		/// </summary>
		[PackageDescription("Current robot running mode")]
public RobotModes RobotMode { get; set; }

		/// <summary>
		/// Current robot control mode
		/// </summary>
		[PackageDescription("Current robot control mode")]
public ControlModes ControlMode { get; set; }

		/// <summary>
		/// Overriden speed ratio between 0 (0%) and 1 (100%)
		/// </summary>
		[PackageDescription("Overriden speed ratio between 0 (0%) and 1 (100%)")]
public double TargetSpeedFraction { get; set; }

		/// <summary>
		/// Speed scaling
		/// </summary>
		[PackageDescription("Speed scaling")]
public double SpeedScaling { get; set; }

		/// <summary>
		/// Maximum target speed fraction
		/// </summary>
		[PackageDescription("Maximum target speed fraction")]
public double TargetSpeedFractionLimit { get; set; }
	}
}
