import typing
from underautomation.universal_robots.rtde.rtde_versions import RtdeVersions
from underautomation.universal_robots.rtde.rtde_output_setup import RtdeOutputSetup
from underautomation.universal_robots.rtde.rtde_input_setup import RtdeInputSetup
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde.Internal import RtdeParametersBase as rtde_parameters_base

class RtdeParametersBase:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_parameters_base()
		else:
			self._instance = _internal
	@property
	def frequency(self) -> float:
		return self._instance.Frequency
	@frequency.setter
	def frequency(self, value: float):
		self._instance.Frequency = value
	@property
	def version(self) -> RtdeVersions:
		return RtdeVersions(self._instance.Version)
	@version.setter
	def version(self, value: RtdeVersions):
		self._instance.Version = value
	@property
	def output_setup(self) -> RtdeOutputSetup:
		return RtdeOutputSetup(self._instance.OutputSetup)
	@output_setup.setter
	def output_setup(self, value: RtdeOutputSetup):
		self._instance.OutputSetup = value
	@property
	def input_setup(self) -> RtdeInputSetup:
		return RtdeInputSetup(self._instance.InputSetup)
	@input_setup.setter
	def input_setup(self, value: RtdeInputSetup):
		self._instance.InputSetup = value
