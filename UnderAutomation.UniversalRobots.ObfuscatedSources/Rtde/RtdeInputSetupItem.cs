//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rtde.Internal;

namespace Rtde {
	/// <summary>
	/// Represents a single RTDE input variable (client-to-robot) in an input recipe.
	/// </summary>
	public class RtdeInputSetupItem : RtdeSetupItem<RtdeInputData> {

		/// <summary>
		/// Initializes a new empty instance.
		/// </summary>
		public RtdeInputSetupItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance for the specified input variable.
		/// </summary>
		/// <param name="data">The RTDE input variable.</param>
		public RtdeInputSetupItem(RtdeInputData data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance for the specified input variable and register index.
		/// </summary>
		/// <param name="data">The RTDE input variable.</param>
		/// <param name="index">Zero-based register index for array/register variables.</param>
		public RtdeInputSetupItem(RtdeInputData data, int index)
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
		/// Gets the description metadata for this input variable.
		/// </summary>
		public override RtdeDataDescription<RtdeInputData> Description => default;
	}
}
