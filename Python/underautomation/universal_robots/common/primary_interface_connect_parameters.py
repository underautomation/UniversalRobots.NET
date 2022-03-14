import typing
from underautomation.universal_robots.primary_interface.internal.primary_interface_parameters_base import PrimaryInterfaceParametersBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Common import PrimaryInterfaceConnectParameters as primary_interface_connect_parameters

class PrimaryInterfaceConnectParameters(PrimaryInterfaceParametersBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = primary_interface_connect_parameters()
		else:
			self._instance = _internal
	@property
	def enable(self) -> bool:
		return self._instance.Enable
	@enable.setter
	def enable(self, value: bool):
		self._instance.Enable = value
