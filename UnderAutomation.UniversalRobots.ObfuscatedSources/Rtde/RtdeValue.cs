//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {
	/// <summary>
	/// Abstract base class for a single RTDE variable value exchanged between the client and the robot.
	/// </summary>
	public abstract class RtdeValue {

		/// <summary>
		/// Gets or sets the current value as an untyped object.
		/// </summary>
		public virtual object Value { get; protected set; }
	}
}
