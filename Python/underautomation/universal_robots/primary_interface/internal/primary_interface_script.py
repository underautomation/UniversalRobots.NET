import typing
from underautomation.universal_robots.common.status_code import StatusCode
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface.Internal import PrimaryInterfaceScript as primary_interface_script

class PrimaryInterfaceScript:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = primary_interface_script()
		else:
			self._instance = _internal
	def send(self, script: str) -> StatusCode:
		return StatusCode(self._instance.Send(script))
