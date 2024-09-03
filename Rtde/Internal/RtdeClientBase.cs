//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using Rtde;
using System;
using Common;

namespace Rtde.Internal {
	/// <summary>
	/// Base class common to all RTDE clients
	/// </summary>
	public abstract class RtdeClientBase : URServiceBase {

		/// <summary>
		/// Last text received from the robot
		/// </summary>
		public RtdeTextMessageEventArgs LastTextMessage { get; }

		/// <summary>
		/// Event raised during connection when the robot specifies if asked protocol version is supported
		/// </summary>
		public event EventHandler<RtdeProtocolVersionEventArgs> ProtocolVersionReceived;

		/// <summary>
		/// Event raised when a RTDE message is received
		/// </summary>
		public event EventHandler<RtdeTextMessageEventArgs> TextMessageReceived;

		/// <summary>
		/// Event raised when data from the robot is comming at specified frequency
		/// </summary>
		public event EventHandler<RtdeDataPackageEventArgs> OutputDataReceived;

		/// <summary>
		/// Event raised during connection when the robot acknowledges output setup
		/// </summary>
		public event EventHandler<RtdeControlPackageSetupOutputsEventArgs> SetupOutputsReceived;

		/// <summary>
		/// Event raised during connection when the robot acknowledges input setup
		/// </summary>
		public event EventHandler<RtdeControlPackageSetupInputsEventArgs> SetupInputsReceived;

		/// <summary>
		/// Event raised as soon as data streaming starts
		/// </summary>
		public event EventHandler<RtdeBasicRequestEventArgs> StartReceived;

		/// <summary>
		/// Event raised when streaming is paused
		/// </summary>
		public event EventHandler<RtdeBasicRequestEventArgs> PauseReceived;

		/// <summary>
		/// Current RTDE state
		/// </summary>
		public RTDEStates State { get; }

		/// <summary>
		/// Generic event raised each time a RTDE package is received
		/// </summary>
		public event EventHandler<PackageEventArgs> PackageReceived;

		/// <summary>
		/// Gets a value indicating if RTDE client is connected to the robot
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// IP address of the robot
		/// </summary>
		public string IP { get; }

		/// <summary>
		/// Output data frequency requested to the robot, only for RTDE version 2
		/// </summary>
		public double AppliedFrequency { get; }

		/// <summary>
		/// Current protocol version used to stream data
		/// </summary>
		public RtdeVersions Version { get; }

		/// <summary>
		/// List of all data sent from the robot to the PC (robot point of view)
		/// </summary>
		public RtdeOutputSetupItem[] OutputSetup { get; }

		/// <summary>
		/// List of all data the PC can write to the robot (robot point of view)
		/// </summary>
		public RtdeInputSetupItem[] InputSetup { get; }

		/// <summary>
		/// Recipe Identifier of output received data
		/// </summary>
		public byte OutputRecipeId { get; }

		/// <summary>
		/// Recipe Identifier of input sent data
		/// </summary>
		public byte InputRecipeId { get; }

		/// <summary>
		/// Indicates that the recipe is valid, i.e. that all the registers have been found and are not already reserved for writing by another RTDE client. 
		/// Check event SetupInputsReceived to see which registers are NOT_FOUND or IN_USE
		/// </summary>
		public bool InputRecipeIsValid { get; }

		/// <summary>
		/// Measured output data packet frequency. "Timestamp" output data shoud be part of output setup to measure frequency.
		/// </summary>
		public double MeasuredFrequency { get; }

		/// <summary>
		/// Last data received from the robot
		/// </summary>
		public RtdeOutputValues OutputDataValues { get; }


		protected void ConnectInternal(string ip, int port, RtdeOutputSetup outputSetup, RtdeInputSetup inputSetup, RtdeVersions preferedVersion, double frequency)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Pause data streaming without disconnecting client
		/// </summary>
		public void Pause()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Restart data streaming after a Pause
		/// </summary>
		public void Resume()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write data to controller. Data must be those selected in connect parameters
		/// </summary>
		public void WriteInputs(RtdeInputValues inputValues)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Close the RTDE connection to the robot
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
