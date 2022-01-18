import typing
from underautomation.universal_robots.ssh.tools.common.ssh_data import SshData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import ChannelOpenInfo as channel_open_info

class ChannelOpenInfo(SshData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = channel_open_info()
		else:
			self._instance = _internal
	@property
	def channel_type(self) -> str:
		return self._instance.ChannelType
