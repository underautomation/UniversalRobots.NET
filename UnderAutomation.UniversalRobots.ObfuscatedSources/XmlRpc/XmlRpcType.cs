//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace XmlRpc {
	/// <summary>
	/// All supported types that can be transmitted by XML-RPC
	/// </summary>
	public enum XmlRpcType {

		/// <summary>
		/// Type is not supported
		/// </summary>
		Unknown = -1,

		/// <summary>
		/// The RPC type is a XmlRpcArrayValue
		/// </summary>
		Array = 0,

		/// <summary>
		/// The RPC type is a XmlRpcBooleanValue
		/// </summary>
		Boolean = 1,

		/// <summary>
		/// The RPC type is a XmlRpcDoubleValue
		/// </summary>
		Double = 2,

		/// <summary>
		/// The RPC type is a XmlRpcIntegerValue
		/// </summary>
		Integer = 3,

		/// <summary>
		/// The RPC type is a XmlRpcStringValue
		/// </summary>
		String = 4,

		/// <summary>
		/// The RPC type is a XmlRpcStructValue
		/// </summary>
		Struct = 5,

		/// <summary>
		/// The RPC type is a XmlRpcPoseValue
		/// </summary>
		Pose = 6,
	}
}
