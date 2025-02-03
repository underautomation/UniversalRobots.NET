//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Tool data
	/// </summary>
	public class ToolDataPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// Unit of analog input 2 (analog_in[2])
		/// </summary>
		[PackageDescription("Unit of analog input 2 (analog_in[2])")]
public AnalogRanges AnalogInputRange2 { get; set; }

		/// <summary>
		/// Unit of analog input 3 (analog_in[3])
		/// </summary>
		[PackageDescription("Unit of analog input 3 (analog_in[3])")]
public AnalogRanges AnalogInputRange3 { get; set; }

		/// <summary>
		/// Value of Analog input 2 (analog_in[2])
		/// </summary>
		[PackageDescription("Value of Analog input 2 (analog_in[2])")]
public double AnalogInput2 { get; set; }

		/// <summary>
		/// Value of Analog input 3 (analog_in[3])
		/// </summary>
		[PackageDescription("Value of Analog input 3 (analog_in[3])")]
public double AnalogInput3 { get; set; }

		/// <summary>
		/// Actual robot voltage power supply
		/// </summary>
		[PackageDescription("Actual robot voltage power supply", PackageUnit.Volt)]
public float ToolVoltage48V { get; set; }

		/// <summary>
		/// Tool output voltage
		/// </summary>
		[PackageDescription("Tool output voltage", PackageUnit.Volt)]
public sbyte ToolOutputVoltage { get; set; }

		/// <summary>
		/// Tool current in Amps
		/// </summary>
		[PackageDescription("Tool current in Amps", PackageUnit.Amp)]
public float ToolCurrent { get; set; }

		/// <summary>
		/// Tool Temperature in °C
		/// </summary>
		[PackageDescription("Tool Temperature in °C", PackageUnit.CelciusDegree)]
public float ToolTemperature { get; set; }

		/// <summary>
		/// Tool mode
		/// </summary>
		[PackageDescription("Tool mode")]
public ToolModes ToolMode { get; set; }
	}
}
