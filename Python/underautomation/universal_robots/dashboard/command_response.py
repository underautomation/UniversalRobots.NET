import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Dashboard import CommandResponse as command_response

class CommandResponse:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = command_response()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def succeed(self) -> bool:
		return self._instance.Succeed
	@succeed.setter
	def succeed(self, value: bool):
		self._instance.Succeed = value
	@property
	def message(self) -> str:
		return self._instance.Message
	@message.setter
	def message(self, value: str):
		self._instance.Message = value
