//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {

	public abstract class RtdeDataDescription<T> where T : Enum {


		public T Data { get; }


		public RtdeTypes Type { get; }


		public string Name { get; }


		public string Description { get; }


		public int LowerIndex { get; }


		public int ArraySize { get; }


		public bool IsArray { get; }
	}
}
