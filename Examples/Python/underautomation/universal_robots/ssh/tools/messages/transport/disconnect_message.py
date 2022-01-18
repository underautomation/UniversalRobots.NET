import typing
from underautomation.universal_robots.ssh.tools.messages.transport.disconnect_reason import DisconnectReason
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Transport import DisconnectMessage as disconnect_message

class DisconnectMessage(Message):
	def __init__(self, reasonCode: DisconnectReason, message: str, _internal = 0):
		if(_internal == 0):
			self._instance = disconnect_message(reasonCode, message)
		else:
			self._instance = _internal
	@property
	def reason_code(self) -> DisconnectReason:
		return DisconnectReason(self._instance.ReasonCode)
	@property
	def description(self) -> str:
		return self._instance.Description
	@property
	def language(self) -> str:
		return self._instance.Language
