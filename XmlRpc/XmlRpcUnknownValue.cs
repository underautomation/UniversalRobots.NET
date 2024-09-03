//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace XmlRpc {
	/// <summary>
	/// Represents an unknown XML-RPC argument that has been received from the robot
	/// You can decode it yourself with the XML property
	/// </summary>
	public class XmlRpcUnknownValue : XmlRpcValue {


		public readonly string AdditionalInformation;

		/// <summary>
		/// Determines the class of this message
		/// </summary>
		public override XmlRpcType Type { get; }
	}
}
