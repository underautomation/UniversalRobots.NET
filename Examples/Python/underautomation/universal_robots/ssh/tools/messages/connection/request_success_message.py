import typing
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import RequestSuccessMessage as request_success_message

class RequestSuccessMessage(Message):
	def __init__(self, boundPort: int, _internal = 0):
		if(_internal == 0):
			self._instance = request_success_message(boundPort)
		else:
			self._instance = _internal
	@property
	def bound_port(self) -> typing.Any:
		return self._instance.BoundPort
