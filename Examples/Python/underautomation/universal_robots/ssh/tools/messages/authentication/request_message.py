import typing
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Authentication import RequestMessage as request_message

class RequestMessage(Message):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = request_message()
		else:
			self._instance = _internal
	@property
	def username(self) -> typing.List[int]:
		return self._instance.Username
	@property
	def service_name(self) -> typing.List[int]:
		return self._instance.ServiceName
	@property
	def method_name(self) -> str:
		return self._instance.MethodName
