//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Represents a cartesian pose with 3 translations and 3 rotations
	/// </summary>
	public class CartesianCoordinates {

		/// <summary>
		/// Underlying array of 6 double values storing X, Y, Z, Rx, Ry, Rz in that order.
		/// </summary>
		public readonly double[] Values;

		/// <summary>
		/// Create a new pose with null coordinates
		/// </summary>
		public CartesianCoordinates()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new pose with translation informations and null rotations
		/// </summary>
		public CartesianCoordinates(double x, double y, double z)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new pose with translations and rotations information
		/// </summary>
		public CartesianCoordinates(double x, double y, double z, double rx, double ry, double rz)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current cartesian coordinates.
		/// </summary>
		/// <param name="obj">The object to compare with.</param>
		/// <returns><code>true</code> if coordinates are equal; otherwise, <code>false</code>.</returns>
		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a hash code for this cartesian coordinates instance.
		/// </summary>
		/// <returns>A hash code based on all six coordinate values.</returns>
		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// String representation of cartesian value
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// X coordinate in meters or m/s
		/// </summary>
		public double X { get; set; }

		/// <summary>
		/// Y coordinate in meters or m/s
		/// </summary>
		public double Y { get; set; }

		/// <summary>
		/// Z coordinate in meters or m/s
		/// </summary>
		public double Z { get; set; }

		/// <summary>
		/// RX rotation in radians or radians/s
		/// </summary>
		public double Rx { get; set; }

		/// <summary>
		/// RY rotation in radians or radians/s
		/// </summary>
		public double Ry { get; set; }

		/// <summary>
		/// RZ rotation in radians or radians/s
		/// </summary>
		public double Rz { get; set; }
	}
}
