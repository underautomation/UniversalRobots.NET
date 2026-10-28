//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.UniversalRobots.Internal;
using System;
using UnderAutomation.UniversalRobots.Common;
using UnderAutomation.UniversalRobots.Dashboard;

namespace UnderAutomation.UniversalRobots.Rest.Internal {
	/// <summary>
	/// Base implementation of the REST API client for PolyscopeX robots
	/// </summary>
	public abstract class RestClientBase : URServiceBase, IRobotDashboard {

		/// <summary>
		/// Enable the REST client
		/// </summary>
		protected void EnableInternal(string ip, int port, RestApiVersion version, int timeoutMs)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disable the REST client
		/// </summary>
		public void Disable()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Change the robot's operational state.
		/// </summary>
		/// <param name="action">The state action to perform</param>
		/// <returns>API response indicating success or failure</returns>
		public RestApiResponse ChangeRobotState(RobotStateAction action)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Unlock the robot from protective stop state.
		/// </summary>
		public RestApiResponse UnlockProtectiveStop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Restart the safety system.
		/// </summary>
		public RestApiResponse RestartSafety()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Power off the robot.
		/// </summary>
		public RestApiResponse PowerOff()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Power on the robot.
		/// </summary>
		public RestApiResponse PowerOn()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Release the robot brakes.
		/// </summary>
		public RestApiResponse BrakeRelease()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Load a program by name.
		/// </summary>
		/// <param name="programName">Name of the program to load (without .urp extension)</param>
		/// <returns>API response indicating success or failure</returns>
		public RestApiResponse LoadProgram(string programName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Change the program state.
		/// </summary>
		/// <param name="action">The program action to perform</param>
		/// <returns>API response indicating success or failure</returns>
		public RestApiResponse ChangeProgramState(ProgramStateAction action)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Start playing the loaded program.
		/// </summary>
		public RestApiResponse Play()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Pause the running program.
		/// </summary>
		public RestApiResponse Pause()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Stop the running program.
		/// </summary>
		public RestApiResponse Stop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Resume a paused program.
		/// </summary>
		public RestApiResponse Resume()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the current program state.
		/// </summary>
		/// <returns>API response with the current program state</returns>
		public RestApiResponse<ProgramStateResponse> GetProgramState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the name of the loaded program.
		/// </summary>
		/// <returns>API response with the name of the loaded program in Value</returns>
		public RestApiResponse<string> GetLoadedProgram()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the mode of the robot.
		/// </summary>
		/// <returns>API response with the robot mode in Value. A mode that the SDK does not know gives <see cref="UnderAutomation.UniversalRobots.Common.RobotModes.Unknown"/>.</returns>
		public RestApiResponse<RobotModes> GetRobotMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the safety mode of the robot.
		/// </summary>
		/// <returns>API response with the safety mode in Value. A mode that the SDK does not know gives <see cref="UnderAutomation.UniversalRobots.Common.SafetyModes.Unknown"/>.</returns>
		public RestApiResponse<SafetyModes> GetSafetyMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the operational mode of the robot.
		/// </summary>
		/// <returns>API response with the operational mode in Value. Succeed is false if the mode is not known.</returns>
		public RestApiResponse<OperationalModes> GetOperationalMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Indicate whether the robot is in remote control.
		/// </summary>
		/// <returns>API response with true in Value if the robot is in remote control</returns>
		public RestApiResponse<bool> IsInRemoteControl()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the version of PolyScope X.
		/// </summary>
		/// <returns>API response with the version in Value. The Description is the version text of the robot.</returns>
		public RestApiResponse<PolyscopeVersion> GetPolyscopeVersion()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the version of the robot API of the robot.
		/// </summary>
		/// <returns>API response with the version in Value. Succeed is false if the robot gives no valid version.</returns>
		public RestApiResponse<Version> GetRobotApiVersion()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Show a popup on the screen of the robot, with an empty title.
		/// </summary>
		/// <param name="message">Text of the popup</param>
		/// <returns>API response indicating success or failure</returns>
		public RestApiResponse ShowPopup(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Show a popup on the screen of the robot.
		/// </summary>
		/// <param name="title">Title of the popup</param>
		/// <param name="message">Text of the popup</param>
		/// <returns>API response indicating success or failure</returns>
		public RestApiResponse ShowPopupWithTitle(string title, string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Close the popup of the screen of the robot.
		/// </summary>
		/// <returns>API response indicating success or failure</returns>
		public RestApiResponse ClosePopup()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Close a safety popup of the screen of the robot.
		/// </summary>
		/// <returns>API response indicating success or failure</returns>
		public RestApiResponse CloseSafetyPopup()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// List the programs stored on the robot.
		/// </summary>
		/// <returns>API response with the programs in Value</returns>
		public RestApiResponse<RestProgramInfo[]> GetPrograms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Upload a new program file to the robot. The robot refuses a program that already exists: use <see cref="UnderAutomation.UniversalRobots.Rest.Internal.RestClientBase.UpdateProgramFile(System.String)"/> to replace it.
		/// </summary>
		/// <param name="filePath">Path of the program file on this computer</param>
		/// <returns>API response with the name given by the robot to the program in Value</returns>
		public RestApiResponse<string> UploadProgramFile(string filePath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Upload a new program to the robot from its text content. The robot refuses a program that already exists: use <see cref="UnderAutomation.UniversalRobots.Rest.Internal.RestClientBase.UpdateProgramContent(System.String,System.String)"/> to replace it.
		/// </summary>
		/// <param name="fileName">File name of the program</param>
		/// <param name="content">Text content of the program file</param>
		/// <returns>API response with the name given by the robot to the program in Value</returns>
		public RestApiResponse<string> UploadProgramContent(string fileName, string content)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Replace a program of the robot with a program file.
		/// </summary>
		/// <param name="filePath">Path of the program file on this computer</param>
		/// <returns>API response with the name of the program in Value</returns>
		public RestApiResponse<string> UpdateProgramFile(string filePath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Replace a program of the robot from its text content.
		/// </summary>
		/// <param name="fileName">File name of the program</param>
		/// <param name="content">Text content of the program file</param>
		/// <returns>API response with the name of the program in Value</returns>
		public RestApiResponse<string> UpdateProgramContent(string fileName, string content)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Download a program from the robot.
		/// </summary>
		/// <param name="programName">Name of the program</param>
		/// <returns>API response with the text content of the program in Value</returns>
		public RestApiResponse<string> DownloadProgram(string programName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Download a program from the robot and save it in a file of this computer.
		/// </summary>
		/// <param name="programName">Name of the program</param>
		/// <param name="savePath">Path of the file to write. An existing file is replaced.</param>
		/// <returns>API response indicating success or failure</returns>
		public RestApiResponse DownloadProgramToFile(string programName, string savePath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected RestClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// IP address of the robot
		/// </summary>
		public string IP { get; }

		/// <summary>
		/// HTTP port for REST API
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// REST API version being used
		/// </summary>
		public RestApiVersion Version { get; }

		/// <summary>
		/// Request timeout in milliseconds
		/// </summary>
		public int TimeoutMs { get; }

		/// <summary>
		/// Indicates whether the REST client has been initialized
		/// </summary>
		public bool Initialized { get; }
	}
}
