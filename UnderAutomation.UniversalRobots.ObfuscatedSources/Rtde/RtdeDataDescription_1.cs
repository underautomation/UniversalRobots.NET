//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {
	/// <summary>
	/// Abstract base class that describes a single RTDE variable, including its name, data type, and array layout.
	/// </summary>
	public abstract class RtdeDataDescription<T> where T : Enum {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the enum value identifying the RTDE variable.
		/// </summary>
		public T Data { get; }

		/// <summary>
		/// Gets the RTDE wire type of this variable.
		/// </summary>
		public RtdeTypes Type { get; }

		/// <summary>
		/// Gets the protocol name of this variable as defined in the UR RTDE specification.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Gets a human-readable description of this variable.
		/// </summary>
		public string Description { get; }

		/// <summary>
		/// Gets the lower bound index when this variable represents an element of a register array; otherwise 0.
		/// </summary>
		public int LowerIndex { get; }

		/// <summary>
		/// Gets the size of the register array this variable belongs to; otherwise 0.
		/// </summary>
		public int ArraySize { get; }

		/// <summary>
		/// Gets a value indicating whether this variable is an element of a register array.
		/// </summary>
		public bool IsArray { get; }
	}
}
