import typing
from underautomation.universal_robots.ssh.tools.messages.connection.request_info import RequestInfo
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Connection import KeepAliveRequestInfo as keep_alive_request_info

class KeepAliveRequestInfo(RequestInfo):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = keep_alive_request_info()
		else:
			self._instance = _internal
	@property
	def request_name(self) -> str:
		return self._instance.RequestName
	@property
	def name(self) -> str:
		return self._instance.Name
	@name.setter
	def name(self, value: str):
		self._instance.Name = value
