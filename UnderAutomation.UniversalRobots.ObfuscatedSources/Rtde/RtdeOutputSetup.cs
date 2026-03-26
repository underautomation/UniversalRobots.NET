//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rtde.Internal;
using System.Collections.Generic;
using System.Collections;

namespace Rtde {
	/// <summary>
	/// Defines the set of RTDE output variables (robot-to-client) to subscribe to as a recipe. The <xref href="UnderAutomation.UniversalRobots.Rtde.RtdeOutputData.Timestamp" data-throw-if-not-resolved="false"></xref> variable is added by default.
	/// </summary>
	public class RtdeOutputSetup : RtdeSetup<RtdeOutputSetupItem, RtdeOutputData>, IList<RtdeOutputSetupItem>, ICollection<RtdeOutputSetupItem>, IList, ICollection, IReadOnlyList<RtdeOutputSetupItem>, IReadOnlyCollection<RtdeOutputSetupItem>, IEnumerable<RtdeOutputSetupItem>, IEnumerable {

		/// <summary>
		/// Initializes a new instance with the default <xref href="UnderAutomation.UniversalRobots.Rtde.RtdeOutputData.Timestamp" data-throw-if-not-resolved="false"></xref> variable.
		/// </summary>
		public RtdeOutputSetup()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
