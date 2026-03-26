//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {
	/// <summary>
	/// Interface for accessing individual register values within a register array by index.
	/// </summary>
	public interface IRtdeRegistersValue {

		/// <summary>
		/// Gets the value at the specified register index.
		/// </summary>
		/// <param name="index">The absolute register index.</param>
		/// <returns>The value stored at the given index.</returns>
		object GetValue(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the value at the specified register index.
		/// </summary>
		/// <param name="index">The absolute register index.</param>
		/// <param name="value">The value to store.</param>
		void SetValue(int index, object value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the lower-bound register index for this register range.
		/// </summary>
		int LowerRangeIndex { get; }
	}
}
