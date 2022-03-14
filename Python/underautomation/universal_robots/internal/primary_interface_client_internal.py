import typing
from underautomation.universal_robots.primary_interface.interfaces import Interfaces
from underautomation.universal_robots.primary_interface.internal.primary_interface_client_base import PrimaryInterfaceClientBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Internal import PrimaryInterfaceClientInternal as primary_interface_client_internal

class PrimaryInterfaceClientInternal(PrimaryInterfaceClientBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = primary_interface_client_internal()
		else:
			self._instance = _internal
	def connect(self, port: Interfaces) -> None:
		self._instance.Connect(port._instance)
