//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rtde.Internal;

namespace Rtde {

	public abstract class RtdeBaseValues<T> : RtdeBaseValues where T : Enum {


		protected abstract RtdeValue InternaleGetValue(T data);


		public object GetValue(T data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public object GetValue(T data, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected void SetValue2(RtdeSetupItem<T> item, object value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected object GetValue(RtdeSetupItem<T> item)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected void ResetInternal()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
