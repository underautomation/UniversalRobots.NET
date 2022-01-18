import typing
from underautomation.universal_robots.ssh.tools.messages.connection.channel_message import ChannelMessage
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import ChannelSuccessMessage as channel_success_message

class ChannelSuccessMessage(ChannelMessage):
	def __init__(self, localChannelNumber: int, _internal = 0):
		if(_internal == 0):
			self._instance = channel_success_message(localChannelNumber)
		else:
			self._instance = _internal
