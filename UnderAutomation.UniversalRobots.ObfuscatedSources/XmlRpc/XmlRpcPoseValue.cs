//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace XmlRpc {
	/// <summary>
	/// Represents a pose value that can be exchange with the robot via XML-RPC
	/// </summary>
	public class XmlRpcPoseValue : XmlRpcStructValue {

		/// <summary>
		/// Creates a new pose Value
		/// </summary>
		public XmlRpcPoseValue(Pose pose)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// String representation of a pose value : p[0.1,0,0.2,0.01,0,0]
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Determines whether the specified object is equal to this instance.
		/// </summary>
		/// <param name="obj">The object to compare with.</param>
		/// <returns><code>true</code> if the specified object is an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcPoseValue" data-throw-if-not-resolved="false"></xref> with the same pose; otherwise, <code>false</code>.</returns>
		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Pose Value
		/// </summary>
		public Pose Value { get; }

		/// <summary>
		/// Returns type : XmlRpcType.Pose
		/// </summary>
		public override XmlRpcType Type => default;
	}
}
