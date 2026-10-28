//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using UnderAutomation.UniversalRobots.Dashboard;

namespace UnderAutomation.UniversalRobots.Common {
	/// <summary>
	/// Commands that exist on both the Dashboard Server client (PolyScope 5, CB3 and e-Series) and the REST API client (PolyScope X).
	/// Write your code against this interface to control a robot of any of the two families.
	/// Both clients implement it explicitly: to call the members, use a variable of type <see cref="UnderAutomation.UniversalRobots.Common.IRobotDashboard"/>.
	/// The methods of the clients with the same names keep their own answer types.
	/// Every method blocks until the robot answers. A failure is reported in the answer, not by an exception.
	/// </summary>
	public interface IRobotDashboard {

		/// <summary>
		/// Powers on the robot arm.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse PowerOn()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Powers off the robot arm.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse PowerOff()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Releases the brakes of the robot.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse ReleaseBrake()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Unlocks a protective stop.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse UnlockProtectiveStop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Restarts the safety system. After the restart the robot is in power off mode.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse RestartSafety()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Loads a program of the robot.
		/// </summary>
		/// <param name="programName">Name of the program. The extension is optional.</param>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse LoadProgram(string programName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the loaded program.
		/// </summary>
		/// <returns>The name or the path of the loaded program in Value.</returns>
		RobotDashboardResponse<string> GetLoadedProgram()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Starts the loaded program.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse Play()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Pauses the running program.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse Pause()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Resumes the paused program.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse Resume()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Stops the running program.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse Stop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the state of the program.
		/// </summary>
		/// <returns>The state of the program in Value. The name of the program is filled only when the robot gives it.</returns>
		RobotDashboardResponse<ProgramState> GetProgramState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the mode of the robot.
		/// </summary>
		/// <returns>The robot mode in Value.</returns>
		RobotDashboardResponse<RobotModes> GetRobotMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the safety mode of the robot.
		/// </summary>
		/// <returns>The safety mode in Value.</returns>
		RobotDashboardResponse<SafetyModes> GetSafetyMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the operational mode of the robot.
		/// </summary>
		/// <returns>The operational mode in Value.</returns>
		RobotDashboardResponse<OperationalModes> GetOperationalMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Indicates whether the robot is in remote control.
		/// </summary>
		/// <returns>True in Value if the robot is in remote control.</returns>
		RobotDashboardResponse<bool> IsInRemoteControl()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Shows a popup on the screen of the robot.
		/// </summary>
		/// <param name="message">Text of the popup.</param>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse ShowPopup(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Closes the popup of the screen of the robot.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse ClosePopup()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Closes a safety popup of the screen of the robot.
		/// </summary>
		/// <returns>The answer of the robot.</returns>
		RobotDashboardResponse CloseSafetyPopup()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the version of PolyScope.
		/// </summary>
		/// <returns>The version in Value.</returns>
		RobotDashboardResponse<PolyscopeVersion> GetPolyscopeVersion()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
