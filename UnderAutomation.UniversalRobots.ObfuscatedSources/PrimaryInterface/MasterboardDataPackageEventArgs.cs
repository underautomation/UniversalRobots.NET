//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Masterboard data
	/// </summary>
	public class MasterboardDataPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// Unit of analog input 0 (analog_in[0])
		/// </summary>
		[PackageDescription("Unit of analog input 0 (analog_in[0])")]
public AnalogRanges AnalogInputRange0 { get; set; }

		/// <summary>
		/// Unit of analog input 1 (analog_in[1])
		/// </summary>
		[PackageDescription("Unit of analog input 1 (analog_in[1])")]
public AnalogRanges AnalogInputRange1 { get; set; }

		/// <summary>
		/// Value of analog input 0 (analog_in[0])
		/// </summary>
		[PackageDescription("Value of analog input 0 (analog_in[0])")]
public double AnalogInput0 { get; set; }

		/// <summary>
		/// Value of analog input 1 (analog_in[1])
		/// </summary>
		[PackageDescription("Value of analog input 1 (analog_in[1])")]
public double AnalogInput1 { get; set; }

		/// <summary>
		/// Unit of analog output 0 (analog_out[0])
		/// </summary>
		[PackageDescription("Unit of analog output 0 (analog_out[0])")]
public AnalogRanges AnalogOutputDomain0 { get; set; }

		/// <summary>
		/// Unit of analog output 1 (analog_out[1)
		/// </summary>
		[PackageDescription("Unit of analog output 1 (analog_out[1)")]
public AnalogRanges AnalogOutputDomain1 { get; set; }

		/// <summary>
		/// Value of analog output 0 (analog_out[0])
		/// </summary>
		[PackageDescription("Value of analog output 0 (analog_out[0])")]
public double AnalogOutput0 { get; set; }

		/// <summary>
		/// Value of analog output 1 (analog_out[1])
		/// </summary>
		[PackageDescription("Value of analog output 1 (analog_out[1])")]
public double AnalogOutput1 { get; set; }

		/// <summary>
		/// Temperature of masterboard in °C
		/// </summary>
		[PackageDescription("Temperature of masterboard in °C", PackageUnit.CelciusDegree)]
public float MasterboardTemperature { get; set; }

		/// <summary>
		/// Voltage of internal 48V power supply
		/// </summary>
		[PackageDescription("Voltage of internal 48V power supply", PackageUnit.Volt)]
public float RobotVoltage48V { get; set; }

		/// <summary>
		/// Robot current consumption in Amps
		/// </summary>
		[PackageDescription("Robot current consumption in Amps", PackageUnit.Amp)]
public float RobotCurrent { get; set; }

		/// <summary>
		/// Current of all digital and analog inputs and outputs
		/// </summary>
		[PackageDescription("Current of all digital and analog inputs and outputs", PackageUnit.Amp)]
public float MasterIOCurrent { get; set; }

		/// <summary>
		/// Masterboard safety mode
		/// </summary>
		[PackageDescription("Masterboard safety mode")]
public SafetyStatus Safetymode { get; set; }

		/// <summary>
		/// Robot is in reduced speed mode
		/// </summary>
		[PackageDescription("Robot is in reduced speed mode")]
public byte InReducedMode { get; set; }

		/// <summary>
		/// Position of operational mode selector input switch
		/// </summary>
		[PackageDescription("Position of operational mode selector input switch")]
public byte OperationalModeSelectorInput { get; set; }

		/// <summary>
		/// Position of the 3-position enabling device
		/// </summary>
		[PackageDescription("Position of the 3-position enabling device")]
public byte ThreePositionEnablingDeviceInput { get; set; }

		/// <summary>
		/// Register where each bit is a digital input value
		/// </summary>
		[PackageDescription("Register where each bit is a digital input value")]
public MasterboardDigitalIO DigitalInputs { get; set; }

		/// <summary>
		/// Register where each bit is a digital output value
		/// </summary>
		[PackageDescription("Register where each bit is a digital output value")]
public MasterboardDigitalIO DigitalOutputs { get; set; }

		/// <summary>
		/// The robot is interfaced to injection molding machines Euromap 67
		/// </summary>
		[PackageDescription("The robot is interfaced to injection molding machines Euromap 67")]
public sbyte Euromap67Installed { get; set; }

		/// <summary>
		/// Register where each bit is a digital Euromap input
		/// </summary>
		[PackageDescription("Register where each bit is a digital Euromap input")]
public int EuromapInputBits { get; set; }

		/// <summary>
		/// Register where each bit is a digital Euromap output
		/// </summary>
		[PackageDescription("Register where each bit is a digital Euromap output")]
public int EuromapOutputBits { get; set; }

		/// <summary>
		/// Euromap votage
		/// </summary>
		[PackageDescription("Euromap votage", PackageUnit.Volt)]
public float EuromapVoltage { get; set; }

		/// <summary>
		/// Euromap current
		/// </summary>
		[PackageDescription("Euromap current", PackageUnit.Amp)]
public float EuromapCurrent { get; set; }
	}
}
