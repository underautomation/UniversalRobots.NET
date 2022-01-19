import typing
from underautomation.universal_robots.ssh.tools.messages.connection.request_info import RequestInfo
from underautomation.universal_robots.ssh.tools.messages.connection.channel_message import ChannelMessage
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import ChannelRequestMessage as channel_request_message

class ChannelRequestMessage(ChannelMessage):
	def __init__(self, localChannelNumber: int, info: RequestInfo, _internal = 0):
		if(_internal == 0):
			self._instance = channel_request_message(localChannelNumber, info)
		else:
			self._instance = _internal
	@property
	def request_name(self) -> str:
		return self._instance.RequestName
	@property
	def request_data(self) -> typing.List[int]:
		return self._instance.RequestData
