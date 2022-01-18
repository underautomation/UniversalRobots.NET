import typing
from underautomation.universal_robots.ssh.internal.sftp_client_base import SftpClientBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Internal import SftpClientInternal as sftp_client_internal

class SftpClientInternal(SftpClientBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = sftp_client_internal()
		else:
			self._instance = _internal
	def connect(self, username: str, password: str) -> None:
		self._instance.Connect(username, password)
