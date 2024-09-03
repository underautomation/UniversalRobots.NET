//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Status code that describes an internal error or an internal action
	/// </summary>
	public enum StatusCode {

		/// <summary>
		/// The action succeeded
		/// </summary>
		OK = 0,

		/// <summary>
		/// The read thread has stopped due to an internal exception. No more data event will be raised.
		/// </summary>
		ReadThreadAborted = 1,

		/// <summary>
		/// The data received are inconsistent and it not possible to decode it.
		/// </summary>
		DecodageError = 2,

		/// <summary>
		/// Unable to send URScript because of an internal error.
		/// </summary>
		SendCommandInternalError = 3,

		/// <summary>
		/// Unable to send URScript because the script sent is empty.
		/// </summary>
		SentCommandIsEmpty = 4,

		/// <summary>
		/// Streaming interface is not connected
		/// </summary>
		StreamingInterfaceNotConnected = 5,

		/// <summary>
		/// An error occured in the XML-RPC server
		/// </summary>
		XmlRpcInternalError = 6,

		/// <summary>
		/// An error occured while decoding global variables
		/// </summary>
		GlobalVariablesError = 7,

		/// <summary>
		/// An error occured while handling socket packet
		/// </summary>
		SocketInternalError = 8,

		/// <summary>
		/// The RTDE read thread has stopped due to an internal exception. No more data event will be raised.
		/// </summary>
		RTDEThreadAborted = 9,

		/// <summary>
		/// Error occured while writing RTDE input data
		/// </summary>
		WriteInputsRtdeError = 10,
	}
}
