//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.UniversalRobots.Rtde.Internal;

namespace UnderAutomation.UniversalRobots.Rtde {
	/// <summary>
	/// Generic abstract base class for getting and setting RTDE variable values identified by enum <code class="typeparamref">T</code>.
	/// </summary>
	public abstract class RtdeBaseValues<T> : RtdeBaseValues where T : Enum {

		/// <summary>
		/// Gets the <see cref="UnderAutomation.UniversalRobots.Rtde.RtdeValue"/> wrapper for the specified variable.
		/// </summary>
		/// <param name="data">The RTDE variable identifier.</param>
		/// <returns>The corresponding <see cref="UnderAutomation.UniversalRobots.Rtde.RtdeValue"/>.</returns>
		protected abstract RtdeValue InternaleGetValue(T data);

		/// <summary>
		/// Gets the current value of the specified RTDE variable.
		/// </summary>
		/// <param name="data">The RTDE variable identifier.</param>
		/// <returns>The current value.</returns>
		public object GetValue(T data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the current value of the specified RTDE variable at a given register index.
		/// </summary>
		/// <param name="data">The RTDE variable identifier.</param>
		/// <param name="index">The absolute register index.</param>
		/// <returns>The current value at the given index.</returns>
		public object GetValue(T data, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the value of the RTDE variable described by a setup item.
		/// </summary>
		protected void SetValue2(RtdeSetupItem<T> item, object value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the value of the RTDE variable described by a setup item.
		/// </summary>
		protected object GetValue(RtdeSetupItem<T> item)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Resets all values to their default state.
		/// </summary>
		protected void ResetInternal()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
