//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using System;

namespace PrimaryInterface {
	/// <summary>
	/// List of all global variables
	/// </summary>
	public class GlobalVariables {

		/// <summary>
		/// Indicates which decoder is used used to read variables according to firmware version
		/// </summary>
		public GlobalVariablesFirmwareVersion FirmwareVersion { get; }

		/// <summary>
		/// Returns a list of all variables declared in the robot
		/// </summary>
		public GlobalVariable[] GetAll()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get a variable by its name. Null is returned if the variable doesn't exist
		/// </summary>
		/// <param name="name">Variable name, not case sensitive</param>
		public GlobalVariable GetByName(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Event raised at 10Hz when variable values are updated
		/// </summary>
		public event EventHandler<GlobalVariablesEventArgs> ValuesUpdated;

		/// <summary>
		/// Event raised whan the variable list changed. For example, after a program starts
		/// </summary>
		public event EventHandler<GlobalVariablesEventArgs> ListUpdated;

		/// <summary>
		/// Return a string where each line contains type, name and variable value
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
