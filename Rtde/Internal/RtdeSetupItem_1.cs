//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rtde;

namespace Rtde.Internal {

	public abstract class RtdeSetupItem<T> where T : Enum {


		public RtdeSetupItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public RtdeSetupItem(T data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public RtdeSetupItem(T data, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public int Index { get; set; }


		public T Data { get; set; }


		public abstract RtdeDataDescription<T> Description { get; }


		public string Name { get; }


		public RtdeTypes Type { get; }


		public string ProtocolType { get; }


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
