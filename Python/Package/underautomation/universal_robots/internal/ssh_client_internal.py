import typing
from underautomation.universal_robots.ssh.internal.ssh_client_base import SshClientBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Internal import SshClientInternal as ssh_client_internal

class SshClientInternal(SshClientBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = ssh_client_internal()
		else:
			self._instance = _internal
	def connect(self, username: str, password: str) -> None:
		self._instance.Connect(username, password)
