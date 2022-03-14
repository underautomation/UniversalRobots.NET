import typing
from underautomation.universal_robots.primary_interface.interfaces import Interfaces
from underautomation.universal_robots.primary_interface.internal.primary_interface_client_base import PrimaryInterfaceClientBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import PrimaryInterfaceClient as primary_interface_client

class PrimaryInterfaceClient(PrimaryInterfaceClientBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = primary_interface_client()
		else:
			self._instance = _internal
	def connect(self, ip: str, port: Interfaces) -> None:
		self._instance.Connect(ip, port._instance)
