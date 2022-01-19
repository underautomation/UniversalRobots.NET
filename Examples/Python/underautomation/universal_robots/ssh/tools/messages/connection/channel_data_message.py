import typing
from underautomation.universal_robots.ssh.tools.messages.connection.channel_message import ChannelMessage
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import ChannelDataMessage as channel_data_message

class ChannelDataMessage(ChannelMessage):
	def __init__(self, localChannelNumber: int, data: typing.List[int], offset: int, size: int, _internal = 0):
		if(_internal == 0):
			self._instance = channel_data_message(localChannelNumber, data, offset, size)
		else:
			self._instance = _internal
	@property
	def data(self) -> typing.List[int]:
		return self._instance.Data
	@property
	def offset(self) -> int:
		return self._instance.Offset
	@offset.setter
	def offset(self, value: int):
		self._instance.Offset = value
	@property
	def size(self) -> int:
		return self._instance.Size
	@size.setter
	def size(self, value: int):
		self._instance.Size = value
