//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {

	public enum RtdeInputData {

		/// <summary>
		/// 0 = don't change speed slider with this input, 1 = use speed_slider_fraction to set speed slider value
		/// </summary>
		SpeedSliderMask = 0,

		/// <summary>
		/// new speed slider value
		/// </summary>
		SpeedSliderFraction = 1,

		/// <summary>
		/// Standard digital output bit mask
		/// </summary>
		StandardDigitalOutputMask = 2,

		/// <summary>
		/// Configurable digital output bit mask
		/// </summary>
		ConfigurableDigitalOutputMask = 3,

		/// <summary>
		/// Standard digital outputs
		/// </summary>
		StandardDigitalOutput = 4,

		/// <summary>
		/// Configurable digital outputs
		/// </summary>
		ConfigurableDigitalOutput = 5,

		/// <summary>
		/// Standard analog output mask
		/// </summary>
		StandardAnalogOutputMask = 6,

		/// <summary>
		/// Output domain {0=current[mA], 1=voltage[V]}. Bits 0-1: standard_analog_output_0 | standard_analog_output_1
		/// </summary>
		StandardAnalogOutputType = 7,

		/// <summary>
		/// Standard analog output 0 (ratio) [0..1]
		/// </summary>
		StandardAnalogOutput0 = 8,

		/// <summary>
		/// Standard analog output 1 (ratio) [0..1]
		/// </summary>
		StandardAnalogOutput1 = 9,

		/// <summary>
		/// General purpose bits. This range of the boolean input registers is reserved for FieldBus/PLC interface usage.
		/// </summary>
		InputBtRegisters0To31 = 10,

		/// <summary>
		/// General purpose bits. This range of the boolean input registers is reserved for FieldBus/PLC interface usage.
		/// </summary>
		InputBtRegisters32To63 = 11,

		/// <summary>
		/// 64 general purpose bits. X: [64..127] - The upper range of the boolean input registers can be used by external RTDE clients (i.e URCAPS).
		/// </summary>
		InputBitRegisters = 12,

		/// <summary>
		/// 48 general purpose integer registers. X: [0..23] - The lower range of the integer input registers is reserved for FieldBus/PLC interface usage. X: [24..47] - The upper range of the integer input registers can be used by external RTDE clients (i.e URCAPS).
		/// </summary>
		InputIntRegisters = 13,

		/// <summary>
		/// 48 general purpose double registers. X: [0..23] - The lower range of the double input registers is reserved for FieldBus/PLC interface usage. X: [24..47] - The upper range of the double input registers can be used by external RTDE clients (i.e URCAPS).
		/// </summary>
		InputDoubleRegisters = 14,

		/// <summary>
		/// Input external wrench when using ft_rtde_input_enable builtin.
		/// </summary>
		ExternalForceTorque = 15,
	}
}
