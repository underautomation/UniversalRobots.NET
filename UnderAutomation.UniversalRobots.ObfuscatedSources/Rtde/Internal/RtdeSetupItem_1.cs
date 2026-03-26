//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rtde;

namespace Rtde.Internal {
	/// <summary>
	/// Abstract base class representing a single RTDE variable in a recipe, identified by an enum value of type <code class="typeparamref">T</code> and an optional register index.
	/// </summary>
	public abstract class RtdeSetupItem<T> where T : Enum {

		/// <summary>
		/// Initializes a new empty instance.
		/// </summary>
		public RtdeSetupItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance for the specified RTDE variable.
		/// </summary>
		/// <param name="data">The RTDE variable identifier.</param>
		public RtdeSetupItem(T data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance for the specified RTDE variable and register index.
		/// </summary>
		/// <param name="data">The RTDE variable identifier.</param>
		/// <param name="index">Register index for array/register variables.</param>
		public RtdeSetupItem(T data, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets or sets the register index for array/register RTDE variables. Defaults to 0.
		/// </summary>
		public int Index { get; set; }

		/// <summary>
		/// Gets or sets the enum value identifying the RTDE variable.
		/// </summary>
		public T Data { get; set; }

		/// <summary>
		/// Gets the description metadata for this variable (name, type, array info).
		/// </summary>
		public abstract RtdeDataDescription<T> Description { get; }

		/// <summary>
		/// Gets the RTDE protocol name for this variable, including the register index suffix for array variables.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Gets the RTDE wire type of this variable.
		/// </summary>
		public RtdeTypes Type { get; }

		/// <summary>
		/// Gets the uppercase RTDE protocol type string sent on the wire during setup.
		/// </summary>
		public string ProtocolType { get; }
	}
}
