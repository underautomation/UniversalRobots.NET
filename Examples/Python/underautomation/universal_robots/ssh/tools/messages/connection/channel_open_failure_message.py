import typing
from underautomation.universal_robots.ssh.tools.messages.connection.channel_message import ChannelMessage
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import ChannelOpenFailureMessage as channel_open_failure_message

class ChannelOpenFailureMessage(ChannelMessage):
	def __init__(self, localChannelNumber: int, description: str, reasonCode: int, language: str, _internal = 0):
		if(_internal == 0):
			self._instance = channel_open_failure_message(localChannelNumber, description, reasonCode, language)
		else:
			self._instance = _internal
	@property
	def reason_code(self) -> int:
		return self._instance.ReasonCode
	@property
	def description(self) -> str:
		return self._instance.Description
	@property
	def language(self) -> str:
		return self._instance.Language
