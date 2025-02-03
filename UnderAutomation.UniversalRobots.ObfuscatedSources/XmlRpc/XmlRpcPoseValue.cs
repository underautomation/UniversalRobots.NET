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
		/// Pose Value
		/// </summary>
		public Pose Value { get; }

		/// <summary>
		/// Creates a new pose Value
		/// </summary>
		public XmlRpcPoseValue(Pose pose)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns type : XmlRpcType.Pose
		/// </summary>
		public override XmlRpcType Type { get; }

		/// <summary>
		/// String representation of a pose value : p[0.1,0,0.2,0.01,0,0]
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
