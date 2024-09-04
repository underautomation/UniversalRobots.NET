//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace XmlRpc {
	/// <summary>
	/// Represents a boolean value that can be exchange with the robot via XML-RPC
	/// </summary>
	public class XmlRpcBooleanValue : XmlRpcValue {


		public bool Value;


		public XmlRpcBooleanValue(bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Determines the class of this message
		/// </summary>
		public override XmlRpcType Type { get; }


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}