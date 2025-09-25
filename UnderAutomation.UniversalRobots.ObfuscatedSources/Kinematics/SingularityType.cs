//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Kinematics {
	/// <summary>
	/// Types of singularities
	/// </summary>
	[Flags]
public enum SingularityType {

		/// <summary>
		/// No singularity
		/// </summary>
		None = 0,

		/// <summary>
		/// Wrist singularity
		/// </summary>
		Wrist = 1,

		/// <summary>
		/// Elbow singularity
		/// </summary>
		Elbow = 2,

		/// <summary>
		/// Shoulder singularity
		/// </summary>
		Shoulder = 4,
	}
}
