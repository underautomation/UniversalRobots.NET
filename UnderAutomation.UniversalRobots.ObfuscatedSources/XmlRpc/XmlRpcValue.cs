//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using System.Xml.Linq;

namespace XmlRpc {
	/// <summary>
	/// Base class of all elements transmitted by XML-RPC. The <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue.Type" data-throw-if-not-resolved="false"></xref> property indicates the type into which this object can be cast to obtain the value.
	/// </summary>
	public abstract class XmlRpcValue {

		/// <summary>
		/// Implicitly converts a <xref href="System.Double" data-throw-if-not-resolved="false"></xref> to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcDoubleValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <xref href="System.Boolean" data-throw-if-not-resolved="false"></xref> to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcBooleanValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="System.Int32" data-throw-if-not-resolved="false"></xref> to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcIntegerValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <xref href="System.String" data-throw-if-not-resolved="false"></xref> to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcStringValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <xref href="UnderAutomation.UniversalRobots.Common.Pose" data-throw-if-not-resolved="false"></xref> to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcPoseValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(Pose value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an array of <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(XmlRpcValue[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <xref href="System.Double" data-throw-if-not-resolved="false"></xref> array to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(double[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="System.Int32" data-throw-if-not-resolved="false"></xref> array to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(int[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <xref href="System.String" data-throw-if-not-resolved="false"></xref> array to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(string[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <xref href="UnderAutomation.UniversalRobots.Common.Pose" data-throw-if-not-resolved="false"></xref> array to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(Pose[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts a <xref href="System.Boolean" data-throw-if-not-resolved="false"></xref> array to an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcArrayValue" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator XmlRpcValue(bool[] value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to a <xref href="System.Double" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator double(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to a <xref href="System.Boolean" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator bool(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to an <xref href="System.Int32" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator int(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to a <xref href="System.String" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator string(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to a <xref href="UnderAutomation.UniversalRobots.Common.Pose" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public static implicit operator Pose(XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to an <xref href="System.Int32" data-throw-if-not-resolved="false"></xref> array.
		/// </summary>
		public static implicit operator int[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to a <xref href="System.Double" data-throw-if-not-resolved="false"></xref> array.
		/// </summary>
		public static implicit operator double[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to a <xref href="UnderAutomation.UniversalRobots.Common.Pose" data-throw-if-not-resolved="false"></xref> array.
		/// </summary>
		public static implicit operator Pose[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to a <xref href="System.String" data-throw-if-not-resolved="false"></xref> array.
		/// </summary>
		public static implicit operator string[](XmlRpcValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Implicitly converts an <xref href="UnderAutomation.UniversalRobots.XmlRpc.XmlRpcValue" data-throw-if-not-resolved="false"></xref> to a <xref href="System.Boolean" data-throw-if-not-resolved="false"></xref> array.
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
