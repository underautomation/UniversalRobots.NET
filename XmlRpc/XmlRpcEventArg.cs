//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Xml.Linq;
using System.Net;

namespace XmlRpc {
	/// <summary>
	/// Represents a request that has just been received from the robot
	/// </summary>
	public class XmlRpcEventArg : EventArgs {

		/// <summary>
		/// The XML document received via HTTP
		/// </summary>
		public readonly XDocument XmlRequest;

		/// <summary>
		/// The method called by the robot
		/// </summary>
		public readonly string MethodName;

		/// <summary>
		/// The arguments of the method called
		/// </summary>
		public readonly XmlRpcValue[] Arguments;

		/// <summary>
		/// IP address of the robot
		/// </summary>
		public readonly IPEndPoint EndPoint;

		/// <summary>
		/// Response to be provided to the robot by the user
		/// </summary>
		public XmlRpcValue Answer;
	}
}
