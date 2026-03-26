//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.Generic;

namespace XmlRpc {
	/// <summary>
	/// Represents a structure that can be exchange with the robot via XML-RPC
	/// </summary>
	public class XmlRpcStructValue : XmlRpcValue {

		/// <summary>
		/// The list of key-value members in this structure.
		/// </summary>
		public readonly List<XmlRpcStructMember> Value;

		/// <summary>
		/// Initializes a new empty struct value.
		/// </summary>
		public XmlRpcStructValue()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new struct value with the specified members.
		/// </summary>
		/// <param name="value">The members to add to the structure.</param>
		public XmlRpcStructValue(IEnumerable<XmlRpcStructMember> value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of the struct with members separated by " | ".
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
		/// <returns><code>true</code> if the specified object is an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcStructValue" data-throw-if-not-resolved="false"></xref> with the same members; otherwise, <code>false</code>.</returns>
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
