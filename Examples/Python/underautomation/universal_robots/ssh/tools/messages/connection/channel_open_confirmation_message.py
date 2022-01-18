import typing
from underautomation.universal_robots.ssh.tools.messages.connection.channel_message import ChannelMessage
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import ChannelOpenConfirmationMessage as channel_open_confirmation_message

class ChannelOpenConfirmationMessage(ChannelMessage):
	def __init__(self, localChannelNumber: int, initialWindowSize: int, maximumPacketSize: int, remoteChannelNumber: int, _internal = 0):
		if(_internal == 0):
			self._instance = channel_open_confirmation_message(localChannelNumber, initialWindowSize, maximumPacketSize, remoteChannelNumber)
		else:
			self._instance = _internal
	@property
	def remote_channel_number(self) -> int:
		return self._instance.RemoteChannelNumber
	@property
	def initial_window_size(self) -> int:
		return self._instance.InitialWindowSize
	@property
	def maximum_packet_size(self) -> int:
		return self._instance.MaximumPacketSize
