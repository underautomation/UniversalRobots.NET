//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Common {
	/// <summary>
	/// Answer of a command of <see cref="UnderAutomation.UniversalRobots.Common.IRobotDashboard"/> that returns a value.
	/// </summary>
	public class RobotDashboardResponse<T> : RobotDashboardResponse {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RobotDashboardResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value returned by the command. It is meaningful only if <see cref="UnderAutomation.UniversalRobots.Common.RobotDashboardResponse.Succeed"/> is true.
		/// </summary>
		public T Value { get; set; }
	}
}
