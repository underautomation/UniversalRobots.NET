//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Vector 6 of double values representing each robot joint
	/// </summary>
	public class JointsValues<T> {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Array of the 6 joint data
		/// </summary>
		public readonly T[] Values;

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
