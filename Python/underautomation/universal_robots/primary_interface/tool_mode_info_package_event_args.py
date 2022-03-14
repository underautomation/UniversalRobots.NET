import typing
from underautomation.universal_robots.common.output_modes import OutputModes
from underautomation.universal_robots.common.digital_output_configurations import DigitalOutputConfigurations
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import ToolModeInfoPackageEventArgs as tool_mode_info_package_event_args

class ToolModeInfoPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = tool_mode_info_package_event_args()
		else:
			self._instance = _internal
	@property
	def output_mode(self) -> OutputModes:
		return OutputModes(self._instance.OutputMode)
	@output_mode.setter
	def output_mode(self, value: OutputModes):
		self._instance.OutputMode = value
	@property
	def digital_output_mode0(self) -> DigitalOutputConfigurations:
		return DigitalOutputConfigurations(self._instance.DigitalOutputMode0)
	@digital_output_mode0.setter
	def digital_output_mode0(self, value: DigitalOutputConfigurations):
		self._instance.DigitalOutputMode0 = value
	@property
	def digital_output_mode1(self) -> DigitalOutputConfigurations:
		return DigitalOutputConfigurations(self._instance.DigitalOutputMode1)
	@digital_output_mode1.setter
	def digital_output_mode1(self, value: DigitalOutputConfigurations):
		self._instance.DigitalOutputMode1 = value
