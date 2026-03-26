//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.Generic;
using System.Collections;

namespace Rtde.Internal {
	/// <summary>
	/// Base class for an RTDE recipe, a collection of <code class="typeparamref">T</code> setup items that describe which RTDE variables to exchange.
	/// </summary>
	public abstract class RtdeSetup<T, U> : List<T>, IList<T>, ICollection<T>, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable where T : RtdeSetupItem<U>, new() where U : Enum {

		/// <summary>
		/// Adds a variable to the recipe with register index 0.
		/// </summary>
		/// <param name="data">The RTDE variable to add.</param>
		/// <returns>The created setup item.</returns>
		public T Add(U data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a variable to the recipe with the specified register index.
		/// </summary>
		/// <param name="data">The RTDE variable to add.</param>
		/// <param name="index">Register index for array/register variables.</param>
		/// <returns>The created setup item.</returns>
		public T Add(U data, int index = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Removes all items matching the specified variable and optionally a specific register index.
		/// </summary>
		/// <param name="data">The RTDE variable to remove.</param>
		/// <param name="index">If non-negative, only items with this index are removed; if negative, all matching items are removed.</param>
		/// <returns>The number of items removed.</returns>
		public int Remove(U data, int index = -1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Determines whether the recipe contains the specified variable at the given register index.
		/// </summary>
		/// <param name="data">The RTDE variable to look for.</param>
		/// <param name="index">Register index to match.</param>
		/// <returns><code>true</code> if found; otherwise <code>false</code>.</returns>
		public bool Contains(U data, int index = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Determines whether the recipe contains the specified variable at any register index.
		/// </summary>
		/// <param name="data">The RTDE variable to look for.</param>
		/// <returns><code>true</code> if found; otherwise <code>false</code>.</returns>
		public bool Contains(U data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a deduplicated array of setup items, removing duplicates by <xref href="UnderAutomation.UniversalRobots.Rtde.Internal.RtdeSetupItem%601.Data" data-throw-if-not-resolved="false"></xref> and <xref href="UnderAutomation.UniversalRobots.Rtde.Internal.RtdeSetupItem%601.Index" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		/// <returns>An array of distinct setup items.</returns>
		public T[] ToDistinctList()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected RtdeSetup()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
