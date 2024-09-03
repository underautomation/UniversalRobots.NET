//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Xml.Linq;
using Common;

namespace XmlRpc {
	/// <summary>
	/// Base class of all elements transmitted by XML-RPC. La propriété Type donne le type dans lequel cette objet peut être casté pour obtenir la valeur
	/// </summary>
	public abstract class XmlRpcValue {

		/// <summary>
		/// Determines the class of this message
		/// </summary>
		public abstract XmlRpcType Type { get; }

		/// <summary>
		/// The XML description of the message that has been received from the robot or will be sent to the robot
		/// </summary>
		public XElement Xml { get; }


		public static implicit operator XmlRpcValue(double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator XmlRpcValue(bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator XmlRpcValue(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator XmlRpcValue(string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator XmlRpcValue(Pose value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator XmlRpcValue(XmlRpcValue[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator XmlRpcValue(double[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator XmlRpcValue(int[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator XmlRpcValue(string[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator XmlRpcValue(Pose[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator XmlRpcValue(bool[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator double(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator bool(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator int(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator string(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator Pose(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator int[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator double[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator Pose[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator string[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static implicit operator bool[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
