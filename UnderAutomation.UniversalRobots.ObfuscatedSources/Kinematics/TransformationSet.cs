//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Kinematics {
	/// <summary>
	/// Set of transformation matrices for each joint
	/// </summary>
	public class TransformationSet {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public TransformationSet()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 4x4 transformation matrix of the base joint 1
		/// </summary>
		public double[,] Base { get; set; }

		/// <summary>
		/// 4x4 transformation matrix of the shoulder joint 2
		/// </summary>
		public double[,] Shoulder { get; set; }

		/// <summary>
		/// 4x4 transformation matrix of the elbow joint 3
		/// </summary>
		public double[,] Elbow { get; set; }

		/// <summary>
		/// 4x4 transformation matrix of the wrist1 joint 4
		/// </summary>
		public double[,] Wrist1 { get; set; }

		/// <summary>
		/// 4x4 transformation matrix of the wrist2 joint 5
		/// </summary>
		public double[,] Wrist2 { get; set; }

		/// <summary>
		/// 4x4 transformation matrix of the wrist3 (Tool) joint 6
		/// </summary>
		public double[,] Wrist3 { get; set; }
	}
}
