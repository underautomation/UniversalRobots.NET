//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rtde {

	public class RtdeInputValues : RtdeBaseValues<RtdeInputData> {


		public RtdeInputValues()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected override RtdeValue[] InternalValues { get; }


		protected override RtdeValue InternaleGetValue(RtdeInputData data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public void SetValue(RtdeInputSetupItem item, object value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void SetValue(RtdeInputData data, object value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void SetValue(RtdeInputData data, int index, object value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public object GetValue(RtdeInputSetupItem item)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public void Reset()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 0 = don't change speed slider with this input, 1 = use speed_slider_fraction to set speed slider value
		/// </summary>
		public uint SpeedSliderMask { get; set; }

		/// <summary>
		/// new speed slider value
		/// </summary>
		public double SpeedSliderFraction { get; set; }

		/// <summary>
		/// Standard digital output bit mask
		/// </summary>
		public byte StandardDigitalOutputMask { get; set; }

		/// <summary>
		/// Configurable digital output bit mask
		/// </summary>
		public byte ConfigurableDigitalOutputMask { get; set; }

		/// <summary>
		/// Standard digital outputs
		/// </summary>
		public byte StandardDigitalOutput { get; set; }

		/// <summary>
		/// Configurable digital outputs
		/// </summary>
		public byte ConfigurableDigitalOutput { get; set; }

		/// <summary>
		/// Standard analog output mask
		/// </summary>
		public byte StandardAnalogOutputMask { get; set; }

		/// <summary>
		/// Output domain {0=current[mA], 1=voltage[V]}. Bits 0-1: standard_analog_output_0 | standard_analog_output_1
		/// </summary>
		public byte StandardAnalogOutputType { get; set; }

		/// <summary>
		/// Standard analog output 0 (ratio) [0..1]
		/// </summary>
		public double StandardAnalogOutput0 { get; set; }

		/// <summary>
		/// Standard analog output 1 (ratio) [0..1]
		/// </summary>
		public double StandardAnalogOutput1 { get; set; }

		/// <summary>
		/// General purpose bits. This range of the boolean input registers is reserved for FieldBus/PLC interface usage.
		/// </summary>
		public uint InputBtRegisters0To31 { get; set; }

		/// <summary>
		/// General purpose bits. This range of the boolean input registers is reserved for FieldBus/PLC interface usage.
		/// </summary>
		public uint InputBtRegisters32To63 { get; set; }

		/// <summary>
		/// 64 general purpose bits. X: [64..127] - The upper range of the boolean input registers can be used by external RTDE clients (i.e URCAPS).
		/// </summary>
		public RtdeBitRegistersValue InputBitRegisters { get; }

		/// <summary>
		/// 48 general purpose integer registers. X: [0..23] - The lower range of the integer input registers is reserved for FieldBus/PLC interface usage. X: [24..47] - The upper range of the integer input registers can be used by external RTDE clients (i.e URCAPS).
		/// </summary>
		public RtdeIntRegistersValue InputIntRegisters { get; }

		/// <summary>
		/// 48 general purpose double registers. X: [0..23] - The lower range of the double input registers is reserved for FieldBus/PLC interface usage. X: [24..47] - The upper range of the double input registers can be used by external RTDE clients (i.e URCAPS).
		/// </summary>
		public RtdeDoubleRegistersValue InputDoubleRegisters { get; }

		/// <summary>
		/// Input external wrench when using ft_rtde_input_enable builtin.
		/// </summary>
		public CartesianCoordinates ExternalForceTorque { get; set; }
	}
}
