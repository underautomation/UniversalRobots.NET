//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {
	/// <summary>
	/// Abstract base for a fixed-size register array of type <code class="typeparamref">T</code> exchanged through RTDE.
	/// </summary>
	public abstract class RtdeRegistersValue<T> : RtdeValue<T[]>, IRtdeRegistersValue {

		/// <summary>
		/// Initializes the register array with the specified size.
		/// </summary>
		/// <param name="size">Number of registers in this range.</param>
		protected RtdeRegistersValue(int size)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets the value at the specified absolute register index.
		/// </summary>
		/// <param name="index">The absolute register index.</param>
		/// <param name="value">The value to store.</param>
		public void SetValue(int index, T value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the value at the specified absolute register index.
		/// </summary>
		/// <param name="index">The absolute register index.</param>
		/// <returns>The value stored at the given index.</returns>
		public T GetValue(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the lower-bound register index for this register range.
		/// </summary>
		public abstract int LowerRangeIndex { get; }
	}
}
