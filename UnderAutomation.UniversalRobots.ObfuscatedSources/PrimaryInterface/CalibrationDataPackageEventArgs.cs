//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Calibration data
	/// </summary>
	public class CalibrationDataPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// Fx calibration data
		/// </summary>
		[PackageDescription("Fx calibration data")]
public double Fx { get; set; }

		/// <summary>
		/// Fy calibration data
		/// </summary>
		[PackageDescription("Fy calibration data")]
public double Fy { get; set; }

		/// <summary>
		/// Fz calibration data
		/// </summary>
		[PackageDescription("Fz calibration data")]
public double Fz { get; set; }

		/// <summary>
		/// Frx calibration data
		/// </summary>
		[PackageDescription("Frx calibration data")]
public double Frx { get; set; }

		/// <summary>
		/// Fry calibration data
		/// </summary>
		[PackageDescription("Fry calibration data")]
public double Fry { get; set; }

		/// <summary>
		/// Frz calibration data
		/// </summary>
		[PackageDescription("Frz calibration data")]
public double Frz { get; set; }
	}
}
