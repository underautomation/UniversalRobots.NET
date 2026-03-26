//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Vector 6 of double values representing each robot joint
	/// </summary>
	public class JointsValues<T> {

		/// <summary>
		/// Array of the 6 joint data
		/// </summary>
		public readonly T[] Values;


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current joint values.
		/// </summary>
		/// <param name="obj">The object to compare with.</param>
		/// <returns><code>true</code> if all joint values are equal; otherwise, <code>false</code>.</returns>
		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a hash code for this joint values instance.
		/// </summary>
		/// <returns>A hash code based on all six joint values.</returns>
		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public JointsValues()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Joint 1 out of 6
		/// </summary>
		public T Base { get; set; }

		/// <summary>
		/// Joint 2 out of 6
		/// </summary>
		public T Shoulder { get; set; }

		/// <summary>
		/// Joint 3 out of 6
		/// </summary>
		public T Elbow { get; set; }

		/// <summary>
		/// Joint 4 out of 6
		/// </summary>
		public T Wrist1 { get; set; }

		/// <summary>
		/// Joint 5 out of 6
		/// </summary>
		public T Wrist2 { get; set; }

		/// <summary>
		/// Joint 6 out of 6
		/// </summary>
		public T Wrist3 { get; set; }
	}
}
