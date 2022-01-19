import typing
from underautomation.universal_robots.ssh.tools.messages.connection.channel_open_info import ChannelOpenInfo
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import ChannelOpenMessage as channel_open_message

class ChannelOpenMessage(Message):
	def __init__(self, channelNumber: int, initialWindowSize: int, maximumPacketSize: int, info: ChannelOpenInfo, _internal = 0):
		if(_internal == 0):
			self._instance = channel_open_message(channelNumber, initialWindowSize, maximumPacketSize, info)
		else:
			self._instance = _internal
	@property
	def channel_type(self) -> typing.List[int]:
		return self._instance.ChannelType
	@property
	def local_channel_number(self) -> int:
		return self._instance.LocalChannelNumber
	@property
	def initial_window_size(self) -> int:
		return self._instance.InitialWindowSize
	@property
	def maximum_packet_size(self) -> int:
		return self._instance.MaximumPacketSize
	@property
	def info(self) -> ChannelOpenInfo:
		return ChannelOpenInfo(self._instance.Info)
