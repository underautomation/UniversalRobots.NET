//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.ObjectModel;

namespace Rtde {

	public class RtdeInputsDescription {


		public RtdeInputDataDescription Get(RtdeInputData data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public ReadOnlyCollection<RtdeInputDataDescription> Items { get; }

		/// <summary>
		/// 0 = don't change speed slider with this input, 1 = use speed_slider_fraction to set speed slider value
		/// </summary>
		public RtdeInputDataDescription SpeedSliderMask { get; }

		/// <summary>
		/// new speed slider value
		/// </summary>
		public RtdeInputDataDescription SpeedSliderFraction { get; }

		/// <summary>
		/// Standard digital output bit mask
		/// </summary>
		public RtdeInputDataDescription StandardDigitalOutputMask { get; }

		/// <summary>
		/// Configurable digital output bit mask
		/// </summary>
		public RtdeInputDataDescription ConfigurableDigitalOutputMask { get; }

		/// <summary>
		/// Standard digital outputs
		/// </summary>
		public RtdeInputDataDescription StandardDigitalOutput { get; }

		/// <summary>
		/// Configurable digital outputs
		/// </summary>
		public RtdeInputDataDescription ConfigurableDigitalOutput { get; }

		/// <summary>
		/// Standard analog output mask
		/// </summary>
		public RtdeInputDataDescription StandardAnalogOutputMask { get; }

		/// <summary>
		/// Output domain {0=current[mA], 1=voltage[V]}. Bits 0-1: standard_analog_output_0 | standard_analog_output_1
		/// </summary>
		public RtdeInputDataDescription StandardAnalogOutputType { get; }

		/// <summary>
		/// Standard analog output 0 (ratio) [0..1]
		/// </summary>
		public RtdeInputDataDescription StandardAnalogOutput0 { get; }

		/// <summary>
		/// Standard analog output 1 (ratio) [0..1]
		/// </summary>
		public RtdeInputDataDescription StandardAnalogOutput1 { get; }

		/// <summary>
		/// General purpose bits. This range of the boolean input registers is reserved for FieldBus/PLC interface usage.
		/// </summary>
		public RtdeInputDataDescription InputBtRegisters0To31 { get; }

		/// <summary>
		/// General purpose bits. This range of the boolean input registers is reserved for FieldBus/PLC interface usage.
		/// </summary>
		public RtdeInputDataDescription InputBtRegisters32To63 { get; }

		/// <summary>
		/// 64 general purpose bits. X: [64..127] - The upper range of the boolean input registers can be used by external RTDE clients (i.e URCAPS).
		/// </summary>
		public RtdeInputDataDescription InputBitRegisters { get; }

		/// <summary>
		/// 48 general purpose integer registers. X: [0..23] - The lower range of the integer input registers is reserved for FieldBus/PLC interface usage. X: [24..47] - The upper range of the integer input registers can be used by external RTDE clients (i.e URCAPS).
		/// </summary>
		public RtdeInputDataDescription InputIntRegisters { get; }

		/// <summary>
		/// 48 general purpose double registers. X: [0..23] - The lower range of the double input registers is reserved for FieldBus/PLC interface usage. X: [24..47] - The upper range of the double input registers can be used by external RTDE clients (i.e URCAPS).
		/// </summary>
		public RtdeInputDataDescription InputDoubleRegisters { get; }

		/// <summary>
		/// Input external wrench when using ft_rtde_input_enable builtin.
		/// </summary>
		public RtdeInputDataDescription ExternalForceTorque { get; }
	}
}
