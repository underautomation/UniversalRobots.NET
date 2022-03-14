import typing
from underautomation.universal_robots.rtde.rtde_input_data_description import RtdeInputDataDescription
from underautomation.universal_robots.rtde.rtde_input_data import RtdeInputData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeInputsDescription as rtde_inputs_description

class RtdeInputsDescription:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_inputs_description()
		else:
			self._instance = _internal
	def get(self, data: RtdeInputData) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.Get(data._instance))
	@property
	def items(self) -> typing.Any:
		return self._instance.Items
	@property
	def speed_slider_mask(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.SpeedSliderMask)
	@property
	def speed_slider_fraction(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.SpeedSliderFraction)
	@property
	def standard_digital_output_mask(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.StandardDigitalOutputMask)
	@property
	def configurable_digital_output_mask(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.ConfigurableDigitalOutputMask)
	@property
	def standard_digital_output(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.StandardDigitalOutput)
	@property
	def configurable_digital_output(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.ConfigurableDigitalOutput)
	@property
	def standard_analog_output_mask(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.StandardAnalogOutputMask)
	@property
	def standard_analog_output_type(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.StandardAnalogOutputType)
	@property
	def standard_analog_output0(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.StandardAnalogOutput0)
	@property
	def standard_analog_output1(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.StandardAnalogOutput1)
	@property
	def input_bt_registers0_to31(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.InputBtRegisters0To31)
	@property
	def input_bt_registers32_to63(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.InputBtRegisters32To63)
	@property
	def input_bit_registers(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.InputBitRegisters)
	@property
	def input_int_registers(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.InputIntRegisters)
	@property
	def input_double_registers(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.InputDoubleRegisters)
	@property
	def external_force_torque(self) -> RtdeInputDataDescription:
		return RtdeInputDataDescription(self._instance.ExternalForceTorque)
