//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {
	/// <summary>
	/// Abstract base class holding a collection of <xref href="UnderAutomation.UniversalRobots.Rtde.RtdeValue" data-throw-if-not-resolved="false"></xref> instances representing RTDE variable values.
	/// </summary>
	public abstract class RtdeBaseValues {

		/// <summary>
		/// Gets the internal array of all RTDE values.
		/// </summary>
		protected abstract RtdeValue[] InternalValues { get; }

		/// <summary>
		/// Gets a copy of all RTDE values held by this instance.
		/// </summary>
		public RtdeValue[] Values { get; }
	}
}
