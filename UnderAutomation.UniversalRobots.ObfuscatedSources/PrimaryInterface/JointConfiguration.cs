//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace PrimaryInterface {
	/// <summary>
	/// Joint configuration
	/// </summary>
	public class JointConfiguration {

		/// <summary>
		/// Minimum angular position in rad
		/// </summary>
		[PackageDescription("Minimum angular position in rad", PackageUnit.Radian)]
public double JointMinLimit { get; set; }

		/// <summary>
		/// Maximum angular position in rad
		/// </summary>
		[PackageDescription("Maximum angular position in rad", PackageUnit.Radian)]
public double JointMaxLimit { get; set; }

		/// <summary>
		/// Maximum rotation speed in rad/s
		/// </summary>
		[PackageDescription("Maximum rotation speed in rad/s", PackageUnit.RadianPerSecond)]
public double JointMaxSpeed { get; set; }

		/// <summary>
		/// Maximum rotation speed in rad/s²
		/// </summary>
		[PackageDescription("Maximum rotation speed in rad/s²", PackageUnit.RadianPerSecondSquared)]
public double JointMaxAcceleration { get; set; }

		/// <summary>
		/// a parameter of Denavit–Hartenberg (DH) convention
		/// </summary>
		[PackageDescription("a parameter of Denavit–Hartenberg (DH) convention", PackageUnit.Meter)]
public double DHa { get; set; }

		/// <summary>
		/// d parameter of Denavit–Hartenberg (DH) convention
		/// </summary>
		[PackageDescription("d parameter of Denavit–Hartenberg (DH) convention", PackageUnit.Meter)]
public double DHd { get; set; }

		/// <summary>
		/// Alpha parameter of Denavit–Hartenberg (DH) convention
		/// </summary>
		[PackageDescription("Alpha parameter of Denavit–Hartenberg (DH) convention", PackageUnit.Radian)]
public double DHalpha { get; set; }

		/// <summary>
		/// Theta parameter of Denavit–Hartenberg (DH) convention
		/// </summary>
		[PackageDescription("Theta parameter of Denavit–Hartenberg (DH) convention", PackageUnit.Radian)]
public double DHtheta { get; set; }
	}
}
