//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace PrimaryInterface {
	/// <summary>
	/// Joint kinematics info, Denavit–Hartenberg (DH) parameters
	/// </summary>
	public class JointKinematicsInfo {

		/// <summary>
		/// Joint checksum
		/// </summary>
		[PackageDescription("Joint checksum")]
public int Checksum { get; set; }

		/// <summary>
		/// DH convention theta parameter
		/// </summary>
		[PackageDescription("DH convention theta parameter", PackageUnit.Radian)]
public double DHtheta { get; set; }

		/// <summary>
		/// DH convention a parameter
		/// </summary>
		[PackageDescription("DH convention a parameter", PackageUnit.Meter)]
public double DHa { get; set; }

		/// <summary>
		/// DH convention d parameter
		/// </summary>
		[PackageDescription("DH convention d parameter", PackageUnit.Meter)]
public double DHd { get; set; }

		/// <summary>
		/// DH convention alpha parameter
		/// </summary>
		[PackageDescription("DH convention alpha parameter", PackageUnit.Radian)]
public double Dhalpha { get; set; }
	}
}
