//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using Rest;

namespace Rest.Internal {
	/// <summary>
	/// Base implementation of the REST API client for PolyscopeX robots
	/// </summary>
	public abstract class RestClientBase : URServiceBase {

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
		/// PUT /robotstate/v1/state
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
		/// PUT /program/v1/load
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
		/// PUT /program/v1/state
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
		/// GET /program/v1/state
		/// </summary>
		/// <returns>API response with the current program state</returns>
		public RestApiResponse<ProgramStateResponse> GetProgramState()
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
