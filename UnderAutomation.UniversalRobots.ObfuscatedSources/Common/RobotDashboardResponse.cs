//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Common {
	/// <summary>
	/// Answer of a command of <see cref="UnderAutomation.UniversalRobots.Common.IRobotDashboard"/>. The same type is returned by the Dashboard Server client (PolyScope 5)
	/// and by the REST API client (PolyScope X), so that one code works with both.
	/// The other methods of the two clients keep their own answer types (<see cref="UnderAutomation.UniversalRobots.Dashboard.CommandResponse"/> and <see cref="UnderAutomation.UniversalRobots.Rest.RestApiResponse"/>).
	/// </summary>
	public class RobotDashboardResponse {


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
		/// Indicates that the robot accepted and executed the command.
		/// </summary>
		public bool Succeed { get; set; }

		/// <summary>
		/// Message of the robot, or description of the error.
		/// </summary>
		public string Message { get; set; }
	}
}
