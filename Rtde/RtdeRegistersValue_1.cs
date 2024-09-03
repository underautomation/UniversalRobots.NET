//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {

	public abstract class RtdeRegistersValue<T> : RtdeValue<T[]>, IRtdeRegistersValue {


		protected RtdeRegistersValue(int size)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public abstract int LowerRangeIndex { get; }


		public void SetValue(int index, T value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public T GetValue(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
