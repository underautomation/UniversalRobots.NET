import typing
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import ChannelMessage as channel_message

class ChannelMessage(Message):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = channel_message()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def local_channel_number(self) -> int:
		return self._instance.LocalChannelNumber
