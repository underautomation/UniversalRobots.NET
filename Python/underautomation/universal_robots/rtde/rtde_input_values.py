import typing
from underautomation.universal_robots.rtde.rtde_input_setup_item import RtdeInputSetupItem
from underautomation.universal_robots.rtde.rtde_input_data import RtdeInputData
from underautomation.universal_robots.rtde.rtde_bit_registers_value import RtdeBitRegistersValue
from underautomation.universal_robots.rtde.rtde_int_registers_value import RtdeIntRegistersValue
from underautomation.universal_robots.rtde.rtde_double_registers_value import RtdeDoubleRegistersValue
from underautomation.universal_robots.common.cartesian_coordinates import CartesianCoordinates
from underautomation.universal_robots.rtde.rtde_base_values_1 import RtdeBaseValues1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeInputValues as rtde_input_values

class RtdeInputValues(RtdeBaseValues1[RtdeInputData]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_input_values()
		else:
			self._instance = _internal
	def set_value(self, data: RtdeInputData, index: int, value: typing.Any) -> None:
		self._instance.SetValue(data._instance, index, value)
	def get_value(self, item: RtdeInputSetupItem) -> typing.Any:
		return self._instance.GetValue(item._instance)
	def reset(self) -> None:
		self._instance.Reset()
	@property
	def speed_slider_mask(self) -> int:
		return self._instance.SpeedSliderMask
	@speed_slider_mask.setter
	def speed_slider_mask(self, value: int):
		self._instance.SpeedSliderMask = value
	@property
	def speed_slider_fraction(self) -> float:
		return self._instance.SpeedSliderFraction
	@speed_slider_fraction.setter
	def speed_slider_fraction(self, value: float):
		self._instance.SpeedSliderFraction = value
	@property
	def standard_digital_output_mask(self) -> int:
		return self._instance.StandardDigitalOutputMask
	@standard_digital_output_mask.setter
	def standard_digital_output_mask(self, value: int):
		self._instance.StandardDigitalOutputMask = value
	@property
	def configurable_digital_output_mask(self) -> int:
		return self._instance.ConfigurableDigitalOutputMask
	@configurable_digital_output_mask.setter
	def configurable_digital_output_mask(self, value: int):
		self._instance.ConfigurableDigitalOutputMask = value
	@property
	def standard_digital_output(self) -> int:
		return self._instance.StandardDigitalOutput
	@standard_digital_output.setter
	def standard_digital_output(self, value: int):
		self._instance.StandardDigitalOutput = value
	@property
	def configurable_digital_output(self) -> int:
		return self._instance.ConfigurableDigitalOutput
	@configurable_digital_output.setter
	def configurable_digital_output(self, value: int):
		self._instance.ConfigurableDigitalOutput = value
	@property
	def standard_analog_output_mask(self) -> int:
		return self._instance.StandardAnalogOutputMask
	@standard_analog_output_mask.setter
	def standard_analog_output_mask(self, value: int):
		self._instance.StandardAnalogOutputMask = value
	@property
	def standard_analog_output_type(self) -> int:
		return self._instance.StandardAnalogOutputType
	@standard_analog_output_type.setter
	def standard_analog_output_type(self, value: int):
		self._instance.StandardAnalogOutputType = value
	@property
	def standard_analog_output0(self) -> float:
		return self._instance.StandardAnalogOutput0
	@standard_analog_output0.setter
	def standard_analog_output0(self, value: float):
		self._instance.StandardAnalogOutput0 = value
	@property
	def standard_analog_output1(self) -> float:
		return self._instance.StandardAnalogOutput1
	@standard_analog_output1.setter
	def standard_analog_output1(self, value: float):
		self._instance.StandardAnalogOutput1 = value
	@property
	def input_bt_registers0_to31(self) -> int:
		return self._instance.InputBtRegisters0To31
	@input_bt_registers0_to31.setter
	def input_bt_registers0_to31(self, value: int):
		self._instance.InputBtRegisters0To31 = value
	@property
	def input_bt_registers32_to63(self) -> int:
		return self._instance.InputBtRegisters32To63
	@input_bt_registers32_to63.setter
	def input_bt_registers32_to63(self, value: int):
		self._instance.InputBtRegisters32To63 = value
	@property
	def input_bit_registers(self) -> RtdeBitRegistersValue:
		return RtdeBitRegistersValue(self._instance.InputBitRegisters)
	@property
	def input_int_registers(self) -> RtdeIntRegistersValue:
		return RtdeIntRegistersValue(self._instance.InputIntRegisters)
	@property
	def input_double_registers(self) -> RtdeDoubleRegistersValue:
		return RtdeDoubleRegistersValue(self._instance.InputDoubleRegisters)
	@property
	def external_force_torque(self) -> CartesianCoordinates:
		return CartesianCoordinates(None, None, None, None, None, None, self._instance.ExternalForceTorque)
	@external_force_torque.setter
	def external_force_torque(self, value: CartesianCoordinates):
		self._instance.ExternalForceTorque = value
