//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Rest {
	/// <summary>
	/// Description of a program stored on a PolyScope X robot, returned by <see cref="UnderAutomation.UniversalRobots.Rest.Internal.RestClientBase.GetPrograms"/>.
	/// </summary>
	public class RestProgramInfo {


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


		public RestProgramInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Name of the program.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Description of the program. Empty if the robot gives none.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// State of the program as text. Empty if the robot gives none.
		/// </summary>
		public string ProgramState { get; set; }

		/// <summary>
		/// Creation date, in milliseconds since 1970-01-01 UTC. 0 if the robot gives none.
		/// </summary>
		public long CreatedDate { get; set; }

		/// <summary>
		/// Date of the last modification, in milliseconds since 1970-01-01 UTC. 0 if the robot gives none.
		/// </summary>
		public long LastModifiedDate { get; set; }

		/// <summary>
		/// Date of the last save, in milliseconds since 1970-01-01 UTC. 0 if the robot gives none.
		/// </summary>
		public long LastSavedDate { get; set; }
	}
}
