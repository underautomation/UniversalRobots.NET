import typing
from underautomation.universal_robots.ssh.tools.common.ssh_data import SshData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import RequestInfo as request_info

class RequestInfo(SshData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = request_info()
		else:
			self._instance = _internal
	@property
	def request_name(self) -> str:
		return self._instance.RequestName
	@property
	def want_reply(self) -> bool:
		return self._instance.WantReply
