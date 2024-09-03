//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Digital output configuration (NPN, PNP, Push/Pull)
	/// </summary>
	public enum DigitalOutputConfigurations {

		/// <summary>
		/// Sinking (NOPN)
		/// </summary>
		SinkingNPN = 1,

		/// <summary>
		/// Sourcing (PNP)
		/// </summary>
		SourcingPNP = 2,

		/// <summary>
		/// Push / Pull
		/// </summary>
		PushPull = 3,
	}
}
