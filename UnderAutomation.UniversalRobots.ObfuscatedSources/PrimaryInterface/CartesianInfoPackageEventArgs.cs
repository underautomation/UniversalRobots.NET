//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Contains current cartesian position of the robot, including its TCP offset
	/// </summary>
	public class CartesianInfoPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// X axis coordinate in meter of the TCP in the current frame
		/// </summary>
		[PackageDescription("X axis coordinate in meter of the TCP in the current frame", PackageUnit.Meter)]
public double X { get; set; }

		/// <summary>
		/// Y axis coordinate in meter of the TCP in the current frame
		/// </summary>
		[PackageDescription("Y axis coordinate in meter of the TCP in the current frame", PackageUnit.Meter)]
public double Y { get; set; }

		/// <summary>
		/// Z axis coordinate in meter of the TCP in the current frame
		/// </summary>
		[PackageDescription("Z axis coordinate in meter of the TCP in the current frame", PackageUnit.Meter)]
public double Z { get; set; }

		/// <summary>
		/// RX axis coordinate in rad of the TCP in the current frame
		/// </summary>
		[PackageDescription("RX axis coordinate in rad of the TCP in the current frame", PackageUnit.Radian)]
public double Rx { get; set; }

		/// <summary>
		/// RY axis coordinate in rad of the TCP in the current frame
		/// </summary>
		[PackageDescription("RY axis coordinate in rad of the TCP in the current frame", PackageUnit.Radian)]
public double Ry { get; set; }

		/// <summary>
		/// RZ axis coordinate in rad of the TCP in the current frame
		/// </summary>
		[PackageDescription("RZ axis coordinate in rad of the TCP in the current frame", PackageUnit.Radian)]
public double Rz { get; set; }

		/// <summary>
		/// X position of the TCP in the flange frame in meter
		/// </summary>
		[PackageDescription("X position of the TCP in the flange frame in meter", PackageUnit.Meter)]
public double TCPOffsetX { get; set; }

		/// <summary>
		/// Y position of the TCP in the flange frame in meter
		/// </summary>
		[PackageDescription("Y position of the TCP in the flange frame in meter", PackageUnit.Meter)]
public double TCPOffsetY { get; set; }

		/// <summary>
		/// Z position of the TCP in the flange frame in meter
		/// </summary>
		[PackageDescription("Z position of the TCP in the flange frame in meter", PackageUnit.Meter)]
public double TCPOffsetZ { get; set; }

		/// <summary>
		/// RX position of the TCP in the flange frame in rad
		/// </summary>
		[PackageDescription("RX position of the TCP in the flange frame in rad", PackageUnit.Radian)]
public double TCPOffsetRX { get; set; }

		/// <summary>
		/// RY position of the TCP in the flange frame in rad
		/// </summary>
		[PackageDescription("RY position of the TCP in the flange frame in rad", PackageUnit.Radian)]
public double TCPOffsetRY { get; set; }

		/// <summary>
		/// RZ position of the TCP in the flange frame in rad
		/// </summary>
		[PackageDescription("RZ position of the TCP in the flange frame in rad", PackageUnit.Radian)]
public double TCPOffsetRZ { get; set; }
	}
}
