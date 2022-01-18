import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde.Internal import RtdeClientParametersBase as rtde_client_parameters_base

class RtdeClientParametersBase:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_client_parameters_base()
		else:
			self._instance = _internal
	@property
	def frequency(self) -> float:
		return self._instance.Frequency
	@frequency.setter
	def frequency(self, value: float):
		self._instance.Frequency = value
