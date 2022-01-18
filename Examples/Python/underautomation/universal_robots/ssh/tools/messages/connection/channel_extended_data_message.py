import typing
from underautomation.universal_robots.ssh.tools.messages.connection.channel_message import ChannelMessage
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import ChannelExtendedDataMessage as channel_extended_data_message

class ChannelExtendedDataMessage(ChannelMessage):
	def __init__(self, localChannelNumber: int, dataTypeCode: int, data: int, _internal = 0):
		if(_internal == 0):
			self._instance = channel_extended_data_message(localChannelNumber, dataTypeCode, data)
		else:
			self._instance = _internal
	@property
	def data_type_code(self) -> int:
		return self._instance.DataTypeCode
	@property
	def data(self) -> int:
		return self._instance.Data
