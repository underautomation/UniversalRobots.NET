//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using Dashboard;
using Common;
using System;

namespace Dashboard.Internal {

	public abstract class DashboardClientBase : URServiceBase {

		/// <summary>
		/// IP of the robot to connect to for sending commands
		/// </summary>
		public string IP { get; }

		/// <summary>
		/// Dashboard server port
		/// </summary>
		public int Port { get; set; }


		protected void EnableInternal(string ip, int port)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disable dashboard client
		/// </summary>
		public void Disable()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Indicates that the dashboard client has been initialized and is ready to send commands
		/// </summary>
		public bool Initialized { get; }

		/// <summary>
		/// Start loading the specified program. (From FW 1.4)
		/// Returns when both program and associated installation has loaded (or failed).
		/// The load command fails if the associated installation requires confirmation of safety.The return value in this case will be 'Error while loading program'.
		/// </summary>
		/// <param name="programName">The name of the program to load with its extension .urp</param>
		public CommandResponse LoadProgram(string programName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Starts program, if any program is loaded and robot is ready. (From FW 1.4)
		/// Returns failure if the program fails to start.
		/// </summary>
		public CommandResponse Play()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Stops running program. (From FW 1.4)
		/// Returns failure if the program fails to stop
		/// </summary>
		public CommandResponse Stop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Pauses the running program . (From FW 1.4)
		/// Returns failure if the program fails to pause
		/// </summary>
		public CommandResponse Pause()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Send a custom command to the Dashboard Server port
		/// </summary>
		public CommandResponse SendCustomDashboardCommand(string command)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get variable value and estimate its type
		/// </summary>
		public CommandResponse<GlobalVariable> GetVariable(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Event raised when function <xref href="UnderAutomation.UniversalRobots.Dashboard.Internal.DashboardClientBase.Shutdown" data-throw-if-not-resolved="false"></xref> is called.
		/// </summary>
		public EventHandler BeforeShutdown;

		/// <summary>
		/// Shuts down and turns off robot and controller. Closes the connection. (From FW 1.4)
		/// </summary>
		public CommandResponse Shutdown()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a True value is a program is running. (From FW 1.6)
		/// </summary>
		public CommandResponse<bool> IsProgramRunning()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the current robot state. (From FW 1.6)
		/// </summary>
		public CommandResponse<RobotModes> GetRobotMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the path of the loaded program. If not program is loaded, Value member is null. (From FW 1.6)
		/// </summary>
		public CommandResponse<string> GetLoadedProgram()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Shows a popup on Polyscope with the specified message. The popup-text will be translated to the selected language, if the text exists in the language file. (From FW 1.6)
		/// </summary>
		/// <param name="message">Message to show</param>
		public CommandResponse ShowPopup(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Closes the popup (From FW 1.6)
		/// </summary>
		public CommandResponse ClosePopup()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds log-message to the Log history. (From FW 1.8.11657)
		/// </summary>
		/// <param name="message">Message to add in logs</param>
		public CommandResponse AddToLog(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the save state of the active program and path to loaded program file. (From FW 1.8.11997)
		/// </summary>
		public CommandResponse<ProgramSaveState> IsProgramSaved()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the state of the active program and path to loaded program file, or STOPPED if no program is loaded
		/// </summary>
		public CommandResponse<ProgramState> GetProgramState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the version of the Polyscope software (From FW 1.8.14035)
		/// </summary>
		public CommandResponse<PolyscopeVersion> GetPolyscopeVersion()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Controls the available options on the Welcome screen (From FW 1.8.14035 to 3.12.0)
		/// </summary>
		/// <param name="role">Role to set</param>
		public CommandResponse SetUserRole(UserRoles role)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Controls the operational mode. See User manual for details. If this function is called the operational mode cannot be changed from PolyScope, and the user password is disabled. OperationalModes.None is not a valid operational mode. (From FW 5.0.0)
		/// </summary>
		/// <param name="mode">The new operational mode. OperationalModes.None is not a valid operational mode.</param>
		public CommandResponse SetOperationalMode(OperationalModes mode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// The operational mode can again be changed from PolyScope, and the user password is enabled. (From FW 5.0.0)
		/// </summary>
		public CommandResponse ClearOperationalMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the operational mode. (From FW 5.6)
		/// </summary>
		public CommandResponse<OperationalModes> GetOperationalMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the remote control status of the robot. If the robot Is In remote control it returns False And If remote control Is disabled Or robot Is in local control it returns false. (From FW 5.6)
		/// </summary>
		public CommandResponse<bool> IsInRemoteControl()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Powers on the robot arm. (From FW 3.0)
		/// </summary>
		public CommandResponse PowerOn()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Powers off the robot arm. (From FW 3.0)
		/// </summary>
		public CommandResponse PowerOff()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Releases the brakes. (From FW 3.0)
		/// </summary>
		public CommandResponse ReleaseBrake()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Closes the current popup and unlocks protective stop. (From FW 3.1)
		/// </summary>
		public CommandResponse UnlockProtectiveStop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Closes a safety popup. (From FW 3.1)
		/// </summary>
		public CommandResponse CloseSafetyPopup()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Loads the specified installation file (From FW 3.2.18654)
		/// </summary>
		/// <param name="installation">The installation to load with its extension .installation.</param>
		public CommandResponse LoadInstallation(string installation)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Restarts the safety. Used when robot gets a safety fault or violation to restart the safety. After safety has been rebooted the robot will be in Power Off. (From FW 3.7 to 3.12.0 and from 5.1.0)
		/// </summary>
		public CommandResponse RestartSafety()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the current safety status. (From FW 3.11 to 3.12 and from FW 5.5)
		/// </summary>
		public CommandResponse<SafetyStatus> GetSafetyStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns serial number of the robot (FW 3.12 and from FW 5.6)
		/// </summary>
		public CommandResponse GetSerialNumber()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the robot model (UR3, UR5, UR10 or UR16). (FW 3.12 and from FW 5.6)
		/// </summary>
		public CommandResponse<RobotModels> GetRobotModel()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
