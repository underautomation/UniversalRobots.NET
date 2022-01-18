import typing
from underautomation.universal_robots.ssh.tools.private_key_file import PrivateKeyFile
from underautomation.universal_robots.ssh.tools.proxy_types import ProxyTypes
from underautomation.universal_robots.ssh.tools.connection_info import ConnectionInfo
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import PrivateKeyConnectionInfo as private_key_connection_info

class PrivateKeyConnectionInfo(ConnectionInfo):
	def __init__(self, host: str, port: int, username: str, proxyType: ProxyTypes, proxyHost: str, proxyPort: int, proxyUsername: str, proxyPassword: str, keyFiles: PrivateKeyFile, _internal = 0):
		if(_internal == 0):
			self._instance = private_key_connection_info(host, port, username, proxyType, proxyHost, proxyPort, proxyUsername, proxyPassword, keyFiles)
		else:
			self._instance = _internal
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def key_files(self) -> typing.Any:
		return self._instance.KeyFiles
