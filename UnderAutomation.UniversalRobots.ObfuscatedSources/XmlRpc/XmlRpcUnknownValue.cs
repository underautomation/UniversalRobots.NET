//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace XmlRpc {
	/// <summary>
	/// Represents an unknown XML-RPC argument that has been received from the robot
	/// You can decode it yourself with the XML property
	/// </summary>
	public class XmlRpcUnknownValue : XmlRpcValue {

		/// <summary>
		/// Additional information about why this value could not be decoded.
		/// </summary>
		public readonly string AdditionalInformation;

		/// <summary>
		/// Returns the additional information about this unknown value.
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
		/// <returns><code>true</code> if the specified object is an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcUnknownValue" data-throw-if-not-resolved="false"></xref> with the same additional information; otherwise, <code>false</code>.</returns>
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
		/// Gets the XML-RPC type of this value.
		/// </summary>
		public override XmlRpcType Type => default;
	}
}
