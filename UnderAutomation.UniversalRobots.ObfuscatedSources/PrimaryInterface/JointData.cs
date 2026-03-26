//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Joint data
	/// </summary>
	public class JointData {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public JointData()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Angular joint position in radian
		/// </summary>
		[PackageDescription("Angular joint position in radian", PackageUnit.Radian)]
public double Position { get; set; }

		/// <summary>
		/// Angular target position in radian
		/// </summary>
		[PackageDescription("Angular target position in radian", PackageUnit.Radian)]
public double TargetPosition { get; set; }

		/// <summary>
		/// Joint rotation speed in rad/s
		/// </summary>
		[PackageDescription("Joint rotation speed in rad/s", PackageUnit.RadianPerSecond)]
public double ActualSpeed { get; set; }

		/// <summary>
		/// Motor current in Amps
		/// </summary>
		[PackageDescription("Motor current in Amps", PackageUnit.Amp)]
public float Current { get; set; }

		/// <summary>
		/// Motor voltage in Volts
		/// </summary>
		[PackageDescription("Motor voltage in Volts", PackageUnit.Volt)]
public float Voltage { get; set; }

		/// <summary>
		/// Joint temperature in °C
		/// </summary>
		[PackageDescription("Joint temperature in °C", PackageUnit.CelsiusDegree)]
public float Temperature { get; set; }

		/// <summary>
		/// Joint mode
		/// </summary>
		[PackageDescription("Joint mode")]
public JointModes JointMode { get; set; }
	}
}
