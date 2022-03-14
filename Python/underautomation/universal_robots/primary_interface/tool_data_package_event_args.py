import typing
from underautomation.universal_robots.common.analog_ranges import AnalogRanges
from underautomation.universal_robots.common.tool_modes import ToolModes
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import ToolDataPackageEventArgs as tool_data_package_event_args

class ToolDataPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = tool_data_package_event_args()
		else:
			self._instance = _internal
	@property
	def analog_input_range2(self) -> AnalogRanges:
		return AnalogRanges(self._instance.AnalogInputRange2)
	@analog_input_range2.setter
	def analog_input_range2(self, value: AnalogRanges):
		self._instance.AnalogInputRange2 = value
	@property
	def analog_input_range3(self) -> AnalogRanges:
		return AnalogRanges(self._instance.AnalogInputRange3)
	@analog_input_range3.setter
	def analog_input_range3(self, value: AnalogRanges):
		self._instance.AnalogInputRange3 = value
	@property
	def analog_input2(self) -> float:
		return self._instance.AnalogInput2
	@analog_input2.setter
	def analog_input2(self, value: float):
		self._instance.AnalogInput2 = value
	@property
	def analog_input3(self) -> float:
		return self._instance.AnalogInput3
	@analog_input3.setter
	def analog_input3(self, value: float):
		self._instance.AnalogInput3 = value
	@property
	def tool_voltage48_v(self) -> float:
		return self._instance.ToolVoltage48V
	@tool_voltage48_v.setter
	def tool_voltage48_v(self, value: float):
		self._instance.ToolVoltage48V = value
	@property
	def tool_output_voltage(self) -> int:
		return self._instance.ToolOutputVoltage
	@tool_output_voltage.setter
	def tool_output_voltage(self, value: int):
		self._instance.ToolOutputVoltage = value
	@property
	def tool_current(self) -> float:
		return self._instance.ToolCurrent
	@tool_current.setter
	def tool_current(self, value: float):
		self._instance.ToolCurrent = value
	@property
	def tool_temperature(self) -> float:
		return self._instance.ToolTemperature
	@tool_temperature.setter
	def tool_temperature(self, value: float):
		self._instance.ToolTemperature = value
	@property
	def tool_mode(self) -> ToolModes:
		return ToolModes(self._instance.ToolMode)
	@tool_mode.setter
	def tool_mode(self, value: ToolModes):
		self._instance.ToolMode = value
