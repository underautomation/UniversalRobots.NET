//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.Generic;
using System.Collections;

namespace Rtde.Internal {

	public abstract class RtdeSetup<T, U> : List<T>, IList<T>, ICollection<T>, IEnumerable<T>, IList, ICollection, IEnumerable where T : RtdeSetupItem<U>, new() where U : Enum {


		public T Add(U data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public T Add(U data, int index = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public int Remove(U data, int index = -1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public bool Contains(U data, int index = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public bool Contains(U data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public T[] ToDistinctList()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
