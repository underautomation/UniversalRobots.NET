//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.UniversalRobots.Common;
using System.Xml.Linq;

namespace UnderAutomation.UniversalRobots.XmlRpc {
	/// <summary>
	/// Base class of all elements transmitted by XML-RPC. The <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue.Type"/> property indicates the type into which this object can be cast to obtain the value.
	/// </summary>
	public abstract class XmlRpcValue {

		/// <summary>
		/// Implicitly converts a <see cref="System.Double"/> to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcDoubleValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <see cref="System.Boolean"/> to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcBooleanValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="System.Int32"/> to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcIntegerValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <see cref="System.String"/> to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcStringValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <see cref="UnderAutomation.UniversalRobots.Common.Pose"/> to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcPoseValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(Pose value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an array of <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(XmlRpcValue[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <see cref="System.Double"/> array to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(double[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="System.Int32"/> array to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(int[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <see cref="System.String"/> array to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(string[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <see cref="UnderAutomation.UniversalRobots.Common.Pose"/> array to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(Pose[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <see cref="System.Boolean"/> array to an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue"/>.
		/// </summary>
		public static implicit operator XmlRpcValue(bool[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to a <see cref="System.Double"/>.
		/// </summary>
		public static implicit operator double(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to a <see cref="System.Boolean"/>.
		/// </summary>
		public static implicit operator bool(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to an <see cref="System.Int32"/>.
		/// </summary>
		public static implicit operator int(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to a <see cref="System.String"/>.
		/// </summary>
		public static implicit operator string(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to a <see cref="UnderAutomation.UniversalRobots.Common.Pose"/>.
		/// </summary>
		public static implicit operator Pose(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to an <see cref="System.Int32"/> array.
		/// </summary>
		public static implicit operator int[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to a <see cref="System.Double"/> array.
		/// </summary>
		public static implicit operator double[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to a <see cref="UnderAutomation.UniversalRobots.Common.Pose"/> array.
		/// </summary>
		public static implicit operator Pose[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to a <see cref="System.String"/> array.
		/// </summary>
		public static implicit operator string[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <see cref="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue"/> to a <see cref="System.Boolean"/> array.
		/// </summary>
		public static implicit operator bool[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the XML string representation of this value.
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected XmlRpcValue()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Determines the class of this message
		/// </summary>
		public abstract XmlRpcType Type { get; }

		/// <summary>
		/// The XML description of the message that has been received from the robot or will be sent to the robot
		/// </summary>
		public XElement Xml { get; }
	}
}
