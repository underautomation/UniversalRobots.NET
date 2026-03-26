//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Represents a three-dimensional vector with X, Y, and Z components.
	/// </summary>
	public class Vector3D {

		/// <summary>
		/// Underlying array of 3 double values storing X, Y, Z in that order.
		/// </summary>
		public readonly double[] Values;

		/// <summary>
		/// Returns a string representation of the vector.
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current vector.
		/// </summary>
		/// <param name="obj">The object to compare with.</param>
		/// <returns><code>true</code> if the vectors are equal; otherwise, <code>false</code>.</returns>
		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a hash code for this vector instance.
		/// </summary>
		/// <returns>A hash code based on the three vector components.</returns>
		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public Vector3D()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// X component of the vector.
		/// </summary>
		public double X { get; set; }

		/// <summary>
		/// Y component of the vector.
		/// </summary>
		public double Y { get; set; }

		/// <summary>
		/// Z component of the vector.
		/// </summary>
		public double Z { get; set; }
	}
}
