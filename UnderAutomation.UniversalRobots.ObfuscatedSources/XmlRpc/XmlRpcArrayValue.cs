//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.Generic;

namespace XmlRpc {
	/// <summary>
	/// Represents an array of XmlRpcValue that can be exchange with the robot via XML-RPC
	/// </summary>
	public class XmlRpcArrayValue : XmlRpcValue {

		/// <summary>
		/// The list of XML-RPC values contained in this array.
		/// </summary>
		public readonly List<XmlRpcValue> Value;

		/// <summary>
		/// Initializes a new empty array value.
		/// </summary>
		public XmlRpcArrayValue()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new array value with the specified elements.
		/// </summary>
		/// <param name="value">The elements to add to the array.</param>
		public XmlRpcArrayValue(IEnumerable<XmlRpcValue> value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of the array with values separated by " | ".
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
		/// <returns><code>true</code> if the specified object is an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue" data-throw-if-not-resolved="false"></xref> with the same elements; otherwise, <code>false</code>.</returns>
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
