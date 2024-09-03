//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Force mode data
	/// </summary>
	public class ForceModeDataPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// X force in tool frame in N
		/// </summary>
		public double X { get; set; }

		/// <summary>
		/// Y force in tool frame in N
		/// </summary>
		public double Y { get; set; }

		/// <summary>
		/// Z force in tool frame in N
		/// </summary>
		public double Z { get; set; }

		/// <summary>
		/// Rx torque in tool frame in Nm
		/// </summary>
		public double Rx { get; set; }

		/// <summary>
		/// Ry torque in tool frame in Nm
		/// </summary>
		public double Ry { get; set; }

		/// <summary>
		/// Rz torque in tool frame in Nm
		/// </summary>
		public double Rz { get; set; }

		/// <summary>
		/// Dexterity of the robot
		/// </summary>
		public double RobotDexterity { get; set; }
	}
}
