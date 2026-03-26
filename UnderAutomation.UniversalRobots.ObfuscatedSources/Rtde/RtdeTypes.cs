//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {
	/// <summary>
	/// RTDE data types used to describe the wire format of each RTDE variable.
	/// </summary>
	public enum RtdeTypes {

		/// <summary>
		/// Boolean value (1 byte on the wire).
		/// </summary>
		Bool = 0,

		/// <summary>
		/// Unsigned 8-bit integer.
		/// </summary>
		Uint8 = 1,

		/// <summary>
		/// Unsigned 32-bit integer.
		/// </summary>
		Uint32 = 2,

		/// <summary>
		/// Signed 32-bit integer.
		/// </summary>
		Int32 = 3,

		/// <summary>
		/// Unsigned 64-bit integer.
		/// </summary>
		Uint64 = 4,

		/// <summary>
		/// 64-bit floating-point number.
		/// </summary>
		Double = 5,

		/// <summary>
		/// 3-element double vector (X, Y, Z).
		/// </summary>
		Vector3D = 6,

		/// <summary>
		/// 6-element double vector representing a TCP pose (X, Y, Z, Rx, Ry, Rz).
		/// </summary>
		Pose = 7,

		/// <summary>
		/// 6-element double vector representing Cartesian coordinates.
		/// </summary>
		CartesianCoordinates = 8,

		/// <summary>
		/// 6-element double vector with one value per robot joint.
		/// </summary>
		JointsDoubleValues = 9,

		/// <summary>
		/// 6-element 32-bit integer vector with one value per robot joint.
		/// </summary>
		JointsIntValues = 10,

		/// <summary>
		/// Boolean value stored as part of a register array.
		/// </summary>
		BoolArray = 11,

		/// <summary>
		/// 32-bit integer value stored as part of a register array.
		/// </summary>
		Int32Array = 12,

		/// <summary>
		/// 64-bit double value stored as part of a register array.
		/// </summary>
		DoubleArray = 13,
	}
}
