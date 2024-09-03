//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Represents a UR pose
	/// </summary>
	public class Pose : CartesianCoordinates {


		public Pose()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public Pose(double x, double y, double z)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public Pose(double x, double y, double z, double rx, double ry, double rz)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// RX rotation in degrees or °/s
		/// </summary>
		public double RxDegrees { get; set; }

		/// <summary>
		/// RY rotation in degrees or °/s
		/// </summary>
		public double RyDegrees { get; set; }

		/// <summary>
		/// RZ rotation in degrees or °/s
		/// </summary>
		public double RzDegrees { get; set; }

		/// <summary>
		/// Consider this pose as a Rotation Vector And convert it to a new RPY position
		/// </summary>
		public Pose FromRotationVectorToRPY()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Consider this pose as RPY And convert it to a new Rotation Vector
		/// </summary>
		public Pose FromRPYToRotationVector()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns 6 comma separated coordinated with G1 format
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Pase a pose from its string representation
		/// </summary>
		/// <param name="value">String representation of the pose like : p[0.1,0,0.2,0.01,0,0]</param>
		/// <param name="pose">The output parsed pose</param>
		public static bool TryParse(string value, out Pose pose)
		{
			pose = default;
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a rotation vector to quaternion
		/// </summary>
		public void FromRotationVectorToQuaternion(out double x, out double y, out double z, out double w)
		{
			x = default;
			y = default;
			z = default;
			w = default;
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Consider this pose as a rotation vector and return a 4x4 transformation matrix
		/// </summary>
		public double[,] FromRPYTo4x4Matrix()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Consider this pose as a RPY position and return a 4x4 transformation matrix
		/// </summary>
		public double[,] FromRotationVectorTo4x4Matrix()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a quaternion to UR rotation vector
		/// </summary>
		public static Pose FromQuaternionToRotationVector(double x, double y, double z, double w)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
