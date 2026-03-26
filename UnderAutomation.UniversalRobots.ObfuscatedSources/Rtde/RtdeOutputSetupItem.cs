//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rtde.Internal;

namespace Rtde {
	/// <summary>
	/// Represents a single RTDE output variable (robot-to-client) in an output recipe.
	/// </summary>
	public class RtdeOutputSetupItem : RtdeSetupItem<RtdeOutputData> {

		/// <summary>
		/// Initializes a new empty instance.
		/// </summary>
		public RtdeOutputSetupItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance for the specified output variable.
		/// </summary>
		/// <param name="data">The RTDE output variable.</param>
		public RtdeOutputSetupItem(RtdeOutputData data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance for the specified output variable and register index.
		/// </summary>
		/// <param name="data">The RTDE output variable.</param>
		/// <param name="index">Zero-based register index for array/register variables.</param>
		public RtdeOutputSetupItem(RtdeOutputData data, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
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

		/// <summary>
		/// Gets the description metadata for this output variable.
		/// </summary>
		public override RtdeDataDescription<RtdeOutputData> Description => default;
	}
}
