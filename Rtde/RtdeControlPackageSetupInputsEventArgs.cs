//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rtde {

	public class RtdeControlPackageSetupInputsEventArgs : PackageEventArgs {

		/// <summary>
		/// Recipe Identifier of input sent data
		/// </summary>
		public byte InputRecipeId { get; set; }

		/// <summary>
		/// Status of each registers. Contains the type or the status IN_USE / NOT_FOUND
		/// </summary>
		public string[] VariableTypes { get; set; }

		/// <summary>
		/// Indicates that the recipe is valid, i.e. that all the registers have been found and are not already reserved for writing by another RTDE client. 
		/// Check event SetupInputsReceived to see which registers are NOT_FOUND or IN_USE
		/// </summary>
		public bool InputRecipeIsValid { get; }
	}
}
