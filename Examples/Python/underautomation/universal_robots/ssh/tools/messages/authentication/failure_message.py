import typing
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Authentication import FailureMessage as failure_message

class FailureMessage(Message):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = failure_message()
		else:
			self._instance = _internal
	@property
	def allowed_authentications(self) -> str:
		return self._instance.AllowedAuthentications
	@allowed_authentications.setter
	def allowed_authentications(self, value: str):
		self._instance.AllowedAuthentications = value
	@property
	def message(self) -> str:
		return self._instance.Message
	@property
	def partial_success(self) -> bool:
		return self._instance.PartialSuccess
