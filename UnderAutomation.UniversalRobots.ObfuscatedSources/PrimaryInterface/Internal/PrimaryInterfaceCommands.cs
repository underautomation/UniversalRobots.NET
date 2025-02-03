//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using Dashboard;
using PrimaryInterface;

namespace PrimaryInterface.Internal {
	/// <summary>
	/// Handles Primary interface commands
	/// </summary>
	public class PrimaryInterfaceCommands {

		/// <summary>
		/// Power on the robot
		/// </summary>
		public StatusCode PowerOn()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Power off the robot
		/// </summary>
		public StatusCode PowerOff()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set robot operational mode
		/// </summary>
		public StatusCode SetOperationalMode(OperationalModes mode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Pause running program
		/// </summary>
		public StatusCode PauseProgram()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set robot to real robot (disable simulation)
		/// </summary>
		public StatusCode SetReal()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Simulate robot
		/// </summary>
		public StatusCode SetSimulated()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Stop running program
		/// </summary>
		public StatusCode StopProgram()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Resume paused program
		/// </summary>
		public StatusCode ResumeProgram()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Step program execution. Should be followed by ResumeProgram() to move to next instruction
		/// </summary>
		public StatusCode StepProgram()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Run program from start
		/// </summary>
		public StatusCode RunProgram()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Enable teach button
		/// </summary>
		public StatusCode EnableTeachButton()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Disable teach button
		/// </summary>
		public StatusCode DisableTeachButton()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Enable freedrive mode
		/// </summary>
		public StatusCode EnableFreedriveMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Disable freedrive mode
		/// </summary>
		public StatusCode DisableFreedriveMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Close popup
		/// </summary>
		public StatusCode ClosePopup(uint id)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reply popup
		/// </summary>
		public StatusCode ReplyPopup(uint id, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reply popup
		/// </summary>
		public StatusCode ReplyPopup(uint id, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reply popup
		/// </summary>
		public StatusCode ReplyPopup(uint id, double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reply popup
		/// </summary>
		public StatusCode ReplyPopup(uint id, string value, RequestedTypes type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reply popup
		/// </summary>
		public StatusCode ReplyPopup(uint id, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Release brakes
		/// </summary>
		public StatusCode ReleaseBrakes()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Unlock protective stop
		/// </summary>
		public StatusCode UnlockProtectiveStop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Increase speed limit
		/// </summary>
		public StatusCode IncreaseSpeedLimit()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set speed limit
		/// </summary>
		public StatusCode SetSpeedLimit(double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set speed
		/// </summary>
		public StatusCode SetSpeed(double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Clear all breakpoints
		/// </summary>
		public StatusCode ClearBreakpoints()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a new breakpoint
		/// </summary>
		public StatusCode AddBreakpoint(int line, string program)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Remove an existing breakpoint
		/// </summary>
		public StatusCode RemoveBreakpoint(int line, string program)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
