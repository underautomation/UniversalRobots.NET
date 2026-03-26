//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace XmlRpc.Internal {
	/// <summary>
	/// Base class for XML-RPC connection parameters.
	/// </summary>
	public abstract class XmlRpcParametersBase {


		protected XmlRpcParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Choose local port to start XML-RPC server 
		/// Default value is 50000
		/// </summary>
		public int Port { get; set; }
	}
}
