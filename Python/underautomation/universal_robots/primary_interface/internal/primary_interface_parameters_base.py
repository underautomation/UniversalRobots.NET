import typing
from underautomation.universal_robots.primary_interface.interfaces import Interfaces
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface.Internal import PrimaryInterfaceParametersBase as primary_interface_parameters_base

class PrimaryInterfaceParametersBase:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = primary_interface_parameters_base()
		else:
			self._instance = _internal
	@property
	def port(self) -> Interfaces:
		return Interfaces(self._instance.Port)
	@port.setter
	def port(self, value: Interfaces):
		self._instance.Port = value
