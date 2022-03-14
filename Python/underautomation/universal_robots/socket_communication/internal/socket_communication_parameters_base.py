import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.SocketCommunication.Internal import SocketCommunicationParametersBase as socket_communication_parameters_base

class SocketCommunicationParametersBase:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = socket_communication_parameters_base()
		else:
			self._instance = _internal
	@property
	def port(self) -> int:
		return self._instance.Port
	@port.setter
	def port(self, value: int):
		self._instance.Port = value
