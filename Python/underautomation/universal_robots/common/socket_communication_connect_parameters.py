import typing
from underautomation.universal_robots.socket_communication.internal.socket_communication_parameters_base import SocketCommunicationParametersBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Common import SocketCommunicationConnectParameters as socket_communication_connect_parameters

class SocketCommunicationConnectParameters(SocketCommunicationParametersBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = socket_communication_connect_parameters()
		else:
			self._instance = _internal
	@property
	def enable(self) -> bool:
		return self._instance.Enable
	@enable.setter
	def enable(self, value: bool):
		self._instance.Enable = value
