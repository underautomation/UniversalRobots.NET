//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Kinematics {
	/// <summary>
	/// Result of a forward kinematics calculation
	/// </summary>
	public class KinematicsResult {


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


		public KinematicsResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 4x4 transformation matrix of the tool
		/// </summary>
		public double[,] ToolTransform { get; set; }

		/// <summary>
		/// Individual local transformation matrices of each joint
		/// </summary>
		public TransformationSet IndividualLocalTransforms { get; set; }

		/// <summary>
		/// Cumulative global transformation matrices of each joint
		/// </summary>
		public TransformationSet CumulativeGlobalTransforms { get; set; }
	}
}
