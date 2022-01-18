import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import MessageEventArgs as message_event_args_1

class MessageEventArgs1:
	def __init__(self, message: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = message_event_args_1(message)
		else:
			self._instance = _internal
	@property
	def message(self) -> typing.Any:
		return self._instance.Message
